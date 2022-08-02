using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace customValidations
{
    public class NidhiValidation : ValidationAttribute  //implements validationattributes class
    {
        //need to override isvalid (predefined function )
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //logic for the validation
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("Nidhi"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field needs to contains Nidhi";
            return new ValidationResult(ErrorMessage);
        }
    }
}