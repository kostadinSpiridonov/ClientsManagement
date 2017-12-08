using ClientsManagment.Notify;
using ClientsManagment.Validation;
using ClientsManagment.Validation.Attributes;

namespace ClientsManagment.Models
{
    public class IndividualClientModel : BaseNotifier
    {
        [NotNullOrEmpty]
        public ValidatableField<string> Address { get; set; } = new ValidatableField<string>();

        [NotNullOrEmpty]
        [Phone]
        public ValidatableField<string> Phone { get; set; } = new ValidatableField<string>();

        [NotNullOrEmpty]
        [Email]
        public ValidatableField<string> Email { get; set; } = new ValidatableField<string>();

        [NotNullOrEmpty]
        public ValidatableField<string> FullName { get; set; } = new ValidatableField<string>();

        [NotNull]
        public ValidatableField<Gender> Gender { get; set; } = new ValidatableField<Gender>();

        [NotNullOrEmpty]
        public ValidatableField<string> IdentificationNumber { get; set; } = new ValidatableField<string>();
    }
}
