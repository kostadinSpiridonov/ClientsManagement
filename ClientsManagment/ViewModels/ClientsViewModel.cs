using ClientManagment.DataAccess;
using ClientManagment.DataAccess.Exceptions;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Utils;
using ClientsManagment.Views;
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

        public void NavigateToDetails(Guid id)
        {
            if (this.IsLegalEntityClient(id))
            {
                NavigationService.OpenNewControl(new LegalEntityClientDetailsView(id));
            }
            else
            {
                NavigationService.OpenNewControl(new IndividualClientDetailsView(id));
            }
        }

        public void NavigateToEdit(Guid id)
        {
            if (this.IsLegalEntityClient(id))
            {
                NavigationService.OpenNewControl(new EditLegalEntityClient(id));
            }
            else
            {
                NavigationService.OpenNewControl(new EditIndividualClientView(id));
            }
        }

        private bool IsLegalEntityClient(Guid id)
        {
            var isLegalEntityClient = this.Clients.FirstOrDefault(x => x.Id == id)?.IsLegalEntityClient;
            return isLegalEntityClient ?? isLegalEntityClient.Value;
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
            bool deleted = false;

            var deleteItem = this.Clients.FirstOrDefault(x => x.Id == id);
            if (deleteItem.IsLegalEntityClient)
            {
                try
                {
                    this.legalEntityClientRepository.Delete(id);
                    deleted = true;
                }
                catch (EntityNotFoundException ex)
                {
                    NotificationService.PopupSomethingWentWrong("This client couldn't be found!");
                }
            }
            else
            {
                var legalEntityClients = this.legalEntityClientRepository.GetAll();
                if (!legalEntityClients.Any(x => x.IndividualId == id))
                {
                    try
                    {
                        this.individualClientRepository.Delete(id);
                        deleted = true;
                    }
                    catch (EntityNotFoundException ex)
                    {
                        NotificationService.PopupSomethingWentWrong("This client couldn't be found!");

                    }
                }
                else
                {
                    NotificationService.PopupSomethingWentWrong("You can't delete this client, because is used by another one!");
                }
            }

            if (deleted)
            {
                this.Clients.Remove(deleteItem);
                this.NotifyPropertyChanged(nameof(Clients));
            }
        }
    }
}
