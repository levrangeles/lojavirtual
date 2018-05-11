using LojaVirtual.Domain;
using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Infra.Data.Interfaces;

namespace LojaVirtual.Infra.Data
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(IDatasourceContext context) : base(context)
        {
        }
    }
}
