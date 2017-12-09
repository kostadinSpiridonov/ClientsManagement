using System;

namespace ClientsManagment.Models
{
    public class LegalEntityClientModel : ClientModel
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Bulstat { get; set; }

        public int TaxRegisryNumber { get; set; }

        public string WebSiteUrl { get; set; }

        public Guid IndividualClientId { get; set; }

        public string IndividualClientName { get; set; }
    }
}
