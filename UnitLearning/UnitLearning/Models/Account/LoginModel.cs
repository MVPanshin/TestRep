using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitLearning.Models.Account
{
    public class LoginModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public enum UserType { Student = 1, Manager = 2, Teacher = 3};

    public class RegisterModel
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string UserType { get; set; }
    }
}