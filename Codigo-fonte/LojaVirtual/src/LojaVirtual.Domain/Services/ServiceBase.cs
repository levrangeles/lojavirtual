using System.Collections.Generic;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        public  IRepositoryBase<T> Repository;
        public ServiceBase(IRepositoryBase<T> repository)
        {
            Repository = repository;
        }

        public virtual T Add(T obj)
        {
            return Repository.Add(obj);
        }

        public virtual IList<T> GetAll()
        {
            return Repository.GetAll();
        }

        public virtual T GetById(int id)
        {
            return Repository.GetById(id);
        }

        public virtual void Remove(T obj)
        {
            Repository.Remove(obj);
        }

        public virtual void RemoveBydId(int id)
        {
            Repository.RemoveBydId(id);
        }

        public virtual T Update(T obj)
        {
            return Repository.Update(obj);
        }
    }
}
