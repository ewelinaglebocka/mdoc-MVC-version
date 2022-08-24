using mdoc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace mdoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Instruction()
        {
            return View();
        }

        public IActionResult ExecutiveDocumentation()
        {
            return View();
        }

        public IActionResult EditDocument()
        {
            return View();
        }
        public IActionResult EditUsers()
        {
            return View();
        }
        public IActionResult Tests()
        {
            return View();
        }
        public IActionResult TechnologicalChanges()
        {
            return View();
        }
        public IActionResult Valuations()
        {
            return View();
        }
        public IActionResult IssuanceOfDocumentation()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }
        public IActionResult Reports()
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