using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Username Is Required.")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password is Required.")]
        [DataType(DataType.Password)]
        [StringLength(150,ErrorMessage ="Must be between 5 and 150 characters",MinimumLength = 5)]
        public string Password { get; set; }
    }
}
