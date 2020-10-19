using CalcRate.Business;
using CalcRate.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CalcRate.Controllers
{
    [ApiController]
    [Route("api2")]
    public class API2 : ControllerBase
    {
        [Route("v1/calculajuros")]
        [HttpGet]
        public ResultViewModel Index(string valorinicial, string tempo)
        {
            RateBusiness rateBn = new RateBusiness();

            //Validando o request
            double valorEntrada = rateBn.ValidarValorInicial(valorinicial);
            int meses = rateBn.ValidarTempo(tempo);

            if (valorEntrada == -1)
            {
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Favor digitar um valor inicial válido!",
                    Data = ""
                };
            }

            if (meses == -1)
            {
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Favor digitar um valor de tempo válido!",
                    Data = ""
                };
            }

            double result = rateBn.CalcularJurosCompostos(valorEntrada, meses);

            return new ResultViewModel
            {
                Success = true,
                Message = "Resultado do cálculo dos juros compostos!",
                Data = result
            };
        }

        [Route("v1/showmethecode")]
        [HttpGet]
        public ResultViewModel ShowMeTheCode()
        {
            return new ResultViewModel
            {
                Success = true,
                Message = "Endereço do repository no GitHub!",
                Data = "https://github.com/rasecdev/CalcRate/tree/master"
            };
        }
    }
}
