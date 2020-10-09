using Flunt.Notifications;
using Flunt.Validations;

namespace CapyFinPlan.Domain.Model.Modelos.Usuario
{
    public class Email : Notifiable
    {
        private readonly string _Usuario;
        private readonly string _Provedor;

        public Email(string usuario, string provedor)
        {
            AddNotifications(
                new Contract()
                .IsEmail("", "", ""));

            _Usuario = usuario;
            _Provedor = provedor;
        }

        public override string ToString()
        {
            return $"{_Usuario}@{_Provedor}.com";
        }
    }
}
