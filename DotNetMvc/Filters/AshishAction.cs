using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMvc.Filters
{
    public class AshishAction : ActionFilterAttribute
    {

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
           // Debug.WriteLine("Hello from  action filter OnActionExwcuted");
            filterContext.Controller.ViewBag.Message = "Ashish action filter";
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Hello from  action filter OnActionExecuting");

        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.Message = "\n OnResultExecuted on CustomActionResult Filter  included in admin area";
        }
    }
}