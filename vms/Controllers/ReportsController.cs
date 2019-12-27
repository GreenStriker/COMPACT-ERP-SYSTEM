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
using vms.service.dbo.StoredProdecure;
using vms.utility;
using Inventory.Utility;
using vms.utility.StaticData;
using X.PagedList;
using System;
using vms.entity.viewModels.ReportsViewModel;

namespace Inventory.Controllers
{
    public class ReportsController : ControllerBase
    {
    
        private readonly IConfiguration _configuration;
        private readonly IReportsService _service;
        private readonly IStoreProcedureService _Storeservice;
       
     
     
        public ReportsController(
            ControllerBaseParamModel controllerBaseParamModel,
           IReportsService service,
           IStoreProcedureService Storeservice



            ) : base(controllerBaseParamModel)
        {

            _service = service;
            _Storeservice = Storeservice;
        }



        public async Task<IActionResult> Index()
        {
            

            return View();
        }

        public async Task<IActionResult> Profit()
        {


            var data = await _service.ProfitReport(DateTime.Now.AddMonths(-1), DateTime.Now);




            var model = new ProfitReport();


            model.profit = data;

            model.fromDate = DateTime.Now.AddMonths(-1);
            model.toDate = DateTime.Now;

            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Profit(ProfitReport md )
        {


            var data = await _service.ProfitReport(md.fromDate, md.toDate);




            var model = new ProfitReport();


            model.profit = data;

            model.fromDate = md.fromDate;
            model.toDate = md.toDate;

            return View(model);
        }





        public async Task<IActionResult> Stock()
        {


            var data = await _Storeservice.StockList(_session.BranchId);





            return View(data);
        }










    }
}