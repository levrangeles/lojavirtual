using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaVirtual.Infra.Data.Tests
{
    [TestClass]
    public class PessoaRepositoryTest
    {
        [TestMethod]
        public void DeveBuscarUmaPessoa()
        {
            var pessoaRepository = new PessoaRepository(null);
            var result = pessoaRepository.ConsultarPorCpf("03146640171");

            Assert.IsNotNull(result);
        }
    }
}
