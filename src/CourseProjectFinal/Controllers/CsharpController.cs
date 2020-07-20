using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectFinal.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProjectFinal.Controllers
{
    public class CsharpController : Controller
    {
        // First Object Intiation
        Firstclass myobject = new Firstclass();
        // Second Object Intiation
        Firstclass myobject2;
        // Class
        MyInterface myobject3 = new MyInterface();

       public CsharpController(Firstclass aobject)
        {

            aobject = myobject;
            myobject2 = new Firstclass(12, "First", 12.25);
        
        }
        public IActionResult Index()
        {
            // Local Variable
            var value = "";
            // Properties of First Object
            myobject.MyDouble = 12.95;
            myobject.MyString = "First String";
            myobject.MyInt = 12;

            // Methods of Second Object
            myobject2.FirstInt();
            value = myobject2.FirstStringMethod("Hello First");
            myobject2.MyVoid();

            // My Text
            myobject3.GetFirstMethod();

            // 25
            myobject3.PostSecondMethod();

            return View();
        }
    }
}
