using CalcRate.Models;
using System;

namespace CalcRate.Business
{
    public class RateBusiness
    {
        private Rate Rate;

        public RateBusiness()
        {
            Rate = new Rate();
        }

        public decimal getTaxaBasica()
        {
            return this.Rate.TaxaBasica;
        }

        public double CalcularJurosCompostos(double valorInicial, int tempo)
        {
            // Calculo de juros compostos
            // Formula: PMT = PV. ((1 + i) ^ n)

            // resultado
            double result = 0;

            result = valorInicial * Math.Pow((1 + (double) this.Rate.TaxaBasica), tempo);

            return Math.Round(result, 2);
        }

        public double ValidarValorInicial(string valorInicial)
        {
            double result = 0;

            if (!double.TryParse(valorInicial, out result))
            {
                result = -1;
            }

            return result;
        }

        public int ValidarTempo(string tempo)
        {
            int result = 0;

            if (!int.TryParse(tempo, out result))
            {
                result = -1;
            }

            return result;
        }
    }
}
