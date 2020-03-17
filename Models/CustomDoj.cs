using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class CustomDoj:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime D = Convert.ToDateTime(value);
            DateTime TD = DateTime.Today;
            int age = (int)TD.Subtract(D).TotalDays / 365;
            if (D>TD)
            {
                return new ValidationResult("Date cannot be greater tha today's date");
            }
             else if(age<21||age>58)
            {
                return new ValidationResult("Age must be  between 21-58");
            }
            else
                return ValidationResult.Success;
        }
    }
    //public class CustomDoj : ValidationAttribute
    //{
    //    public override bool IsValid(object value)
    //    {
    //        DateTime D = Convert.ToDateTime(value);
    //        return D <= DateTime.Now;

    //    }
    //}
    //public class CustomAge : ValidationAttribute
    //{
    //    public override bool IsValid(object value)
    //    {
    //        DateTime D = Convert.ToDateTime(value);
    //        DateTime TD = DateTime.Today;
    //        int age = (int)TD.Subtract(D).TotalDays / 365;
    //        if (age >= 21 && age <= 58)
    //        {
    //            return true;
    //        }
    //        else
    //            return false;
    //    }
    //}
}