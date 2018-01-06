using ClientsManagment.Models;
using ClientsManagment.Validation;
using System.Collections.Generic;
using System.Linq;

namespace ClientsManagment.Mappings
{
    public static class IndividualClientMappings
    {
        public static IndividualClient MapToIndividualClient(this InputIndividualClientModel model)
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
                Phone = model.Phone?.Value,
                Id = model.Id
            };
        }

        public static IndividualClientModel MapToIndividualClientModel(this IndividualClient model)
        {
            if (model == null)
            {
                return null;
            }

            return new IndividualClientModel
            {
                Address = model.Address,
                Email = model.Email,
                FullName = model.FullName,
                Gender = ((Gender)model.Gender).ToString(),
                IdentificationNumber = model.IdentificationNumber,
                Phone = model.Phone,
                Id = model.Id
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

        public static InputIndividualClientModel MapToInputIndividualClientModel(this IndividualClient model)
        {
            if (model == null)
            {
                return null;
            }

            return new InputIndividualClientModel
            {
                Address = new ValidatableField<string>(model.Address),
                Email = new ValidatableField<string>(model.Email),
                FullName = new ValidatableField<string>(model.FullName),
                Gender = new ValidatableField<Gender>((Gender)model.Gender),
                Id = model.Id,
                IdentificationNumber = new ValidatableField<string>(model.IdentificationNumber),
                Phone = new ValidatableField<string>(model.Phone)
            };
        }
    }
}
