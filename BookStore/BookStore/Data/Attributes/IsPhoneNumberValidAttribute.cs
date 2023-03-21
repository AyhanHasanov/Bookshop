using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookStore.Data.Attributes
{
    
    public class IsPhoneNumberValidAttribute : ValidationAttribute
    {
        private readonly string phoneNumber;
        private readonly string pattern = @"\+359[0-9]{9}";
        

        public IsPhoneNumberValidAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
                if (Regex.IsMatch(value.ToString(), pattern))
                    return ValidationResult.Success;

            var errorMsg = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMsg);
        }
    }
}
