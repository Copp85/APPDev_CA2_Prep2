using CA2_prep2.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;//For IClientModelValidator
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //For ValidationAttribute
using System.Linq;
using System.Threading.Tasks;

namespace CA2_prep2.Data
{
    public class AgeAttribute : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object DOB, ValidationContext validationContext)
        {
            Browncoat browncoat = (Browncoat)validationContext.ObjectInstance;
            if (DateTime.Now.Year - browncoat.DOB.Year < 18)
            {
                return new ValidationResult("You must be at least 18 to join");
            }
            return ValidationResult.Success;
        }

        public void AddValidation (ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-Val-age", "You must be at least 18 to join");
        }
       
        
    }
}
