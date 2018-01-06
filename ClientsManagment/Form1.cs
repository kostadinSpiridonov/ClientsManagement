using ClientsManagment.Utils;
using ClientsManagment.Views;
using System.Windows.Forms;

namespace ClientsManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NavigationService.SetNavigationContainer(this.NavigationContainer);
            NavigationService.OpenNewControl(new WelcomeScreen());
        }

        private void addIndividualClientToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            NavigationService.OpenNewControl(new AddIndividualClient());
        }

        private void addLevalEntityClientToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            NavigationService.OpenNewControl(new AddLegalEntityClientView());
        }

        private void clientsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            NavigationService.OpenNewControl(new ClientsView());
        }

        private void homeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            NavigationService.OpenNewControl(new WelcomeScreen());
        }
    }
}
