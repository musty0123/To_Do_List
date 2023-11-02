using Microsoft.AspNetCore.Mvc;
using System.Data;
using To_Do_List.Data;
using To_Do_List.Data.Repository;
using To_Do_List.Models.Entity;

namespace To_Do_List.Controllers
{
    public class ToDoTaskController : Controller
    {
        private ITaskRepository _taskRepository;
        public ToDoTaskController(ITaskRepository taskRepository) => _taskRepository = taskRepository;
        

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
            var task_id = _taskRepository.GetTaskByID(id);
            return View("Edit", task_id);
        }
        [HttpPost]
        public IActionResult Edit(TaskWrapper item)
        {
            if (ModelState.IsValid)
            {
                if (item.Id == 0)
                    _taskRepository.AddTask(item);
                else
                    _taskRepository.UpdateTask(item);
                _taskRepository.Save();
                return RedirectToAction("Index", "Home");
            }
            else { return View(item); }
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            
            _taskRepository.DeleteTask(id);
            _taskRepository.Save();
            return RedirectToAction("Index", "Home");
        }


    }
}
