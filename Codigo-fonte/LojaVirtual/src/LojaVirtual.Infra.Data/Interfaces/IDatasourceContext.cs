using System.Linq;

namespace LojaVirtual.Infra.Data.Interfaces
{
    public interface IDatasourceContext
    {
        T Add<T>(T obj) where T : class;
        T Update<T>(T obj) where T : class;
        void Remove<T>(T obj) where T : class;
        IQueryable<T> Query<T>() where T : class;
    }
}
