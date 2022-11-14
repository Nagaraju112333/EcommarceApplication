using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;

namespace ArchentsFirstProject.Controllers
{
    public class WeekendBootController : Controller
    {
        // GET: WeekendBoot
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult WeekendBootMainPage()
        {
            return View();
        }
        public ActionResult Weekenboot()
        {
            return View();
        }
    }
}