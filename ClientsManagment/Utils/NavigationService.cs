using System.Windows.Forms;

namespace ClientsManagment.Utils
{
    public class NavigationService
    {
        private static Panel navigationContainer { get; set; }

        public static void SetNavigationContainer(Panel container)
        {
            navigationContainer = container;
        }

        public static void OpenNewControl(Control control)
        {
            var controlTypeName = control.GetType().Name;
            if (navigationContainer.Controls.ContainsKey(controlTypeName))
            {
                return;
            }

            navigationContainer.Controls.Clear();
            navigationContainer.Controls.Add(control);
        }
    }
}
