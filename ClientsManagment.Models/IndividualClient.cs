using System;

namespace ClientsManagment.Models
{
    public class IndividualClient : Client
    {
        public string FullName { get; set; }

        public int Gender { get; set; }

        public string IdentificationNumber { get; set; }
    }
}
