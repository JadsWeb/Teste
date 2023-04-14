using System.Threading.Tasks;
using liberacaoCredito.Entity;
using liberacaoCredito.Enums;
using liberacaoCredito.Repository;

namespace liberacaoCredito.Service
{
    public class LiberacaoCreditoService : ILiberacaoCreditoService
    {
        
        private readonly ILiberacaoRepository _liberacaoRepository;

        public LiberacaoCreditoService(ILiberacaoRepository liberacaoRepository)
        {
            _liberacaoRepository = liberacaoRepository;
        }
        private ResponseLiberacaoCredito CreditoConsignado(RequestLiberacaoCredito request)
        {
            return _liberacaoRepository.CreditoConsignado(request);
        }

        private ResponseLiberacaoCredito CreditoDireto(RequestLiberacaoCredito request)
        {
            return _liberacaoRepository.CreditoDireto(request);
        }

        private ResponseLiberacaoCredito CreditoImobiliario(RequestLiberacaoCredito request)
        {
            return _liberacaoRepository.CreditoImobiliario(request);
        }

        private ResponseLiberacaoCredito CreditoPF(RequestLiberacaoCredito request)
        {
            return _liberacaoRepository.CreditoPF(request);
        }

        private ResponseLiberacaoCredito CreditoPJ(RequestLiberacaoCredito request)
        {
            return _liberacaoRepository.CreditoPJ(request);
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