using CapyFinPlan.Domain.Model.Enum;

using System;

namespace CapyFinPlan.Domain.Model.Modelos.Ativos.RendaFixa
{
    public class Cdb : RendaFixaBase
    {
        public Cdb(DateTime dataCompra, DateTime dataVencimento, decimal valorInvestido, ETipoOperacao operacao, float taxaPactuada, ETipoIndexador indexador)
            : base(dataCompra, dataVencimento, valorInvestido, operacao, taxaPactuada, indexador)
        {

        }
    }
}
