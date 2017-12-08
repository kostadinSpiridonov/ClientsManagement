using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ClientsManagment.Validation.Attributes
{
    public class PhoneAttribute : ValidationAttribute
    {
        private const string PhoneRegexPattern = @"^\d{3}\d{3}\d{4}$";

        public PhoneAttribute()
        {
            this.ErrorMessage = "The phone number is not correct";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            string valueAsString = value as string;
            if (valueAsString == null)
            {
                return false;
            }

            var regex = new Regex(PhoneRegexPattern);

            return regex.IsMatch(valueAsString);
        }
    }
}
