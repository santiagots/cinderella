using Common.Core.Exceptions;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public class PagoDebito : Pago
    {
        public Banco Banco { get; private set; }

        public PagoDebito(Banco banco, MontoPago montoPago): base (montoPago)
        {
            if (montoPago.CFT > 0)
                throw new NegocioException("Error al crear el pago en debito. El CFT debe ser cero.");

            if (banco == null)
                throw new NegocioException("Error al crear el pago en debito. El banco no puede ser nulo.");

            Banco = banco;
        }
    }
}
