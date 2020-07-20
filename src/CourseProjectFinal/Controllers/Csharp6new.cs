using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectFinal.Models;
using static CourseProjectFinal.Models.Static6;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProjectFinal.Controllers
{
    public class Csharp6new : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // Static6 class and method myfirststatic();
            myfirststatic();
            return View();
        }
    }
}
