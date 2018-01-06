using System.Windows.Forms;

namespace ClientsManagment.Utils
{
    public static class NotificationService
    {

        public static void Popup(string title, string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        public static void PopupSomethingWentWrong(string message)
        {
            Popup("Something went wrong", message, MessageBoxIcon.Error);
        }
    }
}
