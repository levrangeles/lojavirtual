using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Domain.Services.Interfaces;

namespace LojaVirtual.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private IPessoaRepository Repository { get { return base.Repository as IPessoaRepository; } }

        public PessoaService(IPessoaRepository repository) : base(repository)
        {
            
        }

        public PessoaDTO ConsultarPorCpf(string cpf)
        {
            return Repository.ConsultarPorCpf(cpf);
        }
    }
}
