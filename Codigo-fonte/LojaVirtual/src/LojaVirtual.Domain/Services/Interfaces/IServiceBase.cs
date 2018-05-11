using System.Collections.Generic;

namespace LojaVirtual.Domain.Services.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        T Add(T obj);
        T Update(T obj);
        void Remove(T obj);
        void RemoveBydId(int id);
        T GetById(int id);
        IList<T> GetAll();
    }
}
