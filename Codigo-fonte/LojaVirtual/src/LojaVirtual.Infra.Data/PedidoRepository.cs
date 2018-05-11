using LojaVirtual.Domain;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Infra.Data.Interfaces;

namespace LojaVirtual.Infra.Data
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        public PedidoRepository(IDatasourceContext context) : base(context)
        {
        }
    }
}
