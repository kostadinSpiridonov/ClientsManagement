using ClientManagment.DataAccess.Helpers;
using ClientsManagement.Database.Configuration;
using ClientsManagment.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientManagment.DataAccess
{
    public class DocumentRepository<T> : IDocumentRepository<T> where T : IEntity
    {
        private readonly string databasePath;

        public DocumentRepository()
        {
            this.databasePath = DbConfig.Configuration.GetDbFilePathByEntity<T>();
        }

        public IList<T> GetAll()
        {
            string json = FileHelper.ReadFile(this.databasePath);
            var result = JsonConvert.DeserializeObject<IList<T>>(json);
            if (result == null)
            {
                result = new List<T>();
            }

            return result;
        }

        public T Add(T model)
        {
            model.Id = Guid.NewGuid();

            var all = this.GetAll();
            all.Add(model);

            string json = JsonConvert.SerializeObject(all);
            FileHelper.OverwriteFile(databasePath, json);

            return model;
        }

        public void Delete(Guid Id)
        {
            var all = this.GetAll();
            var deleteItem = all.FirstOrDefault(x => x.Id == Id);
            //TODO if deleteItem=null throw
            all.Remove(deleteItem);

            string json = JsonConvert.SerializeObject(all);
            FileHelper.OverwriteFile(databasePath, json);
        }

        public T GetById(Guid Id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == Id);
        }

        public T Update(T model)
        {
            if (model == null)
            {
                //TODO: throw exception
                return default(T);
            }

            var all = this.GetAll();
            var deleteItem = all.FirstOrDefault(x => x.Id == model.Id);
            //TODO if deleteItem=null throw
            all.Remove(deleteItem);

            all.Add(model);
            
            string json = JsonConvert.SerializeObject(all);
            FileHelper.OverwriteFile(databasePath, json);

            return model;
        }
    }
}
