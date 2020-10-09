using System.Collections;
using System;
using System.Net.Http.Headers;
using FluentValidator;

namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class ItemPedido: Notifiable
    {
        public ItemPedido(Produto produto, decimal qtde){
            produtos = produto;
            Quantidade = qtde;
            Preco = produto.Preco;

            if(produto.QtdeEstoque < qtde){
                AddNotification("Quantidade","Produto fora de estoque");
            }
        }

        public Produto produtos { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal Preco { get; private set; }
    }
}