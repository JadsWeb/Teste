using System;
using System.Threading.Tasks;
using liberacaoCredito.Entity;
using liberacaoCredito.Service;
using Microsoft.AspNetCore.Mvc;

namespace liberacaoCredito.Controllers
{
    [ApiController]
    public class LiberacaoCreditoController : ControllerBase
    {

        private readonly ILiberacaoCreditoService _liberacaoCreditoService;

        public LiberacaoCreditoController(ILiberacaoCreditoService liberacaoService)
        {
            _liberacaoCreditoService = liberacaoService;
        }
        
        [HttpPost]
        [Route("liberacaoCredito")]
        public async Task<ActionResult<ResponseLiberacaoCredito>> LiberacaoCredito([FromBody]RequestLiberacaoCredito request)
        {
            if(request.ValorCredito <= 0)
                return NotFound(new {message = "Valor do crédito inválido."});
            if(request.ValorCredito > 1000000)
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});
            if(request.QtdParcelas < 5 || request.QtdParcelas > 72)
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});
            if(request.EnumTipoCredito == Enums.TipoCredito.CreditoPJ && request.ValorCredito < 15000)
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});
            if((DateTime.Now.Day + 15) < request.DataPrimeiroVencimento.Day)
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});
            if((DateTime.Now.Day  + 40) < request.DataPrimeiroVencimento.Day)
                return NotFound(new ResponseLiberacaoCredito(){StatusCredito = "Crédito recusado"});

            return Ok( _liberacaoCreditoService.LiberacaoCredito(request));
        }
    }
}
