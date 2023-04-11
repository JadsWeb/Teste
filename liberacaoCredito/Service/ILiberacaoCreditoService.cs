using liberacaoCredito.Entity;
using System.Threading.Tasks;

namespace liberacaoCredito.Service
{
    public interface ILiberacaoCreditoService
    {
        Task<ResponseLiberacaoCredito> CreditoDireto(RequestLiberacaoCredito request);
        Task<ResponseLiberacaoCredito> CreditoConsignado(RequestLiberacaoCredito request);
        Task<ResponseLiberacaoCredito> CreditoPJ(RequestLiberacaoCredito request);
        Task<ResponseLiberacaoCredito> CreditoPF(RequestLiberacaoCredito request);
        Task<ResponseLiberacaoCredito> CreditoImobiliario(RequestLiberacaoCredito request);
        Task<ResponseLiberacaoCredito> LiberacaoCredito(RequestLiberacaoCredito request);
    }
}