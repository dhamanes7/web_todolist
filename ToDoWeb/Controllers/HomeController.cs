using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoWeb;

namespace ToDoWeb.Controllers
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

        public IActionResult submit()
        {

            return View();
        }

        //public IActionResult Index(ToDoWeb toDoWeb)
        //{
        //    toDoWeb.id = 0;
        //    String name = toDoWeb.name;
        //    return View();
        //}
    }
}