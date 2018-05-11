using LojaVirtual.Application.Interfaces;
using LojaVirtual.Domain;
using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Application
{
    public class ClienteApplication : ApplicationBase<Cliente, ClienteDTO>, IClienteApplication
    {
        public ClienteApplication(IClienteService service) : base(service)
        {
        }
    }
}
