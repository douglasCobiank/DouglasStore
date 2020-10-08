using Microsoft.VisualStudio.TestTools.UnitTesting;
using DouglasStore.Domain.LojaContexto.Entidades;
using DouglasStore.Domain.LojaContexto.ObjetoValor;
using DouglasStore.Domain.LojaContexto.Enums;
using System;

namespace DouglasStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nome = new Nome("Douglas","Teixeira Cobiank");
            var documento = new Documento("50.725.267-6");
            var email = new Email("douglas.cobiank@hotmail.com");
            var endereco = new Endereco("Rua Jaime Pinto Rosas","56","Apto 1","Jd Carvalho","Ponta Grossa", "Paraná", "Brasil","84015600",ETipoEndereco.Entrega);
            var c = new Cliente(nome,documento,email,"42 991035593",endereco);

            var order = new Pedido(c);
            var produtos = new Produto("Mouse","Mouse sem Fio","mouse.jpg",42, 10);
            order.AddItem(new ItemPedido(produtos,2));
            order.FecharPedido();
            order.PagarPedido();
            order.Enviar();
            //Console.WriteLine(order.ToString());
            
        }
    }
}
