using ClientsManagment.Models;

namespace ClientsManagment.Mappings
{
    public static class IndividualClientMappings
    {
        public static IndividualClient MapToIndividualClient(this IndividualClientModel model)
        {
            if (model == null)
            {
                return null;
            }

            return new IndividualClient
            {
                Address = model.Address?.Value,
                Email = model.Email?.Value,
                FullName = model.FullName?.Value,
                Gender = (int)model.Gender?.Value,
                IdentificationNumber = model.IdentificationNumber?.Value,
                Phone = model.Phone?.Value
            };
        }
    }
}
