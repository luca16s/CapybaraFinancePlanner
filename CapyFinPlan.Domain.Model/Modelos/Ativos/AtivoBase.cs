using CapyFinPlan.Domain.Model.Enum;

using Flunt.Validations;

using System;

namespace CapyFinPlan.Domain.Model.Modelos.Ativos
{
    public abstract class AtivoBase : Entidade
    {
        public AtivoBase(DateTime dataInvestimento, decimal valorAtivo, ETipoOperacao operacao)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsGreaterThan(dataInvestimento, DateTime.Today, nameof(DataInvestimento), "A Data de compra não pode ser superior a data Atual."),
                new Contract()
                .Requires()
                .IsLowerThan(valorAtivo, default, nameof(ValorAtivo), "Valor de compra não pode ser negativo."),
                new Contract()
                .Requires()
                .IsNull(operacao, nameof(Operacao), "Operação não pode estar em branco."));

            DataInvestimento = dataInvestimento;
            ValorAtivo = valorAtivo;
            Operacao = operacao;
        }

        public DateTime DataInvestimento { get; }
        public decimal ValorAtivo { get; set; }
        public ETipoOperacao Operacao { get; set; }
    }
}
