using LojaVirtual.Domain;
using LojaVirtual.Infra.Data.Interfaces;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace LojaVirtual.Infra.Data.Contexts
{
    public class LojaVirtualContext : DbContext, IDatasourceContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        public LojaVirtualContext() : base("lojavirtual")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public T Add<T>(T obj) where T : class
        {
            var entity = Set<T>().Add(obj);
            SaveChanges();

            return entity;
        }

        public T Update<T>(T obj) where T : class
        {
            Entry<T>(obj).CurrentValues.SetValues(obj);
            SaveChanges();

            return obj;
        }

        public void Remove<T>(T obj) where T : class
        {
            Set<T>().Remove(obj);
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return Set<T>().AsQueryable();
        }
    }
}
