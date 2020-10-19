using CalcRate.Business;
using CalcRate.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CalcRate.Controllers
{
    [ApiController]
    [Route("api1")]
    public class API1 : ControllerBase
    {
        [HttpGet]
        [Route("v1/taxaJuros")]
        public ResultViewModel taxaJuros()
        {
            RateBusiness rateBn = new RateBusiness();

            return new ResultViewModel
            {
                Success = true,
                Message = "Valor da taxa base de juros!",
                Data = rateBn.getTaxaBasica()
            };
        }
    }
}
