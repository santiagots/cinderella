using Common.Core.Enum;

namespace Factura.Device.Printer
{
    public class PagoPrinter
    {
        public TipoPago TipoPago { get; set; }
        public int NumeroCuotas { get; set; }
        public decimal Monto { get; set; }
        public decimal Descuento { get; set; }
        public decimal CFT { get; set; }
        public decimal IVA { get; set; }
        public decimal Neto(decimal porcentajeFacturacion) => (Monto - Descuento + CFT) * porcentajeFacturacion + IVA;

        public PagoPrinter(TipoPago tipoPago, int numeroCuotas, decimal monto, decimal descuento, decimal cft, decimal iva)
        {
            TipoPago = tipoPago;
            NumeroCuotas = numeroCuotas;
            Monto = monto;
            Descuento = descuento;
            CFT = cft;
            IVA= iva;
        }
    }
}
