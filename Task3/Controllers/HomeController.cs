using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task3.Models;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page1()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult Menu1()
        {
            return View();
        }

        public IActionResult Menu2()
        {
            return View();
        }

        public IActionResult Menu3()
        {
            return View();
        }
    }
}