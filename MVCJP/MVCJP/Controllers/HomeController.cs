using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJP.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index(int id, string name)
        {
            ViewBag.Controller = RouteData.Values["controller"];
            ViewBag.Action = RouteData.Values["action"];
            ViewBag.CustomVariable = RouteData.Values["id"];
            ViewBag.CustomVariable1 = RouteData.Values["catchall1"];
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