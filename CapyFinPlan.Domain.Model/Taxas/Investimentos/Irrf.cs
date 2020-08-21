using CapyFinPlan.Domain.Model.Interfaces;

using System;

namespace CapyFinPlan.Domain.Model.Taxas.Investimentos
{
    public class Irrf : IImpostos
    {
        public double RetornarAliquota(int quantidadeDias)
        {
            if (quantidadeDias < 0)
                throw new Exception("Quantidade de dias não pode ser negativa.");

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
