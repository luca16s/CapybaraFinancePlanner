using Flunt.Validations;

namespace CapyFinPlan.Domain.Model.Modelos.Empresa
{
    public class EmpresaBaseEntity : Entidade
    {
        public EmpresaBaseEntity(string nome, string cnpj)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace(nome, nameof(Nome), "Nome da Corretora não pode estar em branco."),
                new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace(cnpj, nameof(Cnpj), "CNPJ da corretora não pode estar em branco."));
            Nome = nome;
            Cnpj = cnpj;
        }

        public string Nome { get; set; }
        public string Cnpj { get; set; }
    }
}
