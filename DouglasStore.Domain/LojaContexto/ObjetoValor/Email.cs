namespace DouglasStore.Domain.LojaContexto.ObjetoValor
{
    public class Email
    {
        public Email(string endereco){
            Endereco = endereco;
        }
        public string Endereco { get; private set; }

        public override string ToString()
        {
            return Endereco;
        }
    }
}