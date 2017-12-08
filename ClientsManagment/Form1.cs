using ClientsManagment.Views;
using System.Windows.Forms;

namespace ClientsManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void addIndividualClientToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (this.NavigationContainer.Controls.ContainsKey(nameof(AddIndividualClient)))
            {
                return;
            }

            this.NavigationContainer.Controls.Clear();
            this.NavigationContainer.Controls.Add(new AddIndividualClient());
        }

        private void addLevalEntityClientToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (this.NavigationContainer.Controls.ContainsKey(nameof(AddLegalEntityClientView)))
            {
                return;
            }

            this.NavigationContainer.Controls.Clear();
            this.NavigationContainer.Controls.Add(new AddLegalEntityClientView());
        }

        private void clientsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (this.NavigationContainer.Controls.ContainsKey(nameof(ClientsView)))
            {
                return;
            }

            this.NavigationContainer.Controls.Clear();
            this.NavigationContainer.Controls.Add(new ClientsView());
        }
    }
}
