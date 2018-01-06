using ClientManagment.DataAccess;
using ClientManagment.DataAccess.Exceptions;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Utils;
using ClientsManagment.Validation;
using System;
using System.ComponentModel;
using System.Linq;

namespace ClientsManagment.ViewModels
{
    public class EditLegalEntityClientViewModel : BaseNotifier
    {
        public InputLegalEntityClientModel Client { get; set; }

        public BindingList<CommonClientModel> IndividualClients { get; set; }

        private readonly DocumentRepository<LegalEntityClient> legalEntityClientRepository;

        private readonly DocumentRepository<IndividualClient> individualClientRepository;

        private readonly Guid clientId;

        public EditLegalEntityClientViewModel(Guid id)
        {
            this.legalEntityClientRepository = new DocumentRepository<LegalEntityClient>();
            this.individualClientRepository = new DocumentRepository<IndividualClient>();
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
                try
                {
                    this.legalEntityClientRepository.Update(mappedModel);
                }
                catch (EntityNotFoundException ex)
                {
                    NotificationService.PopupSomethingWentWrong("This client couldn't be found!");
                }
                catch (ArgumentNullException ex)
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
            var data = this.legalEntityClientRepository
                .GetById(clientId)
                .MapToInputLegalEntityClientModel();

            if (data == null)
            {
                return;
            }

            this.Client = data;
            this.NotifyPropertyChanged(nameof(this.Client));

            var individualClients = this.individualClientRepository
               .GetAll()
               .MapToCommonClientModel()
               .ToList();

            this.IndividualClients = new BindingList<CommonClientModel>(individualClients);
            this.NotifyPropertyChanged(nameof(this.IndividualClients));
        }
    }
}
