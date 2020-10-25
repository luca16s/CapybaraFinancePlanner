using CapyFinPlan.Domain.Model.Modelos.Ativos;

namespace CapyFinPlan.Domain.Model.Estrategias.Rentabilidade
{
    public interface IRentabilidadeStrategy
    {
        decimal CalculaRentabilidade(AtivoBase ativoBase);
    }
}
