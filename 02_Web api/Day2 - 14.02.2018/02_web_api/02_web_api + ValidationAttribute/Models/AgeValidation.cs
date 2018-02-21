using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _02_web_api.Models
{
    public class AgeValidationAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (int)(value)>18 && (int)(value)<100;
        }
    }
}