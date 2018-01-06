using ClientManagment.DataAccess;
using ClientManagment.DataAccess.Exceptions;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Utils;
using ClientsManagment.Validation;
using System;

namespace ClientsManagment.ViewModels
{
    public class EditIndividualClientViewModel : BaseNotifier
    {
        public InputIndividualClientModel Client { get; set; }

        private readonly DocumentRepository<IndividualClient> repository;

        private readonly Guid clientId;

        public EditIndividualClientViewModel(Guid id)
        {
            this.repository = new DocumentRepository<IndividualClient>();
            this.Client = new InputIndividualClientModel();
            this.clientId = id;
            this.LoadDataAsync();
        }

        public void Update()
        {
            bool valid = Validator.ValidateModel(this.Client);
            this.Client.NotifyPropertiesChanged();

            if (valid)
            {
                var mappedModel = this.Client.MapToIndividualClient();
                try
                {
                    this.repository.Update(mappedModel);
                }
                catch(EntityNotFoundException ex)
                {
                    NotificationService.PopupSomethingWentWrong("This client couldn't be found!");
                }
                catch(ArgumentNullException ex)
                {
                    NotificationService.PopupSomethingWentWrong("Please try again later!");
                }
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
                .MapToInputIndividualClientModel();

            if (data == null)
            {
                return;
            }

            this.Client = data;
            this.NotifyPropertyChanged(nameof(this.Client));
        }
    }
}
