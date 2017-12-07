using System;

namespace ClientsManagment.Models
{
    public class LegalEntityClient : Client
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Bulstat { get; set; }

        public int TaxRegisryNumber { get; set; }

        public string WebSiteUrl { get; set; }

        public Guid IndividualId { get; set; }
    }
}
