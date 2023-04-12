using liberacaoCredito.Enums;

namespace liberacaoCredito.Entity
{
    public class LiberacaoCredito
    {
        public decimal ValorCredito { get; set; }
        public TipoCredito EnumTipoCredito { get; set; }
    }
}