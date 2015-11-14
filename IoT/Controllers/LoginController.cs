using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoT.Controllers
{
    using System.Web.Mvc;
    using System.Web.Security;

    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Login Page";

            return View();
        }
    }
}
