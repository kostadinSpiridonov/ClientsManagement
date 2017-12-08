using System.ComponentModel.DataAnnotations;

namespace ClientsManagment.Validation.Attributes
{
    public class NotNullOrEmptyAttribute : ValidationAttribute
    {
        public NotNullOrEmptyAttribute()
        {
            this.ErrorMessage = "The field is required.";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            var stringValue = value as string;
            return stringValue != null && stringValue.Trim().Length != 0;
        }
    }
}
