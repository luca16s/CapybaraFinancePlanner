using Flunt.Validations;

namespace CapyFinPlan.Domain.Model.Modelos.Corretora
{
    public class Corretora : Entidade
    {
        public Corretora(string nome, string cnpj)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace(nome, nameof(Nome), "Nome da Corretora não pode estar em branco."));

            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace(cnpj, nameof(Cnpj), "CNPJ da corretora não pode estar em branco."));
        }

        public string Nome { get; set; }
        public string Cnpj { get; set; }
    }
}
