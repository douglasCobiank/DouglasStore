using System;
namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Cliente
    {
        //Solid
        //s = Apenas o que é da classe na classe.(Single Responsability Principal) 
        //o = Open Closed(Aberto para instanciação e fechado para modificação)
        //l = 
        //i =
        //d =
        public Cliente(
            string _primeiroNome,
            string _sobreNome,
            string _documento,
            string _email,
            string _telefone,
            string _endereco
        ){
            PrimeiroNome = _primeiroNome;
            Sobrenome = _sobreNome;
            Documento = _documento;
            Email = _email;
            Telefone = _telefone;
            Endereco = _endereco;
        }
        
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {Sobrenome}";
        }
    }
}