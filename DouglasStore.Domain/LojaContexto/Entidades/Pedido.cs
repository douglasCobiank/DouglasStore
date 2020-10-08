using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using DouglasStore.Domain.LojaContexto.Enums;

namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Pedido
    {
        private readonly IList<ItemPedido> _itemPedido;
        private readonly IList<Entrega> _entrega;
        public Pedido(Cliente cliente){
            Clientes = cliente;
            DataPedido  =DateTime.Now;
            Status = EStatus.Criado;
            _itemPedido = new List<ItemPedido>();
            _entrega = new List<Entrega>();
        }
        public Cliente Clientes{ get; private set; }
        public string Numero { get; private set; }
        public DateTime DataPedido { get; private set; }
        public EStatus Status { get; private set; }
        public IReadOnlyCollection<ItemPedido> Itens => _itemPedido.ToArray();
        public IReadOnlyCollection<Entrega> Entregas => _entrega.ToArray();

        public void AddItem(ItemPedido item){
            _itemPedido.Add(item);
        }

        public void AddEntrega(Entrega entrega){
            _entrega.Add(entrega);
        }

        //fecha o pedido
        public void FecharPedido(){
            Numero = Guid.NewGuid().ToString().Replace("-","").Substring(0,8).ToUpper();
        }

        //paga o pedido
        public void PagarPedido(){
            Status = EStatus.Pago;
        }

        public void Enviar(){
            //A cada 5 produtos uma entrega
            var entregas = new List<Entrega>();
            entregas.Add(new Entrega(DateTime.Now.AddDays(5)));
            var count = 1;

            //quebra as entregas
            foreach(var item in _itemPedido){
                if(count == 5){
                    count = 1;
                    entregas.Add(new Entrega(DateTime.Now.AddDays(5)));
                }
                count++;
            }
            //envia todas as entregas
            entregas.ForEach(x => x.Enviado());
            //add as entregas ao pedido
            entregas.ForEach(x => _entrega.Add(x));
        }

        public void Cancelar(){
            Status = EStatus.Cancelado;
            _entrega.ToList().ForEach(x => x.Cancelar());
        }
        //public void GerarNotaFiscal(){}
    }
}