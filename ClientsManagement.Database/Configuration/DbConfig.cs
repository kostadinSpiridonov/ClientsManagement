using Newtonsoft.Json.Linq;
using ClientsManagement.Database.Helpers;
using System.IO;
using System;

namespace ClientsManagement.Database.Configuration
{
    public class DbConfig
    {
        private const string DbConfigFile = "ClientsManagement.Database.Configuration.DbConfiguration.json";

        private static DbConfig config;

        public static DbConfig Configuration
        {
            get
            {
                if (config == null)
                {
                    config = new DbConfig();
                }

                return config;
            }
        }

        public string GetDbFilePathByEntity<T>()
        {
            string typeName = typeof(T).Name;

            string json = EmbeddedResourcesHelper.ReadEmbeddedFile(DbConfigFile);
            var jsonObject = JObject.Parse(json);
            string query = $"$.DbFiles[?(@.EntityName == '{typeName}')].InnerFilePath";

            string innerPath = jsonObject?.SelectToken(query)?.ToString();
            return Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    innerPath);
        }

        public void ConfigureDbFiles()
        {
            string json = EmbeddedResourcesHelper.ReadEmbeddedFile(DbConfigFile);
            var jsonObject = JObject.Parse(json);

            this.CreateDbDirectory(jsonObject);
            this.CreateDbFiles(jsonObject);
        }

        private void CreateDbDirectory(JObject configuration)
        {
            try
            {
                string path = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    configuration["DbFolderName"].ToString());

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                //TODO: FIx it
            }
        }

        private void CreateDbFiles(JObject configuration)
        {
            try
            {
                foreach (var item in configuration["DbFiles"])
                {
                    var fileName = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        item["InnerFilePath"].ToString());

                    if (!File.Exists(fileName))
                    {
                        File.Create(fileName);
                    }
                }
            }
            catch (Exception e)
            {
                //TODO: FIx it
            }
        }
    }
}
