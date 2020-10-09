using CapyFinPlan.Domain.Model.Enum;

using System;

namespace CapyFinPlan.Domain.Model.Modelos.Ativos.RendaVariavel
{
    public class FundoImobiliario: RendaVariavelBase
    {
        public FundoImobiliario(string codigo, DateTime dataCompra, decimal valorCompra, int quantidadeCompra, decimal custoCompra, ETipoOperacao operacao)
            : base(codigo, dataCompra, valorCompra, quantidadeCompra, custoCompra, operacao)
        {

        }
    }
}
