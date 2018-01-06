using System.Windows.Forms;
using ClientsManagment.ViewModels;
using ClientsManagment.Models;
using System.Linq;
using ClientsManagment.Utils;
using System;

namespace ClientsManagment.Views
{
    public partial class ClientsView : UserControl
    {
        private readonly ClientsViewModel viewModel;

        public ClientsView()
        {
            InitializeComponent();

            this.viewModel = new ClientsViewModel();
            this.InitDataGridView();
            this.SetStyles();
        }

        private void InitDataGridView()
        {
            this.ClientsContainer.CellContentClick += ClientsContainer_CellClick;
            this.ClientsContainer.AutoGenerateColumns = false;
            this.ClientsContainer.DataBindings.Add(nameof(DataGridView.DataSource), this.viewModel, nameof(ClientsViewModel.Clients));

            this.ClientsContainer.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CommonClientModel.Id),
                Visible = false
            });
            this.ClientsContainer.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CommonClientModel.Name),
                Name = nameof(CommonClientModel.Name),
            });
            this.ClientsContainer.Columns.Add(new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Details",
                Tag = ClientActions.Details
            });
            this.ClientsContainer.Columns.Add(new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Remove",
                Tag = ClientActions.Remove
            });
            this.ClientsContainer.Columns.Add(new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Edit",
                Tag = ClientActions.Edit
            });
        }

        private void ClientsContainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            var column = grid?.Columns?[e.ColumnIndex];
            if (column == null)
            {
                NotificationService.PopupSomethingWentWrong("Please try again!");
                return;
            }

            if (column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var clientId = (Guid)grid.Rows[e.RowIndex].Cells[0].Value;
                switch ((ClientActions)column.Tag)
                {
                    case ClientActions.Edit:
                        this.viewModel.NavigateToEdit(clientId);
                        break;
                    case ClientActions.Details:
                        this.viewModel.NavigateToDetails(clientId);
                        break;
                    case ClientActions.Remove:
                        this.viewModel.Delete(clientId);
                        break;
                }
            }
        }

        private void SetStyles()
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
