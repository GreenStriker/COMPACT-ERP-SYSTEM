using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

using Microsoft.Extensions.Configuration;

using System.Threading;

using vms.entity.models;
using vms.entity.viewModels;
using vms.service.dbo;
using vms.utility;
using vms.utility.StaticData;
using Inventory.Utility;


namespace Inventory.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IUserService _service;

        public DefaultController(
          
           IUserService service
          )
        {
            _service = service;
         
        }





        public async Task<IActionResult> Index()
        {

            var userData = await _service.GetUser(1);


            return View();
        }
    }
}