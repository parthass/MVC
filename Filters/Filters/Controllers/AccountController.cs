using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Filters.Models;
using System.Web.Security;

namespace Filters.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password, string
        returnUrl)
        {
            bool result = FormsAuthentication.Authenticate(username,password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnUrl ?? Url.Action("Index",
                "Admin"));
            }
            else
            {
                ModelState.AddModelError("", "Incorrect username or  password");
          return View();
            }
        }

    }
}