namespace DouglasStore.Domain.LojaContexto.ObjetoValor
{
    public class Nome
    {
        public Nome(string primeironome,string sobrenome){
            PrimeiroNome = primeironome;
            Sobrenome = sobrenome;
        }
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public override string ToString(){
            return $"{PrimeiroNome} {Sobrenome}";
        }
    }
}