﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;
using vms.Models;
using vms.service.dbo;
using vms.utility;
using Inventory.Utility;
using vms.utility.StaticData;
using X.PagedList;
using System;

namespace Inventory.Controllers
{
    public class VatController : ControllerBase
    {



        private readonly IUserService _service;
        private readonly IVatService _vatService;
        private readonly IProductService _prodService;
        //private readonly IRightService _rightService;
        private readonly IConfiguration _configuration;
        //private readonly IOrganizationService _orgcConfiguration;
        private readonly IProductLogService _logService;
        public VatController(
            ControllerBaseParamModel controllerBaseParamModel,
            IUserService service,
            IVatService vatService,
            IProductService prodService,
            IProductLogService logService
            //IRightService rightService, 
            //IOrganizationService orgcConfiguration
            ) : base(controllerBaseParamModel)
        {
            _logService = logService;
            _service = service;
            _configuration = Configuration;
            _vatService = vatService;
            _prodService = prodService;
            //_rightService = rightService;
            //_orgcConfiguration = orgcConfiguration;
        }



        public async Task<IActionResult> Index(int? page, string search = null)
        {
            var data = await _vatService.Query().SelectAsync();
            string txt = search;

            if (search != null)
            {
                search = search.ToLower().Trim();
                data = data.Where(c => c.Name.ToLower().Contains(search) || c.Percentage.ToString().Contains(search));

            }
            if (txt != null)
            {
                ViewData[ViewStaticData.SEARCH_TEXT] = txt;
            }
            else
            {
                ViewData[ViewStaticData.SEARCH_TEXT] = string.Empty;

            }
            var pageNumber = page ?? 1;
            var listOfdata = data.ToPagedList(pageNumber, 10);
            return View(listOfdata);

        }





        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]


        public async Task<IActionResult> Create(Vat vat)
        {
            if (ModelState.IsValid)
            {
                vat.CreatedBy = _session.UserId;
                vat.CreatedTime = DateTime.Now;
                vat.EfectiveFrom = DateTime.Now;

                vat.IsActive = true;

                _vatService.Insert(vat);
                await UnitOfWork.SaveChangesAsync();
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
            return View(vat);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exportType = await _vatService.Query()
                .SingleOrDefaultAsync(m => m.VatId == id, CancellationToken.None);
            if (exportType == null)
            {
                return NotFound();
            }
            return View(exportType);
        }


        [HttpPost]

        public async Task<IActionResult> Edit(Vat vat)
        {

            if (vat.VatId == 0)
            {
                return NotFound();
            }

            try
            {
                var id = vat.VatId;
                var data = await _vatService.Query().SingleOrDefaultAsync(m => m.VatId == id, CancellationToken.None);
                data.IsActive = false;
                data.EfectiveTo = DateTime.Now;
                _vatService.Update(data);
                vat.VatId = 0;
                vat.EfectiveFrom = DateTime.Now;
                vat.CreatedBy = _session.UserId;
                vat.CreatedTime = DateTime.Now;

                _vatService.Insert(vat);
                await UnitOfWork.SaveChangesAsync();
                var prodData = _prodService.Queryable().Where(c => c.VatId == id).AsQueryable();
                var log = new ProductLog();
                foreach (var item in prodData)
                {
                    log.VatId = item.VatId;
                    log.Code = item.Code;
                    log.Name = item.Name;
                    log.CreatedBy = item.CreatedBy;
                    log.EfectiveFrom = item.EfectiveFrom;
                    log.EfectiveTo = item.EfectiveTo;
                    log.ProductId = item.ProductId;
                    _logService.Insert(log);

                }
                await UnitOfWork.SaveChangesAsync();
                foreach (var item in prodData)
                {
                    item.VatId = vat.VatId;
                    _prodService.Update(item);

                }
                await UnitOfWork.SaveChangesAsync();
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
                return View(vat);
            }
        }

    }
}