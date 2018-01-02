using ClientManagment.DataAccess;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Utils;
using ClientsManagment.Validation;
using System;

namespace ClientsManagment.ViewModels
{
    public class EditLegalEntityClientViewModel : BaseNotifier
    {
        public InputLegalEntityClientModel Client { get; set; }

        private readonly DocumentRepository<LegalEntityClient> repository;

        private readonly Guid clientId;

        public EditLegalEntityClientViewModel(Guid id)
        {
            this.repository = new DocumentRepository<LegalEntityClient>();
            this.Client = new InputLegalEntityClientModel();
            this.clientId = id;
            this.LoadDataAsync();
        }

        public void Update()
        {
            bool valid = Validator.ValidateModel(this.Client);
            this.Client.NotifyPropertiesChanged();

            if (valid)
            {
                var mappedModel = this.Client.MapToLegalEntityClient();
                this.repository.Update(mappedModel);
            }
        }

        public void ValidateProperty(string boundProperyName)
        {
            Validator.ValidateProperty(this.Client, boundProperyName);
            this.Client.NotifyPropertyChanged(boundProperyName);
        }

        private async void LoadDataAsync()
        {
            var data = this.repository
                .GetById(clientId)
                .MapToInputLegalEntityClientModel();
            
            if (data == null)
            {
                return;
            }

            this.Client = data;
            this.NotifyPropertyChanged(nameof(this.Client));
        }
    }
}
