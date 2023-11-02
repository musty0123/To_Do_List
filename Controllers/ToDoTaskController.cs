using Microsoft.AspNetCore.Mvc;
using System.Data;
using To_Do_List.Data;
using To_Do_List.Models.Entity;

namespace To_Do_List.Controllers
{
    public class ToDoTaskController : Controller
    {
        private ApplicationDbContext _context { get; set; }
        public ToDoTaskController(ApplicationDbContext context) => _context = context;


        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new TaskWrapper());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var task_id = _context.tasks.Find(id);
            return View("Edit", task_id);
        }
        [HttpPost]
        public IActionResult Edit(TaskWrapper item)
        {
            if (ModelState.IsValid)
            {
                if (item.Id == 0)
                    _context.tasks.Add(item);
                else
                    _context.tasks.Update(item);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else { return View(item); }
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            
            var task = _context.tasks.Find(id);
            _context.tasks.Remove(task);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


    }
}
