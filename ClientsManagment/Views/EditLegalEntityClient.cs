using ClientsManagment.Models;
using ClientsManagment.Validation;
using ClientsManagment.ViewModels;
using System;
using System.Windows.Forms;

namespace ClientsManagment.Views
{
    public partial class EditLegalEntityClient : UserControl
    {
        private readonly EditLegalEntityClientViewModel viewModel;

        public EditLegalEntityClient(Guid id)
        {
            InitializeComponent();
            this.viewModel = new EditLegalEntityClientViewModel(id);
            this.SetBindings();
            this.ConfigElements();
            this.SetEvents();
            this.SetStyles();
        }

        private void SetEvents()
        {
            this.UpdateButton.Click += (object sender, EventArgs e) =>
            {
                this.viewModel.Update();
            };
        }

        private void FormTextBox_Validated(object sender, System.EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox == null)
            {
                return;
            }

            var boundProperyName = textbox.DataBindings?[0]?.BindingMemberInfo.BindingPath;
            viewModel.ValidateProperty(boundProperyName);
        }

        private void SetStyles()
        {
            this.Dock = DockStyle.Fill;
        }

        public void SetBindings()
        {
            if (viewModel?.Client == null)
            {
                return;
            }

            this.NameTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Name)}.{nameof(ValidatableField<object>.Value)}");
            this.NameErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Name)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.TypeTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Type)}.{nameof(ValidatableField<object>.Value)}");
            this.TypeErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Type)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.BulstatTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Bulstat)}.{nameof(ValidatableField<object>.Value)}");
            this.BulstatErrors.DataBindings.Add(nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Bulstat)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.TaxRegistryTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.TaxRegistryNumber)}.{nameof(ValidatableField<object>.Value)}");
            this.TaxRegistryErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.TaxRegistryNumber)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.WebSiteTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.WebSiteUrl)}.{nameof(ValidatableField<object>.Value)}");
            this.WebSiteErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.WebSiteUrl)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.IndividualsComboBox.DataBindings.Add(
                nameof(ComboBox.SelectedValue),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.IndividualId)}.{nameof(ValidatableField<object>.Value)}");
            this.IndividualsComboBox.DataBindings.Add(
                nameof(ComboBox.DataSource),
                this.viewModel,
                nameof(EditLegalEntityClientViewModel.IndividualClients));
            this.IndividualIdErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.IndividualId)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.AddressTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Address)}.{nameof(ValidatableField<object>.Value)}");
            this.AddressErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Address)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.PhoneTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Phone)}.{nameof(ValidatableField<object>.Value)}");
            this.PhoneErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Phone)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.EmailTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Email)}.{nameof(ValidatableField<object>.Value)}");
            this.EmailErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputLegalEntityClientModel.Email)}.{nameof(ValidatableField<object>.ErrorsAsString)}");
        }

        public void ConfigElements()
        {
            this.IndividualsComboBox.DisplayMember = nameof(CommonClientModel.Name);
            this.IndividualsComboBox.ValueMember = nameof(CommonClientModel.Id);
        }
    }
}
