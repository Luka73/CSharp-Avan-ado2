using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SucessoNomePreenchido()
        {
           /* Cliente cliente = new Cliente();
            cliente.Nome = "Luana";
            Assert.IsNotNull(cliente.Nome);*/
        }

        [TestMethod]
        public void ErroNomeNaoPreenchido()
        {
           /* Cliente cliente = new Cliente();
            Assert.IsNull(cliente.Nome);*/
        }
    }
}
