using System.Linq;
using System.Collections.Generic;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Infra.Data.Interfaces;

namespace LojaVirtual.Infra.Data
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private IDatasourceContext Context;

        public RepositoryBase(IDatasourceContext context)
        {
            Context = context;
        }

        public T Add(T obj)
        {
            return Context.Add(obj);
        }

        public IList<T> GetAll()
        {
            return Context.Query<T>().ToList();
        }

        public T GetById(int id)
        {
            return Context.Query<T>().FirstOrDefault(c => ((int) c.GetType().GetProperty("Id").GetValue(c)) == id);
        }

        public void Remove(T obj)
        {
            Context.Remove(obj);
        }

        public void RemoveBydId(int id)
        {
            var obj = GetById(id);

            if (obj != null)
            {
                Remove(obj);
            }
        }

        public T Update(T obj)
        {
            return Context.Update(obj);
        }
    }
}
