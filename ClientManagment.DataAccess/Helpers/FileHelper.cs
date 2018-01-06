using ClientManagment.DataAccess.Exceptions;
using ClientsManagement.EventHub;
using System;
using System.IO;

namespace ClientManagment.DataAccess.Helpers
{
    public class FileHelper
    {
        public static string ReadFile(string path)
        {
            string result = null;
            try
            {
                using (var stream = new StreamReader(path))
                {
                    result = stream.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                // Log here
                ExceptionsHub.CreateExceptionEvent(new DatabaseAccessException());
            }

            return result;
        }

        public static string OverwriteFile(string path, string content)
        {
            string result = null;
            try
            {
                using (var stream = new StreamWriter(path))
                {
                    stream.Write(content);
                }
            }
            catch (Exception e)
            {
                // Log here
                ExceptionsHub.CreateExceptionEvent(new DatabaseAccessException());
            }

            return result;
        }
    }
}
