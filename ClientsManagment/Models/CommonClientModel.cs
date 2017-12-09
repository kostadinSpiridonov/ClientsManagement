using System;

namespace ClientsManagment.Models
{
    public class CommonClientModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsLegalEntityClient { get; set; }
    }
}
