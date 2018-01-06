using System;
using System.ComponentModel.DataAnnotations;

namespace ClientsManagment.Validation.Attributes
{
    public class NotEmptyGuid : ValidationAttribute
    {
        public NotEmptyGuid()
        {
            this.ErrorMessage = "The field is required.";
        }

        public override bool IsValid(object value)
        {
            if (Guid.TryParse(value.ToString(), out Guid parsedValue))
            {
                return parsedValue != Guid.Empty;
            }

            return false;
        }
    }
}
