using System;

namespace liberacaoCredito.Entity
{
    public class RequestLiberacaoCredito
    {
        public decimal ValorCredito { get; set; }
        public string TipoCredito { get; set; }
        public int QtdParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
    }
}