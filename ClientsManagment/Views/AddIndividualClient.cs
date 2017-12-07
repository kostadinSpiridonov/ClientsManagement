using ClientsManagment.Models;
using ClientsManagment.ViewModels;
using System.Windows.Forms;

namespace ClientsManagment.Views
{
    public partial class AddIndividualClient : UserControl
    {
        private readonly AddIndividualClientViewModel viewModel;

        public AddIndividualClient()
        {
            InitializeComponent();

            this.viewModel = new AddIndividualClientViewModel();
            this.SetBindings();
            this.SetEvents();
            this.SetStyles();
        }

        public void SetBindings()
        {
            this.FullNameTextBox.DataBindings.Add(nameof(TextBox.Text), this.viewModel.ViewData, nameof(IndividualClient.FullName));
            this.GenderTextBox.DataBindings.Add(nameof(TextBox.Text), this.viewModel.ViewData, nameof(IndividualClient.Gender));
            this.IdNumTextBox.DataBindings.Add(nameof(TextBox.Text), this.viewModel.ViewData, nameof(IndividualClient.IdentificationNumber));
            this.AddressTextBox.DataBindings.Add(nameof(TextBox.Text), this.viewModel.ViewData, nameof(IndividualClient.Address));
            this.PhoneTextBox.DataBindings.Add(nameof(TextBox.Text), this.viewModel.ViewData, nameof(IndividualClient.Phone));
            this.EmailTextBox.DataBindings.Add(nameof(TextBox.Text), this.viewModel.ViewData, nameof(IndividualClient.Email));
        }

        private void SetEvents()
        {
            this.AddButton.Click += (object sender, System.EventArgs e) => { this.viewModel.Add(); };
        }

        private void SetStyles()
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
