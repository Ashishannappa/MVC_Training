using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetMvc.Filters;
namespace DotNetMvc.Controllers
{
    public class HomeController : Controller
    {
        [AshishAuithentication]
        [AshishAction]
        [AshishExecption]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}