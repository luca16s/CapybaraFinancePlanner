using System;

namespace CapyFinPlan.Domain.Model.Modelos.Ativos
{
    public class FundoImobiliario: AtivoBase
    {
        public FundoImobiliario(string codigo, DateTime dataCompra, decimal valorCompra)
            : base(codigo, dataCompra, valorCompra)
        {

        }
    }
}
