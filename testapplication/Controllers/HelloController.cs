using Microsoft.AspNetCore.Mvc;

namespace testapplication.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
