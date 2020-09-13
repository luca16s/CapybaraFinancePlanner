using Flunt.Validations;

using System;

namespace CapyFinPlan.Domain.Model.Modelos.Ativos
{
    public class AtivoBase : Entidade
    {
        public AtivoBase(string codigo, DateTime dataCompra, decimal valorCompra)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace(Codigo, nameof(Codigo), "O Ticker não pode estar em branco."),
                new Contract()
                .Requires()
                .IsGreaterThan(dataCompra, DateTime.Today, nameof(DataCompra), "A Data de compra não pode ser superior a data Atual."),
                new Contract()
                .Requires()
                .IsLowerThan(valorCompra, default, nameof(ValorCompra), "Valor de compra não pode ser negativo."));

            Codigo = codigo;
            DataCompra = dataCompra;
            ValorCompra = valorCompra;
        }

        public string Codigo { get; }
        public DateTime DataCompra { get; }
        public decimal ValorCompra { get; set; }

        public decimal CalcularPrecoMedioAtivoConsiderandoCustos(int quantidadeComprada, decimal valorCompra, decimal custoCompra)
        {
            return CalcularPrecoMedioAtivo(quantidadeComprada, valorCompra + custoCompra);
        }

        public decimal CalcularPrecoMedioAtivo(int quantidade, decimal valorCompra)
        {
            return quantidade * valorCompra;
        }
    }
}
