using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Domain.Services.Interfaces;
using System;

namespace LojaVirtual.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        public ProdutoService(IProdutoRepository repository) : base(repository)
        {
        }

        public override Produto Add(Produto produto)
        {
            if (string.IsNullOrEmpty(produto.Nome))
            {
                throw new Exception("Por favor, informe o nome do produto.");
            }

            if (produto.Preco <= 0)
            {
                throw new Exception("Pro favor, informe um preço válido.");
            }

            return base.Add(produto);
        }
    }
}
