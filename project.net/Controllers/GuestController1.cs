using Microsoft.AspNetCore.Mvc;

namespace project.net.Controllers
{
    public class GuestController1 : Controller
    {
        public IActionResult Home()
        {
        
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Career()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult Contactus()
        {
            return View();
        }
    }
}
