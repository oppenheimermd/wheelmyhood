using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace wheelmyhood.Controllers
{
    public class ConsoleController : Controller
    {
        public ConsoleController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
