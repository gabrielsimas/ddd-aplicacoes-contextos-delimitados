using Cadastro.Core.Modelo.Dominio.Organizadores;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cadastro.Testes
{
    [TestClass]
    public class NomeCompletoTeste
    {
        [TestMethod]
        public void NomeCompletoDeveRetornarSucesso()
        {
            NomeCompleto nomeCompleto = new NomeCompleto("Gabriel","Simas");
            Assert.AreEqual("Gabriel Simas",nomeCompleto.EscreverNome(),true,$"Nome Completo {nomeCompleto} incorreto");
        }
    }
}
