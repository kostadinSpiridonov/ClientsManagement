using ClientsManagment.Utils;
using ClientsManagment.Validation;
using ClientsManagment.Validation.Attributes;
using System;

namespace ClientsManagment.Models
{
    public class AddLegalEntityClientModel : BaseNotifier
    {
        [NotNullOrEmpty]
        public ValidatableField<string> Name { get; set; } = new ValidatableField<string>();

        [NotNullOrEmpty]
        public ValidatableField<string> Type { get; set; } = new ValidatableField<string>();

        [NotNullOrEmpty]
        public ValidatableField<string> Bulstat { get; set; } = new ValidatableField<string>();

        public ValidatableField<int> TaxRegistryNumber { get; set; } = new ValidatableField<int>();

        [NotNullOrEmpty]
        public ValidatableField<string> WebSiteUrl { get; set; } = new ValidatableField<string>();

        [NotNull]
        public ValidatableField<Guid> IndividualId { get; set; } = new ValidatableField<Guid>();

        [NotNullOrEmpty]
        public ValidatableField<string> Address { get; set; } = new ValidatableField<string>();

        [NotNullOrEmpty]
        [Phone]
        public ValidatableField<string> Phone { get; set; } = new ValidatableField<string>();

        [NotNullOrEmpty]
        [Email]
        public ValidatableField<string> Email { get; set; } = new ValidatableField<string>();
    }
}
