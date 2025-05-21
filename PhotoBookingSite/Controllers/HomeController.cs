using Microsoft.AspNetCore.Mvc;

namespace PhotoBookingSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Studio()
        {
            return View();
        }

        public IActionResult Packages()
        {
            return View();
        }
    }
}
