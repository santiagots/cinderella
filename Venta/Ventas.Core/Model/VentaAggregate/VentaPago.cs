using Common.Core.Enum;
using Common.Core.Model;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public class VentaPago : Pago
    {
        public long IdVenta { get; private set; }
        public virtual Venta Venta { get; private set; }

        protected VentaPago()
        {
        }

        public VentaPago(long idVenta, TipoPago tipoPago, string tarjeta, int numeroCuotas, decimal porcentajeRecargo, int[] numeroOrdenesCheques, CuentaBancaria cuentaBancaria, decimal monto, decimal montoRestante, decimal descuento, decimal cft, decimal iva, bool habilitado = true): 
            base(tipoPago, tarjeta, numeroCuotas, porcentajeRecargo, numeroOrdenesCheques, cuentaBancaria, monto, montoRestante, descuento, cft, iva, habilitado)
        {
            IdVenta = idVenta;
        }

        internal void Corregir()
        {
            MontoPago = new MontoPago(MontoPago.Monto - MontoRestante, MontoPago.Descuento, MontoPago.CFT, MontoPago.IVA);
            ActualizarMontoRestante(0);
        }

        internal void ActualizarIva(decimal iva)
        {
            MontoPago = new MontoPago(MontoPago.Monto, MontoPago.Descuento, MontoPago.CFT, iva);
        }
        internal void ActualizarDescuento(decimal descuento)
        {
            if (Habilitado)
                MontoPago = new MontoPago(MontoPago.Monto, descuento, MontoPago.CFT, MontoPago.IVA);
        }
        internal void ActualizarMontoRestante(decimal montoRestante)
        {
            MontoRestante = montoRestante;
        }
    }
}
