using Microsoft.AspNetCore.Mvc;
using Site.Models;
using System.Diagnostics;

namespace Site.Controllers
{
    public class HomeSiteController : Controller
    {
        private readonly ILogger<HomeSiteController> _logger;

        public HomeSiteController(ILogger<HomeSiteController> logger)
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