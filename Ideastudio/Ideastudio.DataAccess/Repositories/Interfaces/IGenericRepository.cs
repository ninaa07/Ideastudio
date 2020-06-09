using Ideastudio.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ideastudio.DataAccess.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T Get(object id);

        void Add(T obj);

        void Update(T obj);

        void Delete(T obj);

        void SaveChanges();
    }
}
