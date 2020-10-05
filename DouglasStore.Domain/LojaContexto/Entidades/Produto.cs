using System;
namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Produto
    {
        public Produto(
            string _titulo,
            string _descricao,
            string _imagem,
            decimal _preco,
            decimal _qtdeEstoque
        ){
            Titulo = _titulo;
            Descricao = _descricao;
            Imagem = _imagem;
            Preco = _preco;
            QtdeEstoque = _qtdeEstoque;
        }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Imagem { get; private set; }
        public decimal Preco { get; private set; }
        public decimal QtdeEstoque { get; private set; }

        public override string ToString()
        {
            return $"{Titulo}";
        }
    }
}