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
            return Ok( await _liberacaoCreditoService.CreditoDireto(request));
        }
    }
}
