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

namespace Inventory.Controllers
{
    public class ReportsController : ControllerBase
    {
    
        private readonly IConfiguration _configuration;
        private readonly IReportsService _service;
       
     
        public ReportsController(
            ControllerBaseParamModel controllerBaseParamModel,
           IReportsService service
            ) : base(controllerBaseParamModel)
        {

            service = _service;
        }



        public async Task<IActionResult> Index()
        {

            try
            {
                var data = await _service.ProfitReport(DateTime.Now.AddMonths(-1), DateTime.Now);
            }catch(Exception ex)
            {

            }
           





            return View();
        }


        
    }
}