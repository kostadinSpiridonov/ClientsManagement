using ClientManagment.DataAccess;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Utils;
using ClientsManagment.Validation;
using ClientsManagment.Views;
using System.ComponentModel;
using System.Linq;

namespace ClientsManagment.ViewModels
{
    public class AddLegalEntityClientViewModel : BaseNotifier
    {
        public InputLegalEntityClientModel ViewData { get; set; }

        public BindingList<CommonClientModel> IndividualClients { get; set; }

        private readonly DocumentRepository<LegalEntityClient> legalEntityClientRepository;

        private readonly DocumentRepository<IndividualClient> individualClientRepository;

        public AddLegalEntityClientViewModel()
        {
            this.ViewData = new InputLegalEntityClientModel();
            this.legalEntityClientRepository = new DocumentRepository<LegalEntityClient>();
            this.individualClientRepository = new DocumentRepository<IndividualClient>();
            this.LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            var individualClients = this.individualClientRepository
                .GetAll()
                .MapToCommonClientModel()
                .ToList();

            this.IndividualClients = new BindingList<CommonClientModel>(individualClients);
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

            NavigationService.OpenNewControl(new ClientsView());
        }

        public void ValidateProperty(string boundProperyName)
        {
            Validator.ValidateProperty(this.ViewData, boundProperyName);
            this.ViewData.NotifyPropertyChanged(boundProperyName);
        }
    }
}
