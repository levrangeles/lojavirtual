using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Domain.Services
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        public PedidoService(IPedidoRepository repository) : base(repository)
        {
            
        }
    }
}
