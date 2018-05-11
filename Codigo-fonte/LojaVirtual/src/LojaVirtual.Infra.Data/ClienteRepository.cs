using LojaVirtual.Domain;
using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Infra.Data.Interfaces;

namespace LojaVirtual.Infra.Data
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(IDatasourceContext context) : base(context)
        {
        }
    }
}
