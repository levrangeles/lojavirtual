using System;
using LojaVirtual.Domain.Services;
using LojaVirtual.Infra.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaVirtual.Domain.Tests
{
    [TestClass]
    public class PessoaServiceTest
    {
        [TestMethod]
        public void DeveBuscarUmaPessoa()
        {
            var pessoaRepository = new PessoaRepository(null);
            var pessoaService = new PessoaService(pessoaRepository);
            var result = pessoaService.ConsultarPorCpf("03146640171");

            Assert.IsNotNull(result);
        }
    }
}
