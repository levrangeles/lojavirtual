using System.Collections.Generic;

namespace LojaVirtual.Domain.Repositories.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        T Add(T obj);
        T Update(T obj);
        void Remove(T obj);
        void RemoveBydId(int id);
        T GetById(int id);
        IList<T> GetAll();
    }
}
