using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        public ProdutoService(IProdutoRepository repository) : base(repository)
        {
        }
    }
}
