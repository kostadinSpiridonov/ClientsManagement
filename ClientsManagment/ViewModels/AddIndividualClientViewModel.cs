using ClientManagment.DataAccess;
using ClientsManagment.Mappings;
using ClientsManagment.Models;
using ClientsManagment.Utils;
using ClientsManagment.Validation;
using ClientsManagment.Views;

namespace ClientsManagment.ViewModels
{
    public class AddIndividualClientViewModel
    {
        public InputIndividualClientModel ViewData { get; set; }

        private readonly DocumentRepository<IndividualClient> repository;

        public AddIndividualClientViewModel()
        {
            this.ViewData = new InputIndividualClientModel();
            this.repository = new DocumentRepository<IndividualClient>();
        }

        public void Add()
        {
            bool valid = Validator.ValidateModel(this.ViewData);
            this.ViewData.NotifyPropertiesChanged();

            if (valid)
            {
                var mappedModel = this.ViewData.MapToIndividualClient();
                this.repository.Add(mappedModel);

                NavigationService.OpenNewControl(new ClientsView());
            }
        }

        public void ValidateProperty(string boundProperyName)
        {
            Validator.ValidateProperty(this.ViewData, boundProperyName);
            this.ViewData.NotifyPropertyChanged(boundProperyName);
        }
    }
}
