using CapyFinPlan.Domain.Model.Enum;
using CapyFinPlan.Domain.Model.Modelos.Ativos.RendaVariavel;

using System;

using Xunit;

namespace CapyFinPlan.Domain.Model.Tests
{
    public class TestaFundosImobiliarios
    {
        private readonly FundoImobiliario fundoImobiliario;

        public TestaFundosImobiliarios()
        {
            fundoImobiliario = new FundoImobiliario(null, DateTime.Now, default, default, default, ETipoOperacao.Compra);
        }

        [Fact]
        public void DeveRetornarErroQuandoCalculoPrecoMedioComCustoCalculadoErrado()
        {
            var valorCompra = 150.5m;
            var quantidade = 8;
            var resultadoEsperado = 1304m;

            var resultado = fundoImobiliario.CalcularPrecoMedioAtivo(quantidade, valorCompra);

            Assert.NotEqual(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveRetornarPositivoQuandoCalculoPrecoMedioComCustoCalculadoCorreto()
        {
            var valorCompra = 150.5m;
            var quantidade = 8;
            var resultadoEsperado = 1204m;

            var resultado = fundoImobiliario.CalcularPrecoMedioAtivo(quantidade, valorCompra);

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
