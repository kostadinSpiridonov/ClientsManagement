using ClientsManagment.Models;

namespace ClientsManagment.Mappings
{
    public static class LegalEntityClientMappings
    {
        public static LegalEntityClient MapToLegalEntityClient(this LegalEntityClientModel model)
        {
            if (model == null)
            {
                return null;
            }

            return new LegalEntityClient
            {
                Address = model.Address?.Value,
                Email = model.Email?.Value,
                Phone = model.Phone?.Value,
                Bulstat = model.Bulstat?.Value,
                IndividualId = model.IndividualId.Value,
                Name = model.Name?.Value,
                TaxRegisryNumber = model.TaxRegistryNumber.Value,
                Type = model.Type?.Value,
                WebSiteUrl = model.WebSiteUrl?.Value
            };
        }
    }
}
