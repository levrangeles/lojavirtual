using System.Collections.Generic;

namespace LojaVirtual.Application.Interfaces
{
    public interface IApplicationBase<T, TDto> 
        where T : class 
        where TDto : class
    {
        TDto Add(TDto obj);
        TDto Update(TDto obj);
        void Remove(TDto obj);
        void RemoveBydId(int id);
        TDto GetById(int id);
        IList<TDto> GetAll();
    }
}
