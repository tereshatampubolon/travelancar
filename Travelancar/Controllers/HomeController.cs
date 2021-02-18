using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travelancar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Test()
        {
            ViewBag.Message = "Tester.";

            return View();
        }
    }
}