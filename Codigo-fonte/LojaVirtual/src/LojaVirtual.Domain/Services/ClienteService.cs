using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        public ClienteService(IClienteRepository repository) : base(repository)
        {
        }
    }
}
