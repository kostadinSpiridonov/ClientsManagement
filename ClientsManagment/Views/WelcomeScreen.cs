using ClientsManagment.Utils;
using System.Windows.Forms;

namespace ClientsManagment.Views
{
    public partial class WelcomeScreen : UserControl
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            this.SetStyles();
        }

        private void SetStyles()
        {
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            NavigationService.OpenNewControl(new ClientsView());
        }
    }
}
