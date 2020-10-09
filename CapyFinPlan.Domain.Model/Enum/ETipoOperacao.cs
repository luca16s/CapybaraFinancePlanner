using System.ComponentModel;

namespace CapyFinPlan.Domain.Model.Enum
{
    public enum ETipoOperacao
    {
        [Description("Aluguel")]
        Aluguel,
        [Description("Venda")]
        Compra,
        [Description("Resgate")]
        Resgate,
        [Description("Compra")]
        Venda,
    }
}
