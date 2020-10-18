using CapyFinPlan.Domain.Model.Enum;

using System;

namespace CapyFinPlan.Domain.Model.Modelos.Ativos.RendaFixa
{
    public class RendaFixaBase : AtivoBase
    {
        public RendaFixaBase(DateTime dataCompra, DateTime dataVencimento, decimal valorInvestido, ETipoOperacao operacao, float taxaPactuada, ETipoIndexador indexador)
            : base(dataCompra, valorInvestido, operacao)
        {
            DataVencimento = dataVencimento;
            TaxaPactuada = taxaPactuada;
            Indexador = indexador;
        }

        public float TaxaPactuada { get; set; }
        public DateTime DataVencimento { get; set; }
        public ETipoIndexador Indexador { get; set; }
    }
}
