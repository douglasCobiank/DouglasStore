using System;
using System.Collections.Generic;

namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Pedido
    {
        public Cliente Clientes{ get; private set; }
        public string Numero { get; set; }
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
        public IList<ItemPedido> Itens { get; set; }
        public IList<Entrega> Entregas{ get; set; }

        public void FecharPedido(){}
        //public void GerarNotaFiscal(){}
    }
}