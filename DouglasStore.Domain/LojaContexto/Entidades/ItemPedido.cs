namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class ItemPedido
    {
        public Produto produtos { get; set; }
        public string Quantidade { get; set; }
        public string Preco { get; set; }
    }
}