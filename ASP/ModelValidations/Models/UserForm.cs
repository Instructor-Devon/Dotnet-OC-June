using System;
using System.ComponentModel.DataAnnotations;
using ModelValidations.Models.Validations;

namespace ModelValidations.Models
{
    public class UserForm
    {
        [Required] // Name is required
        [MinLength(2, ErrorMessage="Name must be 2 or more characters")] // Name must have a min length of 2
        [Display(Name="Cool Name")]
        public string Name {get;set;}
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [Age]
        public DateTime DOB {get;set;} // 13 years or older
        [MinLength(8)]
        public string Password {get;set;}
        [Compare("Password")]
        public string ComparePassword {get;set;}

    }
}