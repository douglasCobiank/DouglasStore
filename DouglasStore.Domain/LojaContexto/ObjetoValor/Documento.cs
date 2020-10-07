namespace DouglasStore.Domain.LojaContexto.ObjetoValor
{
    public class Documento
    {
        public Documento(string numero){
            Numero = numero;
        }
        public string Numero { get; private set; }

        public override string ToString()
        {
            return Numero;
        }
    }
}