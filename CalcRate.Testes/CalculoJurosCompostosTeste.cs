using CalcRate.Business;
using System;
using Xunit;

namespace CalcRate.Testes
{
    public class CalculoJurosCompostosTeste
    {
        private RateBusiness rateBn = new RateBusiness();
        [Fact]
        public void TesteGetTaxaBasica()
        {
            decimal result = rateBn.getTaxaBasica();
            Assert.Equal((decimal)0.01, result);
        }

        [Fact]
        public void TesteValidadorValorInicialComSucesso()
        {
            double result = rateBn.ValidarValorInicial("100,10");
            Assert.Equal(100.1, result);
        }

        [Fact]
        public void TesteValidadorValorInicialComErro()
        {
            double result = rateBn.ValidarValorInicial("Para gerar erro");
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TesteValidadorTempoComSucesso()
        {
            double result = rateBn.ValidarTempo("5");
            Assert.Equal(5, result);
        }

        [Fact]
        public void TesteValidadorTempoComErro()
        {
            double result = rateBn.ValidarTempo("Para gerar erro");
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TesteCalcularJurosCompostoComSucesso()
        {
            double result = rateBn.CalcularJurosCompostos(100, 5);
            Assert.Equal(105.10, result);
        }
    }
}
