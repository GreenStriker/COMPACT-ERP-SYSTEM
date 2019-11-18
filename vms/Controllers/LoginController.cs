using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;
using vms.service.dbo;
using vms.utility;
using vms.utility.StaticData;
using Inventory.Utility;



namespace Inventory.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUserService _service;
        //private readonly IRoleRightService _roleRightService;
        //private readonly IRightService _rightService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;

        public LoginController(
            ControllerBaseParamModel controllerBaseParamModel,
            IConfiguration Configuration, 
            IUserService service, 
            //IRoleRightService roleRightService, 
            //IRightService rightService, 
            IHostingEnvironment hostingEnvironment)
        {
            _service = service;
            //_roleRightService = roleRightService;
            _configuration = Configuration;
            //_rightService = rightService;
            this._hostingEnvironment = hostingEnvironment;
        }


        public IActionResult Index()
        {
            //var userData = await _service.Query().SingleOrDefaultAsync(w => w.Uid == 1, CancellationToken.None);

            return View();
        }
    }
}