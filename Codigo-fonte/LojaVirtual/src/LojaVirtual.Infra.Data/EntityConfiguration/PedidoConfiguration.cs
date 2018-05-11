using LojaVirtual.Domain;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.Infra.Data.EntityConfiguration
{
    public class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            ToTable("Pedido");

            HasKey(c => c.Id);
            Property(c => c.Data).IsRequired();

            HasRequired(c => c.Cliente);

            HasMany(c => c.Produtos)
                .WithMany(c => c.Pedidos)
                .Map(m =>
                {
                    m.MapLeftKey("PedidoId");
                    m.MapRightKey("ProdutoId");
                    m.ToTable("PedidoProduto");
                });

        }
    }
}
