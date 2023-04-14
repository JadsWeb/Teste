using liberacaoCredito.Entity;

namespace liberacaoCredito.Repository
{
    public interface ILiberacaoRepository
    {
        ResponseLiberacaoCredito CreditoConsignado(RequestLiberacaoCredito request);
        ResponseLiberacaoCredito CreditoDireto(RequestLiberacaoCredito request);
        ResponseLiberacaoCredito CreditoImobiliario(RequestLiberacaoCredito request);
        ResponseLiberacaoCredito CreditoPF(RequestLiberacaoCredito request);
        ResponseLiberacaoCredito CreditoPJ(RequestLiberacaoCredito request);
    }
}