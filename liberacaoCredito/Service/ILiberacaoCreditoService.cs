using liberacaoCredito.Entity;
using System.Threading.Tasks;

namespace liberacaoCredito.Service
{
    public interface ILiberacaoCreditoService
    {        
        ResponseLiberacaoCredito LiberacaoCredito(RequestLiberacaoCredito request);
    }
}