using ClientManagment.DataAccess;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Notify;
using ClientsManagment.Validation;
using System.ComponentModel;

namespace ClientsManagment.ViewModels
{
    public class AddLegalEntityClientViewModel : BaseNotifier
    {
        public LegalEntityClientModel ViewData { get; set; }

        public BindingList<IndividualClient> IndividualClients { get; set; }

        private readonly DocumentRepository<LegalEntityClient> legalEntityClientRepository;

        private readonly DocumentRepository<IndividualClient> individualClientRepository;

        public AddLegalEntityClientViewModel()
        {
            this.ViewData = new LegalEntityClientModel();
            this.legalEntityClientRepository = new DocumentRepository<LegalEntityClient>();
            this.individualClientRepository = new DocumentRepository<IndividualClient>();
            this.LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            this.IndividualClients = new BindingList<IndividualClient>(individualClientRepository.GetAll());
            this.NotifyPropertyChanged(nameof(IndividualClients));
        }
        
        public void Add()
        {
            bool valid = Validator.ValidateModel(this.ViewData);
            this.ViewData.NotifyPropertiesChanged();

            if (valid)
            {
                var mappedModel = this.ViewData.MapToLegalEntityClient();
                this.legalEntityClientRepository.Add(mappedModel);
            }
        }

        public void ValidateProperty(string boundProperyName)
        {
            Validator.ValidateProperty(this.ViewData, boundProperyName);
            this.ViewData.NotifyPropertyChanged(boundProperyName);
        }
    }
}
