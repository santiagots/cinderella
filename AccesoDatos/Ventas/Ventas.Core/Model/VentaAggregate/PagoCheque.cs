using Common.Core.Exceptions;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public class PagoCheque : Pago
    {
        public PagoCheque(MontoPago montoPago) : base(montoPago)
        {
            if (montoPago.CFT > 0)
                throw new NegocioException("Error al crear el pago en cheque. El CFT debe ser cero.");
        }
    }
}
