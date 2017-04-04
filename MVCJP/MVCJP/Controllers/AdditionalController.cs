using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJP.AdditionalController
{
    public class HomeController : Controller
    {
        // GET: Additional
        public ActionResult Index()
        {
            return View();
        }
    }
}