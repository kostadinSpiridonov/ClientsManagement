using ClientManagment.DataAccess;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Utils;
using System;

namespace ClientsManagment.ViewModels
{
    public class LegalEntityClientDetailsViewModel : BaseNotifier
    {
        public LegalEntityClientModel Client { get; set; }

        private readonly DocumentRepository<LegalEntityClient> legalEntityClientRepository;

        private readonly DocumentRepository<IndividualClient> individualClientRepository;

        private readonly Guid clientId;

        public LegalEntityClientDetailsViewModel(Guid id)
        {
            this.legalEntityClientRepository = new DocumentRepository<LegalEntityClient>();
            this.individualClientRepository = new DocumentRepository<IndividualClient>();
            this.Client = new LegalEntityClientModel();
            this.clientId = id;
            this.LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            var data = this.legalEntityClientRepository
                .GetById(clientId)
                .MapToLegalEntityClientModel();

            var iClient = this.individualClientRepository.GetById(data.IndividualClientId);
            data.IndividualClientName = iClient.FullName;

            this.Client = data;
            this.NotifyPropertyChanged(nameof(this.Client));
        }
    }
}
