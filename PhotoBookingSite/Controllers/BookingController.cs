using Microsoft.AspNetCore.Mvc;
using PhotoBookingSite.Models;

namespace PhotoBookingSite.Controllers
{
    public class BookingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Booking booking)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save booking to a database or send notification
                return RedirectToAction("Success");
            }

            return View(booking);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
