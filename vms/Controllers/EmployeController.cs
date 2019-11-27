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
    public class EmployeController : ControllerBase
    {
        private readonly IEmployeService _service;
        //private readonly IVatService _vatService;
        private readonly ISalaryService _salaryService;
        //private readonly IRightService _rightService;
        private readonly IConfiguration _configuration;
        //private readonly IOrganizationService _orgcConfiguration;
        //private readonly IProductLogService _logService;
        public EmployeController(
            ControllerBaseParamModel controllerBaseParamModel,
            IEmployeService service,
           // IVatService vatService,
            //ISalaryService prodService,
            ISalaryService salaryService
            //IRightService rightService, 
            //IOrganizationService orgcConfiguration
            ) : base(controllerBaseParamModel)
        {
            _salaryService = salaryService;
            _service = service;
            _configuration = Configuration;
            //_vatService = vatService;
            //_prodService = prodService;
            //_rightService = rightService;
            //_orgcConfiguration = orgcConfiguration;
        }



        public async Task<IActionResult> Index(int? page, string search = null)
        {
            var data = await _service.Query().Where(x => x.IsActive == true).SelectAsync();
            string txt = search;
            //
            if (search != null)
            {
                search = search.ToLower().Trim();
                data = data.Where(c => c.Name.ToLower().Contains(search) || c.Address.ToString().Contains(search) || c.Mobile.ToString().Contains(search) || c.Nid.ToString().Contains(search) || c.JoiningDate.ToString().Contains(search));

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


        public async Task<IActionResult> Create(Employe emp)
        {
            if (emp.Name.Any())
            {
                emp.CreatedBy = _session.UserId;
                emp.CreatedTime = DateTime.Now;
                emp.JoiningDate = DateTime.Now;
                emp.BranchId = _session.BranchId;
                emp.IsActive = true;


                _service.Insert(emp);
                await UnitOfWork.SaveChangesAsync();
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
            return View(emp);
        }




        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var User = await _service.Query()
                .SingleOrDefaultAsync(m => m.EmployeId == id, CancellationToken.None);
            if (User == null)
            {
                return NotFound();
            }
            return View(User);
        }


        [HttpPost]

        public async Task<IActionResult> Edit(Employe empa)
        {

            if (empa.EmployeId == 0)
            {
                return NotFound();
            }

            try
            {
                var data =await _service.GetById(empa.EmployeId);
                data.Name = empa.Name;
                data.Nid = empa.Nid;
                data.Mobile = empa.Mobile;
                data.AlterMobile = empa.AlterMobile;
                data.Designation = empa.Designation;
                data.Gender = empa.Gender;
                data.Email = empa.Email;
                _service.Update(data);
           
                await UnitOfWork.SaveChangesAsync();

                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
                return View(empa);
            }
        }









        public async Task<IActionResult> Delete(int id)
        {

            if (id == null)
            {
                return NotFound();
            }

            try
            {
                var data = await _service.Query().SingleOrDefaultAsync(m => m.EmployeId == id, CancellationToken.None);
                data.IsActive = false;
                data.DeactiveDate = DateTime.Now;
                _service.Update(data);

                await UnitOfWork.SaveChangesAsync();

                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.DELETE_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
        }




        public async Task<IActionResult> PriceSetup(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await _salaryService.Query().SingleOrDefaultAsync(w => w.EmployeId == id && w.IsActive == true, CancellationToken.None);


            if (price == null)
            {

                price = new Salary();
                price.EmployeId = id;
            }



            return View(price);
        }

        [HttpPost]


        public async Task<IActionResult> PriceSetup(Salary price)
        {
            if (price.EmployeId != null)
            {


                var previous = await _salaryService.Query().SingleOrDefaultAsync(p => p.EmployeId == price.EmployeId && p.IsActive == true, CancellationToken.None);

                if (previous != null)
                {
                    previous.IsActive = false;
                    previous.DeactiveDate = DateTime.Now;

                    _salaryService.Update(previous);

                    await UnitOfWork.SaveChangesAsync();
                }


                price.SalaryId = 0;

                price.Createdby = _session.UserId;
                price.CreatedTime = DateTime.Now;
                price.JoingDate = DateTime.Now;

                price.IsActive = true;


                _salaryService.Insert(price);
                await UnitOfWork.SaveChangesAsync();
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
            return View(price);
        }












    }
}