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
    public class SaleController : ControllerBase
    {



      
        public SaleController(
            ControllerBaseParamModel controllerBaseParamModel
         
            ) : base(controllerBaseParamModel)
        {
           
        }


        public IActionResult Index()
        {


            return View();
        }






    }
}