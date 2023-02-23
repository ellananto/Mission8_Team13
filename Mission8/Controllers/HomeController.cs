using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TaskContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, TaskContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }
        //Creating all the necessary views for the project.
        public IActionResult Index()
        {
            return View();
        }
          
        [HttpGet]
        public IActionResult Quadrant()
        {
            var tasks = blahContext.responses.ToList();
            return View(tasks);
        }
        [HttpGet]
        public IActionResult TaskForm ()
        {
            ViewBag.Category = blahContext.Category.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult TaskForm (TaskFormResponse ar)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Category = blahContext.Category.ToList();
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit (int taskid)
        {
            ViewBag.Category = blahContext.Category.ToList();
            var task = blahContext.responses.Single(x => x.TaskID == taskid);
            return View("TaskForm", task);
        }
        [HttpPost]
        public IActionResult Edit (TaskFormResponse ar)
        {
            blahContext.Update(ar);
            blahContext.SaveChanges();
            return RedirectToAction("Quadrant");
        }
        [HttpGet]
        public IActionResult Delete (int taskid)
        {
            var task = blahContext.responses.Single(x => x.TaskID == taskid);
            return View(task);
        }
        [HttpPost]
        public IActionResult Delete (TaskFormResponse ar)
        {
            blahContext.responses.Remove(ar);
            blahContext.SaveChanges();
            return RedirectToAction("Quadrant");
        }
        [HttpGet]
        public IActionResult CompletedTasks()
        {
            var completedTasks = blahContext.responses.Where(x => x.Completed == true).ToList();
            return View(completedTasks);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
