using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _02_web_api.Models
{
    public class Student
    {
        [Required]
        public int Grade { get; set; }

        [Required, AgeValidation]
        public int Age { get; set; }

        [Required, MinLength(3)]
        public string Name { get; set; }
    }
}