using ClientManagment.DataAccess;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Notify;
using System;
using System.ComponentModel;
using System.Linq;

namespace ClientsManagment.ViewModels
{
    public class ClientsViewModel : BaseNotifier
    {
        public BindingList<CommonClientModel> Clients { get; set; }

        private readonly IDocumentRepository<IndividualClient> individualClientRepository;

        private readonly IDocumentRepository<LegalEntityClient> legalEntityClientRepository;

        public ClientsViewModel()
        {
            this.individualClientRepository = new DocumentRepository<IndividualClient>();
            this.legalEntityClientRepository = new DocumentRepository<LegalEntityClient>();
            this.Clients = new BindingList<CommonClientModel>();
            this.LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            var individualClients = this.individualClientRepository
                .GetAll()
                .MapToCommonClientModel();

            var legalEntityClients = this.legalEntityClientRepository
                .GetAll()
                .MapToCommonClientModel();

            var allClients = individualClients
                .Concat(legalEntityClients)
                .ToList();

            this.Clients = new BindingList<CommonClientModel>(allClients);
            this.NotifyPropertyChanged(nameof(this.Clients));
        }

        public void Delete(Guid id)
        {
            var deleteItem = this.Clients.FirstOrDefault(x => x.Id == id);
            this.Clients.Remove(deleteItem);
            this.NotifyPropertyChanged(nameof(Clients));

            if (deleteItem.IsLegalEntityClient)
            {
                this.legalEntityClientRepository.Delete(id);
            }
            else
            {
                this.individualClientRepository.Delete(id);
            }
        }
    }
}
