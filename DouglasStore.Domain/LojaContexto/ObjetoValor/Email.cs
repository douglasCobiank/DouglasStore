using FluentValidator;
using FluentValidator.Validation;

namespace DouglasStore.Domain.LojaContexto.ObjetoValor
{
    public class Email : Notifiable
    {
        public Email(string endereco){
            Endereco = endereco;

            AddNotifications(new ValidationContract()
                .Requires()
                .IsEmail(Endereco,"Email", "O Email é invalido")
            );
        }
        public string Endereco { get; private set; }

        public override string ToString()
        {
            return Endereco;
        }
    }
}