using ClientsManagment.Models;
using System.Collections.Generic;
using System.Linq;

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
        public static CommonClientModel MapToCommonClientModel(this IndividualClient model)
        {
            if (model == null)
            {
                return null;
            }

            return new CommonClientModel
            {
                Name = model.FullName,
                Id = model.Id,
                IsLegalEntityClient = false
            };
        }

        public static IEnumerable<CommonClientModel> MapToCommonClientModel(this IEnumerable<IndividualClient> model)
        {
            if (model == null)
            {
                return null;
            }

            return model.Select(x => x.MapToCommonClientModel());
        }
    }
}
