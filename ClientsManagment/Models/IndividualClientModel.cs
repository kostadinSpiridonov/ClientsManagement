using ClientsManagment.ViewModels;

namespace ClientsManagment.Models
{
    public class IndividualClientModel : ClientModel
    {
        public string FullName { get; set; }

        public string Gender { get; set; }

        public string IdentificationNumber { get; set; }
    }
}
