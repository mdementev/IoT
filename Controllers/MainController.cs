using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoT.Controllers
{
    public class MainController : Controller
    {
        public string ImageSourceFolder = "~/Content/images";

        // GET: Main/mypage
        public ActionResult MyPage()
        {
            return View();
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}