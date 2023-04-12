using System.Threading.Tasks;
using liberacaoCredito.Entity;
using liberacaoCredito.Service;
using Microsoft.AspNetCore.Mvc;

namespace liberacaoCredito.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LiberacaoCreditoController : ControllerBase
    {

        private readonly ILiberacaoCreditoService _liberacaoCreditoService;

        public LiberacaoCreditoController(ILiberacaoCreditoService liberacaoService)
        {
            _liberacaoCreditoService = liberacaoService;
        }
        
        [HttpPost]
        [Route("LiberacaoCredito")]
        public async Task<ActionResult<ResponseLiberacaoCredito>> LiberacaoCredito([FromBody]RequestLiberacaoCredito request)
        {
            if(request.ValorCredito > 1000000)
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});
            if(request.QtdParcelas < 5 || request.QtdParcelas > 72)
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});
            if(request.EnumTipoCredito == Enums.TipoCredito.CreditoPJ && request.ValorCredito < 15000)
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});
            if(request.DataPrimeiroVencimento.Day < (request.DataPrimeiroVencimento.Day + 15))
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});
            if(request.DataPrimeiroVencimento.Day > (request.DataPrimeiroVencimento.Day + 40))
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});

            return Ok( _liberacaoCreditoService.LiberacaoCredito(request));
        }
    }
}
