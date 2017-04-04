using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FilterDemo.Infrastructure;

namespace FilterDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [CustomAuth(true)]
       
        public ActionResult Index()
        {
            return View();
        }


        
        [HttpPost]
       public ActionResult Index(string username, string password, string returnUrl)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                if (!Request.IsAuthenticated)
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Home"));
                }
                else
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Login"));
                }
            }
            else
            {
                ModelState.AddModelError("", "Incorrect username or password");
                return View();
            }
        }
    }
}