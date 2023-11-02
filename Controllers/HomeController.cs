using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using To_Do_List.Models;
using To_Do_List.Data;
using To_Do_List.Data.Repository;

namespace To_Do_List.Controllers
{
    public class HomeController : Controller
    {
        // Need to understand loggers. One you finish the initial HTTP GET AND POST requests, look into it.
        /*  private readonly ILogger<HomeController> _logger;
          public HomeController(ILogger<HomeController> logger) => _logger = logger;*/
        
        private ITaskRepository _taskRepository;
        
        public HomeController(ITaskRepository taskRepository) => _taskRepository = taskRepository;
        [HttpGet]
        public IActionResult Index()
        {

            var todotask = _taskRepository.GetTasks(); 

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