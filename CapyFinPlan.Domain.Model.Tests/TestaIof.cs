using CapyFinPlan.Domain.Model.Interfaces;
using CapyFinPlan.Domain.Model.Taxas.Investimentos;

using System;

using Xunit;

namespace CapyFinPlan.Domain.Model.Tests
{
    public class TestaIof
    {
        private readonly IImpostos Impostos;
        public TestaIof()
        {
            Impostos = new Iof();
        }

        [Fact]
        public void TestaQuantidadeDeDiasNegativos()
        {
            Assert.Throws<Exception>(() => Impostos.RetornarAliquota(-1));
        }

        [Fact]
        public void TestaComQuantidadeDiasMaiorTrinta()
        {
            const int dias = 31;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(default, result);
        }

        [Fact]
        public void TestaComQuantidadeDiasIgualZero()
        {
            const int dias = 0;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(default, result);
        }

        [Fact]
        public void TestaComQuantidadeDiasIgualUm()
        {
            const int dias = 1;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(0.96, result);
        }

        [Fact]
        public void TestaComQuantidadeDiasIgualTrinta()
        {
            const int dias = 30;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(default, result);
        }

        [Fact]
        public void TestaComQuantidadeDiasIgualVinteNove()
        {
            const int dias = 29;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(0.03, result);
        }
    }
}
