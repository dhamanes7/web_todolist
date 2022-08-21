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
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<Models.ToDoWeb> toDo = new List<Models.ToDoWeb>();

            return View("Index", toDo);
        }
    }
}
