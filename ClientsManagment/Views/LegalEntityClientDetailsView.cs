using System;
using System.Windows.Forms;
using ClientsManagment.ViewModels;
using ClientsManagment.Models;

namespace ClientsManagment.Views
{
    public partial class LegalEntityClientDetailsView : UserControl
    {
        private readonly LegalEntityClientDetailsViewModel viewModel;

        public LegalEntityClientDetailsView(Guid id)
        {
            InitializeComponent();
            this.viewModel = new LegalEntityClientDetailsViewModel(id);
            this.SetBindings();
            this.SetStyles();
        }

        public void SetStyles()
        {
            this.Dock = DockStyle.Fill;
        }

        private void SetBindings()
        {
            this.NameLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.Name)}");

            this.TypeLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.Type)}");

            this.BulstatLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.Bulstat)}");

            this.TaxRegistryLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.TaxRegisryNumber)}");

            this.WebLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.WebSiteUrl)}");

            this.IndividualClientLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.IndividualClientName)}");

            this.AddressLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.Address)}");

            this.PhoneLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.Phone)}");

            this.EmailLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(LegalEntityClientModel.Email)}");
        }
    }
}