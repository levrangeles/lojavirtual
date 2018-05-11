using LojaVirtual.Application.Interfaces;
using LojaVirtual.Domain;
using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Application
{
    public class PedidoApplication : ApplicationBase<Pedido, PedidoDTO>, IPedidoApplication
    {
        public PedidoApplication(IPedidoService service) : base(service)
        {
        }
    }
}
