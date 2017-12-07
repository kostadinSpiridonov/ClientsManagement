using ClientManagment.DataAccess;
using ClientsManagment.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace ClientsManagment.ViewModels
{
    public class ClientsViewModel : BaseViewModel
    {
        public BindingList<IndividualClient> IndividualClients { get; set; }

        private readonly IDocumentRepository<IndividualClient> repository;

        public ClientsViewModel()
        {
            this.repository = new DocumentRepository<IndividualClient>();
            this.IndividualClients = new BindingList<IndividualClient>();
            this.LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            this.IndividualClients = new BindingList<IndividualClient>(repository.GetAll());
            this.NotifyPropertyChanged(nameof(IndividualClients));
        }

        public void Delete(Guid id)
        {
            var deleteItem = this.IndividualClients.FirstOrDefault(x => x.Id == id);
            this.IndividualClients.Remove(deleteItem);
            this.NotifyPropertyChanged(nameof(IndividualClients));

            this.repository.Delete(id);
        }
    }
}
