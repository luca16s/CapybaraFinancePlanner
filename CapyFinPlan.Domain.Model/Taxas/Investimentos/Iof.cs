using CapyFinPlan.Domain.Model.Interfaces;

using System;

namespace CapyFinPlan.Domain.Model.Taxas.Investimentos
{
    public class Iof : IImpostos
    {
        public double RetornarAliquota(int quantidadeDias)
        {
            if (quantidadeDias < 0)
                throw new Exception("Quantidade de dias não pode ser negativa.");

            if (quantidadeDias >= 30 || quantidadeDias == 0)
                return default;

            var totalIof = 97.0;

            if (quantidadeDias == 1)
                return (totalIof-1.0)/100;

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

            return totalIof/100;
        }
    }
}
