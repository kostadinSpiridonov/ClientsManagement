using System.Windows.Forms;
using ClientsManagment.ViewModels;
using ClientsManagment.Models;

namespace ClientsManagment.Views
{
    public partial class ClientsView : UserControl
    {
        private readonly ClientsViewModel viewModel;

        public ClientsView()
        {
            InitializeComponent();

            this.viewModel = new ClientsViewModel();
            this.InitBidings();
            this.SetStyles();
        }

        private void InitBidings()
        {
            this.ClientsContainer.DataBindings.Add(nameof(ListBox.DataSource), this.viewModel, nameof(ClientsViewModel.Clients));
            this.ClientsContainer.DisplayMember = nameof(CommonClientModel.Name);
            this.ClientsContainer.ValueMember = nameof(CommonClientModel.Id);
        }

        private void SetStyles()
        {
            this.Dock = DockStyle.Fill;
        }

        private void DeleteSelectedButton_Click(object sender, System.EventArgs e)
        {

            var selectedItem = (this.ClientsContainer.SelectedItem as CommonClientModel);
            if (selectedItem == null)
            {
                //TODO: Error handling
            }
            else
            {
                this.viewModel.Delete(selectedItem.Id);
            }
        }
    }
}
