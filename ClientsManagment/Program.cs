using ClientsManagement.Database.Configuration;
using ClientsManagment.Utils;
using System;
using System.Windows.Forms;

namespace ClientsManagment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExceptionsHandler.Initialize();
            DbConfig.Configuration.ConfigureDbFiles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
