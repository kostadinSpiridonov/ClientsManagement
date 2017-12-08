using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ClientsManagment.Validation.Attributes
{
    public class EmailAttribute : ValidationAttribute
    {
        private const string EmailRegexPattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

        public EmailAttribute()
        {
            this.ErrorMessage = "The email address is not correct";
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

            var regex = new Regex(EmailRegexPattern);

            return regex.IsMatch(valueAsString);
        }
    }
}
