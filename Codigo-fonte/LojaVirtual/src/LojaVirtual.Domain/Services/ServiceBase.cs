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

        public T Add(T obj)
        {
            return Repository.Add(obj);
        }

        public IList<T> GetAll()
        {
            return Repository.GetAll();
        }

        public T GetById(int id)
        {
            return Repository.GetById(id);
        }

        public void Remove(T obj)
        {
            Repository.Remove(obj);
        }

        public void RemoveBydId(int id)
        {
            Repository.RemoveBydId(id);
        }

        public T Update(T obj)
        {
            return Repository.Update(obj);
        }
    }
}
