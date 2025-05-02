using basicpractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace basicpractice.Controllers
{
    public class InterestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Interest obj)
        {
            ViewBag.result = "interst is  " + (obj.P + obj.R + obj.T)/100;
            return View();
        }

    }
}
