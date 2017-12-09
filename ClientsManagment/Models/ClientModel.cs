using System;

namespace ClientsManagment.Models
{
    public class ClientModel
    {
        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Guid Id { get; set; }
    }
}
