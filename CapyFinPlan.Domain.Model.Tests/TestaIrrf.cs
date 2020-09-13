using CapyFinPlan.Domain.Model.Interfaces;
using CapyFinPlan.Domain.Model.Taxas.Investimentos;

using System;

using Xunit;

namespace CapyFinPlan.Domain.Model.Tests
{
    public class TestaIrrf
    {
        private readonly Irrf Impostos;
        public TestaIrrf()
        {
            Impostos = new Irrf();
        }

        [Fact]
        public void DeveRetornarErroQuandoDiasMenorQueZero()
        {
            Impostos.RetornarAliquota(-1);
            Assert.True(Impostos.Invalid);
        }

        [Fact]
        public void TestaAliquotaQuandoNumeroMenorCentoOitenta()
        {
            const int dias = 120;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(0.225, result);
        }

        [Fact]
        public void TestaAliquotaQuandoNumeroMaiorCentoOitentaMenorTrezentosSessenta()
        {
            const int dias = 350;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(0.20, result);
        }

        [Fact]
        public void TestaAliquotaQuandoNumeroMaiorTrezentosSessentaMenorSetecentosVinte()
        {
            const int dias = 700;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(0.175, result);
        }

        [Fact]
        public void TestaAliquotaQuandoNumeroMaiorSetecentosVinte()
        {
            const int dias = 780;

            var result = Impostos.RetornarAliquota(dias);

            Assert.Equal(0.15, result);
        }
    }
}
