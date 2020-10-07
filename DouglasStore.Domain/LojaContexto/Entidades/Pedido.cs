using System;
using System.Collections.Generic;
using DouglasStore.Domain.LojaContexto.Enums;

namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Pedido
    {
        public Pedido(Cliente cliente){
            Clientes = cliente;
            Numero = Guid.NewGuid().ToString().Replace("-","").Substring(0,8).ToUpper();
            DataPedido  =DateTime.Now;
            Status = EStatus.Criado;
            Itens = new List<ItemPedido>();
            Entregas = new List<Entrega>();
        }
        public Cliente Clientes{ get; private set; }
        public string Numero { get; private set; }
        public DateTime DataPedido { get; private set; }
        public EStatus Status { get; private set; }
        public IReadOnlyCollection<ItemPedido> Itens { get; private set; }
        public IReadOnlyCollection<Entrega> Entregas{ get; private set; }

        public void AddItem(ItemPedido item){

        }
        public void FecharPedido(){}
        //public void GerarNotaFiscal(){}
    }
}