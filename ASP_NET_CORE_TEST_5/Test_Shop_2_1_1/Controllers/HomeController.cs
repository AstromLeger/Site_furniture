using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test_Shop_2_1.Controllers;
using Test_Shop_2_1.Interfaces;
using Test_Shop_2_1.mocks;
using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
