using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClientsManagment.ViewModels;
using ClientsManagment.Validation;
using ClientsManagment.Models;

namespace ClientsManagment.Views
{
    public partial class EditIndividualClientView : UserControl
    {
        private readonly EditIndividualClientViewModel viewModel;

        public EditIndividualClientView(Guid id)
        {
            InitializeComponent();

            this.viewModel = new EditIndividualClientViewModel(id);
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

            this.FullNameTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.FullName)}.{nameof(ValidatableField<object>.Value)}");
            this.FullNameErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.FullName)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.GenderComboBox.DataBindings.Add(
                nameof(ComboBox.SelectedValue),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.Gender)}.{nameof(ValidatableField<object>.Value)}");
            this.GenderErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.Gender)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.IdNumTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.IdentificationNumber)}.{nameof(ValidatableField<object>.Value)}");
            this.IdNumberErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.IdentificationNumber)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.AddressTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.Address)}.{nameof(ValidatableField<object>.Value)}");
            this.AddressErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.Address)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.PhoneTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.Phone)}.{nameof(ValidatableField<object>.Value)}");
            this.PhoneErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.Phone)}.{nameof(ValidatableField<object>.ErrorsAsString)}");

            this.EmailTextBox.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.Email)}.{nameof(ValidatableField<object>.Value)}");
            this.EmailErrors.DataBindings.Add(
                nameof(TextBox.Text),
                this.viewModel.Client,
                $"{nameof(InputIndividualClientModel.Email)}.{nameof(ValidatableField<object>.ErrorsAsString)}");
        }

        public void ConfigElements()
        {
            this.GenderComboBox.DataSource = Enum.GetValues(typeof(Gender)).Cast<Gender>().Select(v => new SelectListItem { Text = v.ToString(), Value = v }).ToList();
            this.GenderComboBox.DisplayMember = nameof(SelectListItem.Text);
            this.GenderComboBox.ValueMember = nameof(SelectListItem.Value);
        }
    }
}
