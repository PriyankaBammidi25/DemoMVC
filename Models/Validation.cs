using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Validation
    {
        string firstName;
        string lastName;
        double salary;
        string panCard;
        string password;
        string confirmpassword;
        string phone;
        string email;
        DateTime doj;
        [Required(ErrorMessage ="Firstname is required")]
        [StringLength(maximumLength:25,ErrorMessage ="max len is 20")]
       // [Display(Name="FIRSTNAME")]
        public string FirstName { get => firstName; set => firstName = value; }
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get => lastName; set => lastName = value; }
        [Required(ErrorMessage = "Salary is required")]
        [Range(10000,200000,ErrorMessage ="Salary must be between 10000 to 200000")]
        public double Salary { get => salary; set => salary = value; }
        [Required(ErrorMessage = "Pancard is required")]
        [RegularExpression("^[A-Z]{5}[0-9]{4}[A-Z]$",ErrorMessage ="Not a valid panno")]
        public string PanCard { get => panCard; set => panCard = value; }
        [Required(ErrorMessage = " Is required")]
        public string Password { get => password; set => password = value; }
        [Required(ErrorMessage = "Is required")]
        [Compare("Password",ErrorMessage ="Password mismatch")]
        [DataType(DataType.Password)]
        public string Confirmpassword { get => confirmpassword; set => confirmpassword = value; }
        [Required(ErrorMessage = "Is required")]
        [Phone(ErrorMessage ="Enter Phonenumber")]
        [MinLength(10,ErrorMessage ="10 digits only")]
        [MaxLength(10,ErrorMessage ="10 digits max")]
        public string Phone { get => phone; set => phone = value; }
        [Required(ErrorMessage = "Is required")]
        [EmailAddress(ErrorMessage ="Not a valid id")]
        public string Email { get => email; set => email = value; }
      //  [CustomAge(ErrorMessage = "age must be between 21 to 58")]
        [CustomDoj(ErrorMessage ="Invalid")]
        
        public DateTime Doj { get => doj; set => doj = value; }
    }
}