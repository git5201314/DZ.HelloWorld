using System.Web.Mvc;

namespace DZ.HelloWorld.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}