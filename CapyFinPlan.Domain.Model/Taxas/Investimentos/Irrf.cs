
using Flunt.Notifications;
using Flunt.Validations;

namespace CapyFinPlan.Domain.Model.Taxas.Investimentos
{
    public class Irrf : Notifiable
    {
        public double RetornarAliquota(int quantidadeDias)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerThan(0, quantidadeDias, nameof(quantidadeDias), "Quantidade de dias não pode ser negativa."));

            if (quantidadeDias < 180)
                return 22.50 / 100;

            if (quantidadeDias > 180 && quantidadeDias < 360)
                return 20.0 / 100;

            if (quantidadeDias > 360 && quantidadeDias < 720)
                return 17.50 / 100;

            return 15.0 / 100;
        }
    }
}
