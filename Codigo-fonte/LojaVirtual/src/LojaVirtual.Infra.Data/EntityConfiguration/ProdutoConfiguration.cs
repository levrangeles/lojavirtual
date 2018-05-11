using LojaVirtual.Domain;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.Infra.Data.EntityConfiguration
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("Produto");

            HasKey(c => c.Id);

            Property(c => c.Nome).HasMaxLength(50).IsRequired();
            Property(c => c.Preco).IsRequired();
        }
    }
}
