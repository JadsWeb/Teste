using System.Threading.Tasks;
using liberacaoCredito.Entity;
using liberacaoCredito.Enums;

namespace liberacaoCredito.Service
{
    public class LiberacaoCreditoService : ILiberacaoCreditoService
    {
        private ResponseLiberacaoCredito CreditoConsignado(RequestLiberacaoCredito request)
        {
            throw new System.NotImplementedException();
        }

        private ResponseLiberacaoCredito CreditoDireto(RequestLiberacaoCredito request)
        {
            throw new System.NotImplementedException();
        }

        private ResponseLiberacaoCredito CreditoImobiliario(RequestLiberacaoCredito request)
        {
            throw new System.NotImplementedException();
        }

        private ResponseLiberacaoCredito CreditoPF(RequestLiberacaoCredito request)
        {
            throw new System.NotImplementedException();
        }

        private ResponseLiberacaoCredito CreditoPJ(RequestLiberacaoCredito request)
        {
            throw new System.NotImplementedException();
        }

        public ResponseLiberacaoCredito LiberacaoCredito(RequestLiberacaoCredito request)
        {
            var response = new ResponseLiberacaoCredito();
            switch(request.EnumTipoCredito)
            {
                case TipoCredito.CreditoDireto:
                    response = CreditoDireto(request);
                    break;
                case TipoCredito.CreditoConsignado:
                    response = CreditoConsignado(request);
                    break;
                case TipoCredito.CreditoPJ:
                    response = CreditoPJ(request);
                    break;
                case TipoCredito.CreditoPF:
                    response = CreditoPF(request);
                    break;
                case TipoCredito.CreditoImobiliario:
                    response = CreditoImobiliario(request);
                    break;
            }
            return response;
        }
    }
}