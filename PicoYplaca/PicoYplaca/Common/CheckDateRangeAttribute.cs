using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PicoYplaca.Common
{
    public class CheckDateRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dt = (DateTime)value;
            if (dt >= DateTime.Today)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "Fecha debe ser mayor o igual a la fecha actual");
        }

    }
}