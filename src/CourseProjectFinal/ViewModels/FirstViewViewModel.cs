using CourseProjectFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.ViewModels
{
    public class FirstViewViewModel
    {
        public IEnumerable<MyData> MyType { get; set; }

        public int ID { get; set; }
    }
}
