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
using vms.Utility;
using vms.utility.StaticData;

namespace vms.Controllers
{
    public class HomeController : ControllerBase
    {

        private readonly IUserService _service;
        private readonly IRoleRightService _roleRightService;
        private readonly IRightService _rightService;
        private readonly IConfiguration _configuration;
        private readonly IOrganizationService _orgcConfiguration;

        public HomeController(ControllerBaseParamModel controllerBaseParamModel, IUserService service, IRoleRightService roleRightService, IRightService rightService, IOrganizationService orgcConfiguration) : base(controllerBaseParamModel)
        {




            _service = service;
            _roleRightService = roleRightService;
            _configuration = Configuration;
            _rightService = rightService;
            _orgcConfiguration = orgcConfiguration;
        }

        //[AnnonymousFilter]

        [VmsAuthorizeAttribute(FeatureList.IS_NBR_USER)]
        public IActionResult Index()
        {

            HttpContext.Session.Clear();


            return View();
        }



        public IActionResult Reference()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            var usr = HttpContext.Session.GetComplexData<User>(ViewStaticData.USER);
            //if (UserRole.Check(FeatureList.IS_NBR_USER,_session.Rights))
            if (_session.OrganizationId == 0)
            {
                return RedirectToAction(ControllerStaticData.NBR_USER, ControllerStaticData.HOME);
            }
            return View(usr);
        }



        [VmsAuthorizeAttribute(FeatureList.IS_NBR_USER)]
        public async Task<IActionResult> NbrUser()
        {

            var org = new Organization();


            org = await _orgcConfiguration.Query().SingleOrDefaultAsync(c => c.OrganizationId == _session.OrganizationId, CancellationToken.None);



            return View(org);
        }




        [VmsAuthorizeAttribute(FeatureList.IS_NBR_USER)]
        public async Task<IActionResult> LogOrg(int id)
        {

            var org = new Organization();


            org = await _orgcConfiguration.Query().SingleOrDefaultAsync(c => c.OrganizationId == id, CancellationToken.None);




            if (id >= 0)
            {
                var session = new vmSession
                {
                    UserId = _session.UserId,
                    UserName = _session.UserName,
                    RoleId = _session.RoleId,
                    RoleName = _session.RoleName,
                    OrganizationId = id,
                    OrganizationName = org.Name,
                    Rights = _session.Rights  //comes from role right
                };
                HttpContext.Session.SetComplexData(ControllerStaticData.SESSION, session);
            }
            return RedirectToAction(ControllerStaticData.DISPLAY_DASHBOARD, ControllerStaticData.HOME);
        }

        [VmsAuthorizeAttribute(FeatureList.IS_NBR_USER)]
        public async Task<IActionResult> LogOutOrg(int id)
        {

            if (_session.OrganizationId == 0)
            {
                return RedirectToAction(ControllerStaticData.DISPLAY_INDEX, ControllerStaticData.AUTHENTICATION);
            }

            else
            {


                var org = new Organization();


                org = await _orgcConfiguration.Query().SingleOrDefaultAsync(c => c.OrganizationId == 0, CancellationToken.None);






                var session = new vmSession
                {
                    UserId = _session.UserId,
                    UserName = _session.UserName,
                    RoleId = _session.RoleId,
                    RoleName = _session.RoleName,
                    OrganizationId = 0,
                    OrganizationName = org.Name,
                    Rights = _session.Rights  //comes from role right
                };
                HttpContext.Session.SetComplexData(ControllerStaticData.SESSION, session);



            }

            return RedirectToAction(ControllerStaticData.DISPLAY_DASHBOARD, ControllerStaticData.HOME);
        }


        public IActionResult About()
        {
            ViewData[ControllerStaticData.MESSAGE] = MessageStaticData.DASHBOARD_APPLICATION_DISPLAY_MESSAGE;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData[ControllerStaticData.MESSAGE] = MessageStaticData.DASHBOARD_CONTAC_DISPLAY_MESSAGE;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}