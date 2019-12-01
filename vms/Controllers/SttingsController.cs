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
    public class SttingsController : ControllerBase
    {



        private readonly ISettingService _service;

        private readonly IConfiguration _configuration;
   
        public SttingsController(
            ControllerBaseParamModel controllerBaseParamModel,
            ISettingService service
      
            ) : base(controllerBaseParamModel)
        {

            _service = service;
            _configuration = Configuration;
       
        }



        public async Task<IActionResult> Index()
        {
           var data = await _service.Query().SingleOrDefaultAsync(m => m.IsActive == true, CancellationToken.None);
           
          if(data==null)
            {
                data = new Setting();
                data.IsActive = false;
                data.IsIncentiveCount = false;
                data.IsattendenceCount = false;
                data.IsProductDiscount = false;
                data.IsrewardPoitCount = false;
                data.IsadvanceSalary = false;
                data.IsOvertime = false;
                data.IsCanGiveSalary = false;





            }
          


            return View(data);

        }





        //public IActionResult Create()
        //{

        //    return View();
        //}

        //[HttpPost]


        //public async Task<IActionResult> Create(Vat vat)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        vat.CreatedBy = _session.UserId;
        //        vat.CreatedTime = DateTime.Now;
        //        vat.EfectiveFrom = DateTime.Now;

        //        vat.IsActive = true;

        //        _vatService.Insert(vat);
        //        await UnitOfWork.SaveChangesAsync();
        //        TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
        //        return RedirectToAction(nameof(Index));
        //    }
        //    TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
        //    return View(vat);
        //}

        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var exportType = await _vatService.Query()
        //        .SingleOrDefaultAsync(m => m.VatId == id, CancellationToken.None);
        //    if (exportType == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(exportType);
        //}


        [HttpPost]

        public async Task<IActionResult> Edit(Setting set)
        {



            try
            {


                var data = new Setting();

                if (set.SettingsId != 0)
                {

                    

                    set.EfectiveTo = DateTime.Now;
                    set.IsActive = false;

                    _service.Update(set);
                    await UnitOfWork.SaveChangesAsync();

                    data.SettingsId = 0;

                }

                

                data.IsActive = true;
                data.CreatedBy = _session.UserId;
                data.CreatedTime = DateTime.Now;
                data.EfectiveFrom = DateTime.Now;
                data.EfectiveTo = null;

                _service.Insert(data);
                await UnitOfWork.SaveChangesAsync();
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
                return RedirectToAction(nameof(Index));
            }
        }









        //public async Task<IActionResult> Delete(int id)
        //{

        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    try
        //    {
        //        var data = await _vatService.Query().SingleOrDefaultAsync(m => m.VatId == id, CancellationToken.None);
        //        data.IsActive = false;
        //        data.EfectiveTo = DateTime.Now;
        //        _vatService.Update(data);

        //        await UnitOfWork.SaveChangesAsync();

        //        TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.DELETE_CLASSNAME;
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
        //        return RedirectToAction(nameof(Index));
        //    }
        //}


    }
}