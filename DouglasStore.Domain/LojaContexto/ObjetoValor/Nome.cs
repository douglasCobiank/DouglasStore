using FluentValidator;
using FluentValidator.Validation;

namespace DouglasStore.Domain.LojaContexto.ObjetoValor
{
    public class Nome : Notifiable
    {
        public Nome(string primeironome,string sobrenome){
            PrimeiroNome = primeironome;
            Sobrenome = sobrenome;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(PrimeiroNome, 3 , "Primeiro Nome", "O primeiro nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(PrimeiroNome, 40, "Primeiro Nome", "O primeiro nome deve conter no maximo 40 caracteres" )
                .HasMinLen(Sobrenome, 3 , "Sobrenome", "O sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(Sobrenome, 40, "Sobrenome", "O Sobrenome deve conter no maximo 40 caracteres")
            );
        }
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public override string ToString(){
            return $"{PrimeiroNome} {Sobrenome}";
        }
    }
}