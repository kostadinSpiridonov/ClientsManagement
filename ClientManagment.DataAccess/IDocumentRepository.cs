using ClientsManagment.Models;
using System;
using System.Collections.Generic;

namespace ClientManagment.DataAccess
{
    public interface IDocumentRepository<T> where T : IEntity
    {
        IList<T> GetAll();

        T Add(T model);

        void Delete(Guid Id);

        T GetById(Guid Id);
    }
}
