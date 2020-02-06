
using Common.Core.Enum;

namespace Factura.Service.Common.Contracts
{
    public class PagoRequest
    {
        public TipoPago TipoPago { get; set; }
        public int NumeroCuotas { get; set; }
        public decimal Monto { get; set; }
        public decimal Descuento { get; set; }
        public decimal CFT { get; set; }
        public decimal IVA { get; set; }
    }
}
