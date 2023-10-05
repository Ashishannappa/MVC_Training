using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMvc.Filters
{
    public class AshishExecption : FilterAttribute, IExceptionFilter
    {
       public void OnException(ExceptionContext filterContext)
        {
            filterContext.Result = new ViewResult()
            {
                ViewName = "View",
            };
            filterContext.ExceptionHandled = true;
        }
    }
}