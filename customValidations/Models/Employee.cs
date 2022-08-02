using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace customValidations.Models
{
    public class Employee 
    {
        [Required]      
        public string Name { get; set; }
     
        [NidhiValidation/*(ErrorMessage = "Nidhi is required")*/]  //using custom validation as property
        public string Message { get; set; }
    }
}