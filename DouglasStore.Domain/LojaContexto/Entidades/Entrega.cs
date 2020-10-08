using System.ComponentModel;
using System;
using DouglasStore.Domain.LojaContexto.Enums;

namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Entrega
    {
        public Entrega(DateTime dataEstimada){ 
            DataPedido = DateTime.Now;
            DataEstimadaDeEntrega = dataEstimada;
            Status = EStatusEntrega.Aguardando;
        }
        public DateTime DataPedido {get; private set;}
        public DateTime DataEstimadaDeEntrega {get; private set;}
        public EStatusEntrega Status{get; private set;}

        public void Enviado(){
            Status = EStatusEntrega.Enviado;
        }

        public void Cancelar(){
            Status = EStatusEntrega.Cancelado;
        }
    }
}