using liberacaoCredito.Entity;

namespace liberacaoCredito.Repository
{
    public class LiberacaoRepository : ILiberacaoRepository
    {
        private int jurosMeses;
        
        private ResponseLiberacaoCredito CalculaCredito(RequestLiberacaoCredito request, int juros)
        {
            var response = new ResponseLiberacaoCredito();
            response.StatusCredito = "Apro";
            response.ValorJuros = request.ValorCredito * jurosMeses;
            response.ValorTotalCredito = request.ValorCredito + response.ValorJuros;
            return response;
        }
        public ResponseLiberacaoCredito CreditoConsignado(RequestLiberacaoCredito request)
        {
            jurosMeses = request.QtdParcelas * 2;
            return CalculaCredito(request, jurosMeses);
        }

        public ResponseLiberacaoCredito CreditoDireto(RequestLiberacaoCredito request)
        {
            jurosMeses = request.QtdParcelas * 2;
            return CalculaCredito(request, jurosMeses);
        }

        public ResponseLiberacaoCredito CreditoImobiliario(RequestLiberacaoCredito request)
        {
            jurosMeses = request.QtdParcelas * 10;
            return CalculaCredito(request, jurosMeses);
        }

        public ResponseLiberacaoCredito CreditoPF(RequestLiberacaoCredito request)
        {
            jurosMeses = request.QtdParcelas * 3;
            return CalculaCredito(request, jurosMeses);
        }

        public ResponseLiberacaoCredito CreditoPJ(RequestLiberacaoCredito request)
        {
            jurosMeses = request.QtdParcelas * 5;
            return CalculaCredito(request, jurosMeses);
        }
    }
}