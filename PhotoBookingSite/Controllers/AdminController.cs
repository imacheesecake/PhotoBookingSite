using Microsoft.AspNetCore.Mvc;

namespace PhotoBookingSite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            // You can list bookings here
            return View();
        }
    }
}
