using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;



namespace basicpractice.Controllers
{
    public class HelloController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
