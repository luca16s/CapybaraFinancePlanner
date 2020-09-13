using System.ComponentModel;

namespace CapyFinPlan.Domain.Model.Enum
{
    public enum ETipoIndexador
    {
        [Description("Selic")]
        Selic,

        [Description("IPCA")]
        Ipca,

        [Description("CDI")]
        Cdi,

        [Description("Pré")]
        Pre,
    }
}