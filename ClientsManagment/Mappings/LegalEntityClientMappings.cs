﻿using ClientsManagment.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClientsManagment.Mappings
{
    public static class LegalEntityClientMappings
    {
        public static LegalEntityClient MapToLegalEntityClient(this AddLegalEntityClientModel model)
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

        public static CommonClientModel MapToCommonClientModel(this LegalEntityClient model)
        {
            if (model == null)
            {
                return null;
            }

            return new CommonClientModel
            {
                Name = model.Name,
                Id = model.Id,
                IsLegalEntityClient = true
            };
        }

        public static IEnumerable<CommonClientModel> MapToCommonClientModel(this IEnumerable<LegalEntityClient> model)
        {
            if (model == null)
            {
                return null;
            }

            return model.Select(x => x.MapToCommonClientModel());
        }

        public static LegalEntityClientModel MapToLegalEntityClientModel(this LegalEntityClient model)
        {
            if (model == null)
            {
                return null;
            }

            return new LegalEntityClientModel
            {
                Address = model.Address,
                Email = model.Email,
                Phone = model.Phone,
                Bulstat = model.Bulstat,
                IndividualClientId = model.IndividualId,
                Name = model.Name,
                TaxRegisryNumber = model.TaxRegisryNumber,
                Type = model.Type,
                WebSiteUrl = model.WebSiteUrl,
                Id = model.Id
            };
        }
    }
}
