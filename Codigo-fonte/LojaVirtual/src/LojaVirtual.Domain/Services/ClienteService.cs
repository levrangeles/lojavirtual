using LojaVirtual.Domain.Repositories.Interfaces;
using LojaVirtual.Domain.Services.Interfaces;
using System;

namespace LojaVirtual.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        IClienteRepository Repository;
        IPessoaRepository PessoaRepository;

        public ClienteService(IClienteRepository repository, IPessoaRepository pessoaRepository) : base(repository)
        {
            Repository = repository;
            PessoaRepository = pessoaRepository;
        }

        public override Cliente Add(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Cpf))
            {
                throw new Exception("Por favor, informe o CPF.");
            }

            var clienteConsulta = PessoaRepository.ConsultarPorCpf(cliente.Cpf);

            if (clienteConsulta == null || string.IsNullOrEmpty(clienteConsulta.Nome))
            {
                throw new Exception("O cliente não foi encontrado.");
            }

            cliente.Nome = clienteConsulta.Nome;

            if (string.IsNullOrEmpty(cliente.Email))
            {
                throw new Exception("Por favor, informe o e-mail.");
            }

            return base.Add(cliente);
        }
    }
}
