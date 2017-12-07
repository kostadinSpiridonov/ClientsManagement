using System;
using System.IO;
using System.Reflection;

namespace ClientsManagement.Database.Helpers
{
    public static class EmbeddedResourcesHelper
    {
        public static string ReadEmbeddedFile(string path)
        {
            string result = null;
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var fileStream = assembly.GetManifestResourceStream(path);

                using (var stream = new StreamReader(fileStream))
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
    }
}
