using System.ComponentModel.DataAnnotations;

namespace ClientsManagment.Validation.Attributes
{
    public class NotNullAttribute : ValidationAttribute
    {
        public NotNullAttribute()
        {
            this.ErrorMessage = "The field is required.";
        }

        public override bool IsValid(object value) => value != null;
    }
}
