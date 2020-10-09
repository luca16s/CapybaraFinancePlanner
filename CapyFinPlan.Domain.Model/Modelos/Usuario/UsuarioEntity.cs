using Flunt.Validations;

namespace CapyFinPlan.Domain.Model.Modelos.Usuario
{
    public class UsuarioEntity : Entidade
    {
        public UsuarioEntity(string nome, string email, string provedor)
        {
            AddNotifications(
                new Contract()
                .IsNotNullOrWhiteSpace(nome, nameof(Nome), "Nome não pode estar vazio."));

            Nome = nome;
            Email = new Email(email, provedor);
        }

        public string Nome { get; set; }
        public Email Email { get; set; }
        public string Cargo { get; set; }
        public long Cpf { get; set; }
    }
}
