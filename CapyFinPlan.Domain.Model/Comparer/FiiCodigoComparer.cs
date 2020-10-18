using CapyFinPlan.Domain.Model.Modelos.Ativos.RendaVariavel;

using System.Collections.Generic;

namespace CapyFinPlan.Domain.Model.Comparer
{
    class FiiCodigoComparer : IComparer<FundoImobiliario>
    {
        public int Compare(FundoImobiliario x, FundoImobiliario y)
        {
            return x.Codigo.CompareTo(y.Codigo);
        }
    }
}
