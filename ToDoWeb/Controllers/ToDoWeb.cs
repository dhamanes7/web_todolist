using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoWeb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoWeb.Controllers
{
    
    public class ToDoWeb : Controller
    {
        public int i = 0;
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<Models.ToDoWeb> toDo = new List<Models.ToDoWeb>();

            return View("Index", toDo);
        }
    }

    [HttpPost]
    public IActionResult Index(Models.ToDoWeb ToDoList, String submit, string completed)
    {
        if (submit == "submit")
        {
            ToDoList.id = "1";
            ToDoList.title = "name";
            ToDoList.completedDate = "NA";
            ToDoList.isCompleted = "NA";
        }
        else if (completed == "completed")
        {
        }
        return View();
    }
}
