using Microsoft.AspNetCore.Http;
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
    public class PaymentMethodController : ControllerBase
    {

        private readonly IPaymentMethodService _service;
        
       
      
        private readonly IConfiguration _configuration;
   
        public PaymentMethodController(
            ControllerBaseParamModel controllerBaseParamModel,
            IPaymentMethodService service
        
        
            ) : base(controllerBaseParamModel)
        {
            
            _service = service;
          
        }



        public async Task<IActionResult> Index(int? page, string search = null)
        {
            var data = await _service.Query().SelectAsync();
            string txt = search;

            if (search != null)
            {
                search = search.ToLower().Trim();
                data = data.Where(c => c.Name.ToLower().Contains(search) || c.Number.ToLower().Contains(search) || c.Remark.ToLower().Contains(search));

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


        public async Task<IActionResult> Create(PaymentMethod pay)
        {
            if (ModelState.IsValid)
            {
                pay.CreatedBy = _session.UserId;
                pay.CreatedTime = DateTime.Now;
                //pay.EfectiveFrom = DateTime.Now;

                //pay.IsActive = true;

                _service.Insert(pay);
                await UnitOfWork.SaveChangesAsync();
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
            return View(pay);
        }







    }
}