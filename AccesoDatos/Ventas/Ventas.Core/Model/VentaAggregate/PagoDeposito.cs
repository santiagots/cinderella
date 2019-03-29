using Common.Core.Exceptions;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public class PagoDeposito : Pago
    {
        public PagoDeposito(MontoPago montoPago) : base(montoPago)
        {
            if(montoPago.CFT > 0)
                throw new NegocioException("Error al crear el deposito. El CFT debe ser cero.");
        }
    }
}
