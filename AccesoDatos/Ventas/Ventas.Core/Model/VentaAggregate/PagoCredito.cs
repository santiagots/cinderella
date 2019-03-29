using Ventas.Core.Model.ValueObjects;
using Common.Core.Exceptions;

namespace Ventas.Core.Model.VentaAggregate
{
    public class PagoCredito : Pago
    {
        public Banco Banco { get; private set; }
        public int CantidadCuotas { get; private set; }

        public PagoCredito(Banco banco, int cantidadCuotas, MontoPago montoPago): base (montoPago)
        {
            if (banco == null)
                throw new NegocioException("Error al crear el pago en crédito. El banco no puede ser nulo.");

            if (cantidadCuotas > 0)
                throw new NegocioException("Error al crear el pago en crédito. La cantidad de cuotas debe ser mayor a cero.");

            Banco = banco;
            CantidadCuotas = cantidadCuotas;
        }
    }
}
