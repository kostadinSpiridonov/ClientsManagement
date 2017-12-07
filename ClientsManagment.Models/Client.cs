using System;

namespace ClientsManagment.Models
{
    public class Client : IEntity
    {
        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Guid Id { get; set; }
    }
}
