using Flunt.Notifications;
using Flunt.Validations;

namespace CapyFinPlan.Domain.Model.Taxas.Investimentos
{
    public class Iof : Notifiable
    {
        public double RetornarAliquota(int quantidadeDias)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerThan(0, quantidadeDias, nameof(quantidadeDias), "Quantidade de dias não pode ser negativa."));

            if (quantidadeDias >= 30 || quantidadeDias == 0)
                return default;

            var totalIof = 97.0;

            if (quantidadeDias == 1)
                return (totalIof - 1.0) / 100;

            var contador = 0;
            for (int dia = 0; dia < quantidadeDias; dia++)
            {
                if (contador == 3)
                {
                    totalIof -= 4.0;
                    contador = 0;
                    continue;
                }

                totalIof -= 3.0;
                contador++;
            }

            return totalIof / 100;
        }
    }
}