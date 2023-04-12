using System;
using liberacaoCredito.Enums;

namespace liberacaoCredito.Entity
{
    public class RequestLiberacaoCredito
    {
        public decimal ValorCredito { get; set; }
        public TipoCredito EnumTipoCredito  { get; set; }
        public int QtdParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
    }
}