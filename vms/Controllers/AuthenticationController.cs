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
using vms.Utility;

namespace vms.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IUserService _service;
        private readonly IRoleRightService _roleRightService;
        private readonly IRightService _rightService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;

        public AuthenticationController(ControllerBaseParamModel controllerBaseParamModel, IConfiguration Configuration, IUserService service, IRoleRightService roleRightService, IRightService rightService, IHostingEnvironment hostingEnvironment)
        {
            _service = service;
            _roleRightService = roleRightService;
            _configuration = Configuration;
            _rightService = rightService;
            this._hostingEnvironment = hostingEnvironment;
        }

        //[AnnonymousFilter]
        public IActionResult Index(string userAgent)
        {

            if (string.IsNullOrEmpty(userAgent))
            {
                userAgent = Request.Headers[ControllerStaticData.USER_AGENT];
            }
            ViewBag.userAgent = userAgent;


            ViewResult vr = View();
            HttpContext.Session.Clear();
            if (_hostingEnvironment.IsDevelopment())
            {
                vr = View(ControllerStaticData.INDEX_DEV);
            }
            return vr;
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(User user)
        {
           
            string encryptionKey = _configuration.GetValue<string>(ControllerStaticData.PRIVATE_DATA_ENCRYPTION_KEY);

            var userData = await _service.Query().Include(c=> c.Organization).Include(z => z.Role).SingleOrDefaultAsync(w => w.UserName.ToLower() == user.UserName.Trim().ToLower(), CancellationToken.None);

            if (userData != null)
            {
                
                var decriptedPasswrd = new PasswordGenerate().Decrypt(userData.Password, encryptionKey);

                if (userData.UserName.ToLower() == user.UserName.Trim().ToLower() && decriptedPasswrd == user.Password && userData.IsActive == true)
                {
                    var roleRights = await _roleRightService.Query().Where(w => w.RoleId == userData.RoleId).
                    Include(p => p.Right).SelectAsync();
                    var rights = roleRights.Select(x => new Right
                    {
                        RightId = x.RightId,
                        RightName = x.Right.RightName
                    }).ToList();
                    var session = new vmSession
                        {

                            UserId = userData.UserId,
                            UserName = userData.UserName,
                            RoleId = userData.RoleId,
                            RoleName = userData.Role.RoleName,
                            OrganizationId =(int) userData.OrganizationId,
                            OrganizationName = userData.Organization.Name,
                            Rights = rights  //comes from role right
                        };
                  
                    HttpContext.Session.SetComplexData(vms.utility.StaticData.ControllerStaticData.SESSION, session);
                    if (userData.IsDefaultPassword == true)
                    {
                        return RedirectToAction(ViewStaticData.CHANGE_PASSWORD, ViewStaticData.USER);
                    }

                    return RedirectToAction(ControllerStaticData.DISPLAY_DASHBOARD, ControllerStaticData.HOME);
                }
                else
                {
                    ViewData[ControllerStaticData.MESSAGE] = MessageStaticData.DASHBOARD_PASSWORD_CHECK_MESSAGE;
                }
            }
            else
            {
                ViewData[ControllerStaticData.MESSAGE] = MessageStaticData.INVALID_USERNAME;
            }

            return RedirectToAction(ControllerStaticData.DISPLAY_INDEX, ControllerStaticData.AUTHENTICATION);
        }
    }
}