using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garelic.MVC.Controllers
{
    [GarelicTrackingAttribute]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            System.Threading.Thread.Sleep(5000); // wait 5 sec.

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
