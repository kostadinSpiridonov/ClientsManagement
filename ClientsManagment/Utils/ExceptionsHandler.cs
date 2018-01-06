using ClientManagment.DataAccess.Exceptions;
using ClientsManagement.Database.Exceptions;
using ClientsManagement.EventHub;
using System;

namespace ClientsManagment.Utils
{
    public static class ExceptionsHandler
    {
        public static void Initialize()
        {
            ExceptionsHub.ExceptionEvents += ExceptionsHub_ExceptionEvents;
        }

        private static void ExceptionsHub_ExceptionEvents(object sender, System.Exception e)
        {
            if (e is DatabaseAccessException || e is DatabaseCreationException)
            {
                NotificationService.PopupSomethingWentWrong("There is a problem with the database! Please contact us kostadin.spiridonov@gmail.com");
                Environment.Exit(0);
            }
        }
    }
}
