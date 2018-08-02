using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LD.Controllers
{
    public class AttendanceTrackerController : Controller
    {
        // GET: AttendanceTracker
        public ActionResult Index()
        {
            return View();
        }
    }
}