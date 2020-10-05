using Microsoft.VisualStudio.TestTools.UnitTesting;
using DouglasStore.Domain.LojaContexto.Entidades;

namespace DouglasStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Cliente("Douglas","Teixeira Cobiank","50.725.267-6","douglas.cobiank@hotmail.com","42 991035593","Rua Jaime Pinto Rosas, 56");
            
        }
    }
}
