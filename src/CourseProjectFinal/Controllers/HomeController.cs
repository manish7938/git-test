using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseProjectFinal.Models;
using CourseProjectFinal.ViewModels;
using CourseProjectFinal.Services;
using CourseProjectFinal.Entities;

namespace CourseProjectFinal.Controllers
{
    
    public class HomeController : Controller
    {
        private IMyInjectedService myService;
        private ApplicationDbContext _myContext;
     
        public HomeController(IMyInjectedService myService, ApplicationDbContext context)
        {
            this.myService = myService;
            this._myContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var item = await GetGuid();
            ViewBag.myobject = myService;
            SeedData.Seed(_myContext);
            return View(item);
        }


        public IActionResult FirstView()
        {

            //var myModelFirst = new MyData { MyId = 3, MyValue = "My View" };
            var myModelSecond = new List<MyData>
            {
               new MyData { MyId = 1, MyValue ="First" },
               new MyData { MyId = 3, MyValue = "Second" }
            };

            // View Model Data
            var viewModel = new FirstViewViewModel();
            viewModel.MyType = myModelSecond;

            return View(viewModel);
        }
        // Attribute Based Routing[Route("[Action]")]
        public ContentResult IdRoute()
        {
            return Content("Attribute Routing");
        }

        // Return Types

        public ObjectResult MyObject()
        {
            var myModel = new MyData { MyId = 1, MyValue = "My First Value" };
            return new ObjectResult(myModel);

        }

        private async Task<IMyInjectedService> GetGuid()
        {

            return await Task.FromResult(myService);

        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
