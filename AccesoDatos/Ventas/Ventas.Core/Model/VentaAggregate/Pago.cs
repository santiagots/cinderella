using Common.Core.Exceptions;
using Common.Core.Model;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public abstract class Pago : Entity<long>
    {
        public MontoPago MontoPago { get; private set; }

        public Pago(MontoPago montoPago)
        {
            if (montoPago == null)
                throw new NegocioException("Error al crear el pago. El monto no puede ser nulo.");

            MontoPago = montoPago;
        }
    }
}
