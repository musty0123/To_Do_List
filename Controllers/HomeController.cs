using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using To_Do_List.Models;
using To_Do_List.Data;

namespace To_Do_List.Controllers
{
    public class HomeController : Controller
    {
        // Need to understand loggers. One you finish the initial HTTP GET AND POST requests, look into it.
      /*  private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger) => _logger = logger;*/
        private ApplicationDbContext _context { get; set; }
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var todotask = _context.tasks.OrderBy(m => m.DueDate).ToList();

            return View(todotask);
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