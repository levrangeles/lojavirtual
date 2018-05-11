using LojaVirtual.Domain.Dto;
using System.Collections.Generic;

namespace LojaVirtual.Domain.Repositories.Interfaces
{
    public interface IPessoaRepository : IRepositoryBase<Pessoa>
    {
        PessoaDTO ConsultarPorCpf(string cpf);
    }
}
