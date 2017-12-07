using ClientManagment.DataAccess;
using ClientsManagment.Models;

namespace ClientsManagment.ViewModels
{
    public class AddIndividualClientViewModel
    {
        public IndividualClient ViewData { get; set; }

        private readonly DocumentRepository<IndividualClient> repository;

        public AddIndividualClientViewModel()
        {
            this.ViewData = new IndividualClient();
            this.repository = new DocumentRepository<IndividualClient>();
        }

        public void Add()
        {
            this.repository.Add(this.ViewData);
        }
    }
}
