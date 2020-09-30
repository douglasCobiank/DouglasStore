namespace DouglasStore.Domain.LojaContexto
{
    public class ItemPedido
    {
        public Produto produtos { get; set; }
        public string Quantidade { get; set; }
        public string Preco { get; set; }
    }
}