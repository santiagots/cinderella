using Common.Core.Enum;
using Common.Core.Model;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Model.CuentaCorrienteAggregate
{
    public class DocumentoDePagoPago : Pago
    {
        public long IdDocumentoDePago { get; private set; }
        public virtual DocumentoDePago DocumentoDePago { get; private set; }

        protected DocumentoDePagoPago()
        {
        }

        public DocumentoDePagoPago(long idDocumentoDePago, TipoPago tipoPago, string tarjeta, int numeroCuotas, decimal porcentajeRecargo, decimal monto, decimal cft, int[] numeroOrdenCheques, CuentaBancaria cuentaBancaria, bool habilitado = true) :
            base(tipoPago, tarjeta, numeroCuotas, porcentajeRecargo, numeroOrdenCheques, cuentaBancaria, monto, 0, 0, cft, 0, habilitado)
        {
            IdDocumentoDePago = idDocumentoDePago;
        }
    }
}
