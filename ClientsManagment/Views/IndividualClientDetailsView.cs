using System;
using System.Windows.Forms;
using ClientsManagment.ViewModels;
using ClientsManagment.Models;

namespace ClientsManagment.Views
{
    public partial class IndividualClientDetailsView : UserControl
    {
        private readonly IndividualClientDetailsViewModel viewModel;

        public IndividualClientDetailsView(Guid id)
        {
            InitializeComponent();
            this.viewModel = new IndividualClientDetailsViewModel(id);
            this.SetBindings();
            this.SetStyles();
        }

        public void SetStyles()
        {
            this.Dock = DockStyle.Fill;
        }

        private void SetBindings()
        {
            this.FullNameLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(IndividualClientModel.FullName)}");

            this.GenderLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(IndividualClientModel.Gender)}");

            this.IdentificationNumLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(IndividualClientModel.IdentificationNumber)}");

            this.AddressLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(IndividualClientModel.Address)}");

            this.PhoneLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(IndividualClientModel.Phone)}");

            this.EmailLabel.DataBindings.Add(
               nameof(TextBox.Text),
               this.viewModel.Client,
               $"{nameof(IndividualClientModel.Email)}");
        }
    }
}
