using LojaVirtual.Domain.Dto;

namespace LojaVirtual.Domain.Services.Interfaces
{
    public interface IPessoaService : IServiceBase<Pessoa>
    {
        PessoaDTO ConsultarPorCpf(string cpf);
    }
}
