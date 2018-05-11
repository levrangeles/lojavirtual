using LojaVirtual.Application.Interfaces;
using LojaVirtual.Domain;
using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Application
{
    public class ProdutoApplication : ApplicationBase<Produto, ProdutoDTO>, IProdutoApplication
    {
        public ProdutoApplication(IProdutoService service) : base(service)
        {
        }
    }
}
