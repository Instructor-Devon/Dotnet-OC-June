using System;
using System.ComponentModel.DataAnnotations;

namespace ModelValidations.Models.Validations
{
    public class AgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dt = (DateTime)value;

            
            if((DateTime.Now - dt).Days / 365.25 <= 13)
            {
               return new ValidationResult("Must be 13 years or older");   
            }
            return ValidationResult.Success;
        }
    }
}