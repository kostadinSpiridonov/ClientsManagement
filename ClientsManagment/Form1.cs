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

        private void addClientToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.NavigationContainer.Controls.Clear();
            this.NavigationContainer.Controls.Add(new AddIndividualClient());
        }

        private void clientsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            this.NavigationContainer.Controls.Clear();
            this.NavigationContainer.Controls.Add(new ClientsView());
        }
    }
}
