using Ideastudio.DataAccess.ExtensionMethods;
using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ideastudio.DataAccess.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public ApplicationContext _context;

        public DbSet<T> table = null;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table;
        }

        public T Get(object id)
        {
            return table.Find(id);
        }

        public void Add(T obj)
        {
            table.Add(obj);
            SaveChanges();
        }

        public void Update(T obj)
        {
            _context.DetachLocal(obj, obj.Id);
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(T obj)
        {
            table.Remove(obj);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
