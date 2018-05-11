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
            Property(c => c.ClienteId).IsRequired();

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
