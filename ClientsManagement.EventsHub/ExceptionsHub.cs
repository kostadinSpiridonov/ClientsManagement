using System;

namespace ClientsManagement.EventHub
{
    public static class ExceptionsHub
    {
        public static event EventHandler<Exception> ExceptionEvents = delegate { };

        public static void CreateExceptionEvent(Exception exception)
        {
            ExceptionEvents(null, exception);
        }
    }
}
