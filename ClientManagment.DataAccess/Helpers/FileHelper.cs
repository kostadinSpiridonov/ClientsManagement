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
            //TODO: Fix it
            catch (Exception e)
            {
                var a = e;
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
            //TODO: Fix it
            catch (Exception e)
            {
                var a = e;
            }

            return result;
        }
    }
}
