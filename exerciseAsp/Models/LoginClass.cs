using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace exerciseAsp.Models
{
    public class LoginClass
    {
        [Required(ErrorMessage ="Please enter the your e-mail!")]
        [Display(Name ="E-mail:")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Please enter the password!")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}