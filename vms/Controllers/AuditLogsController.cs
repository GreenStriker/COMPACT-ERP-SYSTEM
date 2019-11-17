using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using vms.ActionFilter;
using vms.entity.Enums;
using vms.entity.models;
using vms.entity.viewModels;
using vms.service.dbo;
using vms.utility.StaticData;
using vms.Utility;
using X.PagedList;

namespace vms.Controllers
{
    public class AuditLogsController : ControllerBase
    {
        private readonly IAuditLogService _service;
        private readonly IObjectTypeService _objService;
        public AuditLogsController(ControllerBaseParamModel controllerBaseParamModel, IAuditLogService service, IObjectTypeService objService) : base(controllerBaseParamModel)
        {
            _service = service;
            _objService = objService;
        }


        // GET: AuditLogs
        [VmsAuthorizeAttribute(FeatureList.AUDIT)]
        
        public async Task<IActionResult> Index(int? page,string search=null, int objectType=0)
        {
            var organizationId = _session.OrganizationId;
            var audits = await _service.Query().Where(w=>w.IsActive==true && organizationId==_session.OrganizationId)
                .Include(a => a.ObjectType).Include(a=>a.AuditOperation).Include(a => a.User).Where(c=>c.OrganizationId==organizationId).SelectAsync();


            string txt = search;

            if(objectType!=0)
            {
                audits = audits.Where(c => c.ObjectType.ObjectTypeId==objectType  );



            }



            if (search!=null)
            {
                search = search.ToLower();
                audits = audits.Where(c => c.AuditOperation.Name.ToLower().Contains(search)
                                           || c.ObjectType.Name.ToLower().Contains(search) || c.User.UserName.ToLower().Contains(search)
                                           || c.Descriptions.ToLower().Contains(search)
                                           || c.CreatedTime.ToString().Contains(search));
            }




            var pageNumber = page ?? 1;
            var listOfAudit = audits.ToPagedList(pageNumber, 5);


            var objectList = new List<ObjectType>
            {
                new ObjectType
                {
                    ObjectTypeId = 0,
                    Name = ViewStaticData.SELECT_OPTION
                }
            };
            var obj = await _objService.Query().SelectAsync();
            if (obj.Any())
            {
                objectList.AddRange(obj);
            }
            
            ViewData[ViewStaticData.OBJECT_TYPE_ID] = new SelectList(objectList, ViewStaticData.OBJECT_TYPE_ID, ViewStaticData.NAME, objectType);
            if(txt != null)
            {
            ViewData[ViewStaticData.SEARCH_TEXT] = txt;
            }
            else
            {
                ViewData[ViewStaticData.SEARCH_TEXT] = string.Empty;

            }



            return View(listOfAudit);
        }

        [VmsAuthorizeAttribute(FeatureList.AUDIT)]
        [VmsAuthorizeAttribute(FeatureList.AUDIT_LOGS_CAN_VIEW_DETAILS)]
        public async Task<IActionResult> Details(int? Id)
        {
            var organizationId = _session.OrganizationId;
            var audits = await _service.Query()
                .Include(p => p.ObjectType).Include(p => p.User).Include(p=>p.AuditOperation)
                .SingleOrDefaultAsync(p => p.AuditLogId == Id, CancellationToken.None);
            

            return View(audits);
        }

        //[VmsAuthorizeAttribute(FeatureList.)]
        public async Task<IActionResult> Restore(int? Id)
        {
            var organizationId = _session.OrganizationId;
            var audits = await _service.Query().Where(w=>w.IsActive==true && w.OrganizationId ==_session.OrganizationId)
                .Include(p => p.ObjectType).Include(p => p.User).Include(p => p.AuditOperation)
                .SingleOrDefaultAsync(p => p.AuditLogId == Id, CancellationToken.None);


            return View(audits);
        }
        [HttpPost]
         
        public IActionResult Restore(AuditLog audit, int id)
        {


            try
            {
               
                vmRestore vmRestore = new vmRestore
                {
                    TableName = audit.ObjectType.Name + ControllerStaticData.AUDIT_OBJECT_TYPE_NAME,
                    PrimaryKey = audit.PrimaryKey.ToString(),
                    PrimaryKeyName = audit.ObjectType.Name + ControllerStaticData.AUDIT_PRIMARY_KEY_NAME,
                    AuditLogId = audit.AuditLogId.ToString()
                };
                var data = _service.RestoreAudit(vmRestore);
                TempData[ControllerStaticData.MESSAGE] = ControllerStaticData.SUCCESS_CLASSNAME;
            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return RedirectToAction(nameof(Index));

        }

    }  
}
