using DouglasStore.Domain.LojaContexto.Enums;

namespace DouglasStore.Domain.LojaContexto.ObjetoValor
{
    public class Endereco
    {
        public Endereco( string rua
                       , string numero
                       , string complemento
                       , string bairro
                       , string cidade
                       , string estado
                       , string pais
                       , string cep
                       , ETipoEndereco tipoEndereco){
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            CEP = cep;
            Tipoendereco = tipoEndereco;
        }
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string CEP { get; private set; }
        public ETipoEndereco Tipoendereco { get; private set; }

        public override string ToString()
        {
            return $"{Rua}, {Numero} - {Cidade}/{Estado}";
        }
    }
}