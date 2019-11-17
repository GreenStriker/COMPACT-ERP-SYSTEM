//using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vms.utility;
using vms.entity.viewModels;
using vms.entity.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace vms.Utility
{
    
       
    public class VmsAuthorizeAttribute : ActionFilterAttribute
    {

      private  String _right;
     


        public VmsAuthorizeAttribute(String _right)
        {
            this._right = _right;
            


        }
        

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = filterContext.HttpContext.Session.GetComplexData<entity.viewModels.vmSession>("session");
            if (!UserRole.Check(_right, session.Rights))
            {

                filterContext.Result = new RedirectResult("~/");
                return;
            }





            base.OnActionExecuting(filterContext);
        }
        

    }
    
}