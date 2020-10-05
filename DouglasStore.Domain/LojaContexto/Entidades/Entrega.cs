using System;
namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Entrega
    {
        public DateTime DataPedido {get;set;}
        public DateTime DataEstimadaDeEntrega {get;set;}
        public string Status{get;set;}
    }
}