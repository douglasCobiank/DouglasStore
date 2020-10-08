namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class ItemPedido
    {
        public ItemPedido(Produto produto, decimal qtde){
            produtos = produto;
            Quantidade = qtde;
            Preco = produto.Preco;
        }
        public Produto produtos { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal Preco { get; private set; }
    }
}