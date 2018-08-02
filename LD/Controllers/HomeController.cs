using System.Web.Mvc;

namespace LD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learning & Development tool...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact L&D department";

            return View();
        }
    }
}