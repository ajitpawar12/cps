using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPS.Infrastructure.Helpers
{
    public class ValidationHelper
    {
        public static List<KeyValuePair<string,string>> GetErrors(ValidationResult result)
        {
            var errors = new List<KeyValuePair<string, string>>();
            foreach (var e in result.Errors)
            {
                errors.Add(new KeyValuePair<string, string>(e.PropertyName, e.ErrorMessage));
            }

            return errors;
        }
    }
}