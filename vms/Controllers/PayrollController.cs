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
    public class PayrollController : ControllerBase
    {


        private readonly ISettingService _setservice;
        private readonly IPayrollService _service;
        private readonly IPayrollDetailService _Detailservice;

        private readonly IEmployeService _empservice;
        private readonly IAtendenceService _attendservice;
        private readonly IAdvancedSalaryService _Advancedservice;
        private readonly IOvertimeService _OverTimeservice;
        private readonly IIncentiveService _Incentiveservice;
        private readonly IExpenceService _expenceeservice;
        private readonly ISalaryService _salaryeservice;


        private readonly IConfiguration _configuration;
      
        private readonly IProductLogService _logService;
        public PayrollController(
            ControllerBaseParamModel controllerBaseParamModel,
            IPayrollService service,
            IPayrollDetailService Detailservice,
            ISalaryService salaryeservice,
            ISettingService setservice,
            IExpenceService expenceeservice,


        IEmployeService empservice,
        IAtendenceService       attendservice,
        IAdvancedSalaryService  Advancedservice,
        IOvertimeService        OverTimeservice,
        IIncentiveService       Incentiveservice




       
            ) : base(controllerBaseParamModel)
        {
     
            _service = service;
            _Detailservice = Detailservice;
            _configuration = Configuration;
            _empservice = empservice;
              _setservice = setservice;
            _expenceeservice = expenceeservice;
            _salaryeservice = salaryeservice;
             _attendservice      = attendservice;
             _Advancedservice    = Advancedservice;
             _OverTimeservice     = OverTimeservice;
            _Incentiveservice = Incentiveservice;


        }



        public async Task<IActionResult> Index(int? page, string search = null)
        {

            var set = await _setservice.Query().SingleOrDefaultAsync(m => m.IsActive == true, CancellationToken.None);


            var data = await _service.Query().Include(c=>c.Branch).Include(c => c.Settings).Include(c => c.Expence.Payment).Include(c => c.Expence).Where(x=> x.BranchId == _session.BranchId).OrderByDescending(c => c.PayrollId).SelectAsync();
            string txt = search;

            if (search != null)
            {
                search = search.ToLower().Trim();
                data = data.Where(c => c.Year.ToString().ToLower().Contains(search));

            }
            if (txt != null)
            {
                ViewData[ViewStaticData.SEARCH_TEXT] = txt;
            }
            else
            {
                ViewData[ViewStaticData.SEARCH_TEXT] = string.Empty;

            }

            ViewBag.Active = set.IsCanGiveSalary;
            var pageNumber = page ?? 1;
            var listOfdata = data.ToPagedList(pageNumber, 10);
            return View(listOfdata);

        }





        public async Task<IActionResult> Create()
        {

            var set = await _setservice.Query().SingleOrDefaultAsync(m => m.IsActive == true, CancellationToken.None);

            var curentDate = DateTime.Now.AddMonths(-1);
          


            int month = Convert.ToInt32(curentDate.Month);
            int year = Convert.ToInt32(curentDate.Year);


            var data = await _service.Query().SingleOrDefaultAsync(m => m.Month == month && m.Year == year && m.BranchId == _session.BranchId, CancellationToken.None);


            if (data == null && set.IsCanGiveSalary==true)
            {

                var payroll = new Payroll();
                payroll.Month = month;
                payroll.Year = year;
                payroll.SettingsId = set.SettingsId;
                payroll.BranchId = _session.BranchId;
                payroll.CreatedBy = _session.UserId;
                payroll.CreatedTime = DateTime.Now;


                _service.Insert(payroll);



                var employes = await _empservice.Query().Where(x => x.BranchId == _session.BranchId && x.IsActive==true).SelectAsync();
                decimal count = 0;

                foreach(var item in employes)
                {

                    decimal salaryOFtheMonth = 0;
                    if(set.IsattendenceCount==true)
                    {




                    }

                    var advancedSalary = await _Advancedservice.Query().Where(x => x.EmloyId == item.EmployeId && x.IsActive == true).SelectAsync();
                    var Overtime = await _OverTimeservice.Query().Where(x => x.EmployId == item.EmployeId && x.IsActive == true).SelectAsync();
                    var Incentive = await _Incentiveservice.Query().Where(x => x.EmployId == item.EmployeId && x.IsActive == true).SelectAsync();
                    var salryBase = await _salaryeservice.Query().SingleOrDefaultAsync(m => m.EmployeId == item.EmployeId && m.IsActive == true, CancellationToken.None);
                    

                    decimal eadvance = 0, eover = 0, eincentive = 0;

                    if(advancedSalary!=null)
                    {

                        foreach(var itms in advancedSalary)
                        {
                            eadvance = eadvance + itms.Amount;


                            itms.IsActive = false;
                            itms.Remarks = itms.Remarks + "Colosed in payroll " + payroll.PayrollId.ToString();

                            _Advancedservice.Update(itms);

                        }



                    }
                    if (Overtime != null)
                    {

                        foreach (var itms in Overtime)
                        {
                            eover = eover + itms.OverTimeHoure;


                            itms.IsActive = false;
                            itms.Remarks = itms.Remarks + "Colosed in payroll " + payroll.PayrollId.ToString();

                            _OverTimeservice.Update(itms);

                        }

                        eover = eover * set.OverTimeRatio;

                    }





                    if (Incentive != null)
                    {

                        foreach (var itms in Incentive)
                        {
                            eincentive = eincentive + itms.IncentivePoint;


                            itms.IsActive = false;
                            // itms.Remarks = itms.Remarks + "Colosed in payroll " + payroll.PayrollId.ToString();

                            _Incentiveservice.Update(itms);

                        }



                    }



                    if (salryBase.BaseSalary != null) { 


                    salaryOFtheMonth = salryBase.BaseSalary - eadvance +eover+eincentive;

                        var paydetail = new PayrollDetail();

                        paydetail.AdvancedAmount = eadvance;
                        paydetail.OverTimeAmount = eover;
                        paydetail.IncentiveAmount = eincentive;
                        paydetail.PayableSalary = salaryOFtheMonth;
                        paydetail.SalaryId = salryBase.SalaryId;
                        paydetail.PayrollId = payroll.PayrollId;
                        paydetail.BaseSalary = salryBase.BaseSalary;
                        paydetail.EmployeId = item.EmployeId;
                        _Detailservice.Insert(paydetail);


                        count = count + salaryOFtheMonth;


                    }
                }

                await UnitOfWork.SaveChangesAsync();


                //

                var expence = new Expence();

                expence.BranchId = _session.BranchId;
                expence.CreatedBy = _session.UserId;
                expence.ExpenceTypeId = 1;
                expence.ExpenceAmount = count;
                expence.ExpencePerson = _session.UserId;
                expence.ExpencePurpose = "Monthly Salary :"+month.ToString()+"-"+year.ToString();


                _expenceeservice.Insert(expence);

                await UnitOfWork.SaveChangesAsync();




                var lastpayroll = await _service.Query().SingleOrDefaultAsync(m => m.PayrollId == payroll.PayrollId, CancellationToken.None);

                lastpayroll.ExpenceId = expence.ExpenceId;

                _service.Update(lastpayroll);

                await UnitOfWork.SaveChangesAsync();
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
                return RedirectToAction(nameof(Index));

            }



            TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
            return RedirectToAction(nameof(Index));




            return View();
        }

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


        //[HttpPost]

        //public async Task<IActionResult> Edit(Vat vat)
        //{

        //    if (vat.VatId == 0)
        //    {
        //        return NotFound();
        //    }

        //    try
        //    {
        //        var id = vat.VatId;
        //        var data = await _vatService.Query().SingleOrDefaultAsync(m => m.VatId == id, CancellationToken.None);
        //        data.IsActive = false;
        //        data.EfectiveTo = DateTime.Now;
        //        _vatService.Update(data);
        //        vat.VatId = 0;
        //        vat.EfectiveFrom = DateTime.Now;
        //        vat.CreatedBy = _session.UserId;
        //        vat.CreatedTime = DateTime.Now;
        //        vat.IsActive = true;

        //        _vatService.Insert(vat);
        //        await UnitOfWork.SaveChangesAsync();
        //        var prodData = _prodService.Queryable().Where(c => c.VatId == id).AsQueryable();
        //        var log = new ProductLog();
        //        foreach (var item in prodData)
        //        {
        //            log.VatId = item.VatId;
        //            log.Code = item.Code;
        //            log.Name = item.Name;
        //            log.CreatedBy = item.CreatedBy;
        //            log.EfectiveFrom = item.EfectiveFrom;
        //            log.EfectiveTo = item.EfectiveTo;
        //            log.ProductId = item.ProductId;
        //            _logService.Insert(log);

        //        }
        //        await UnitOfWork.SaveChangesAsync();
        //        foreach (var item in prodData)
        //        {
        //            item.VatId = vat.VatId;
        //            _prodService.Update(item);

        //        }
        //        await UnitOfWork.SaveChangesAsync();
        //        TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.ERROR_CLASSNAME;
        //        return View(vat);
        //    }
        //}







    

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