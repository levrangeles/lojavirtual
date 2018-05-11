using LojaVirtual.Domain;
using LojaVirtual.Domain.Dto;
using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Infra.Data.Interfaces;

namespace LojaVirtual.Infra.Data
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(IDatasourceContext context) : base(context)
        {
        }

        public PessoaDTO ConsultarPorCpf(string cpf)
        {
            PessoaService.PessoaPerfil3[] result = new PessoaService.SOAPServiceClient().ConsultarCPFP3(cpf, cpf);

            if (result != null && result.Length > 0)
            {
                var pessoa = result[0];

                return new PessoaDTO
                {
                    Nome = pessoa.Nome,
                    Cpf = pessoa.CPF
                };

            }

            return null;
        }
    }
}
