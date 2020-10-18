using CapyFinPlan.Domain.Model.Enum;

using Flunt.Validations;

using System;

namespace CapyFinPlan.Domain.Model.Modelos.Ativos.RendaVariavel
{
    public abstract class RendaVariavelBase : AtivoBase
    {
        public RendaVariavelBase(string codigo, DateTime dataCompra, decimal valorCompra, int quantidadeCompra, decimal custoCompra, ETipoOperacao operacao)
            : base(dataCompra, valorCompra, operacao)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace(Codigo, nameof(Codigo), "O Ticker não pode estar em branco."),
                new Contract()
                .Requires()
                .IsLowerOrEqualsThan(quantidadeCompra, default, nameof(Quantidade), "Quantidade de Compra não pode ser menor que zero."),
                new Contract()
                .Requires()
                .IsLowerOrEqualsThan(custoCompra, default, nameof(CustoCompra), "Custo de compra não pode ser negativa."));

            Codigo = codigo;
            Quantidade = quantidadeCompra;
            CustoCompra = custoCompra;
        }

        public string Codigo { get; }
        public int Quantidade { get; set; }
        public decimal CustoCompra { get; set; }

        public decimal ValorMedioAtivo => CalcularPrecoMedioAtivoConsiderandoCustos(Quantidade, ValorAtivo, CustoCompra);

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
