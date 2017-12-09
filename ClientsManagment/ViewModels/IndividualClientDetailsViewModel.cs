using ClientManagment.DataAccess;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Utils;
using System;

namespace ClientsManagment.ViewModels
{
    public class IndividualClientDetailsViewModel : BaseNotifier
    {
        public IndividualClientModel Client { get; set; }

        private readonly DocumentRepository<IndividualClient> repository;

        private readonly Guid clientId;

        public IndividualClientDetailsViewModel(Guid id)
        {
            this.repository = new DocumentRepository<IndividualClient>();
            this.Client = new IndividualClientModel();
            this.clientId = id;
            this.LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            var data = this.repository
                .GetById(clientId)
                .MapToIndividualClientModel();

            this.Client = data;
            this.NotifyPropertyChanged(nameof(this.Client));
        }
    }
}
