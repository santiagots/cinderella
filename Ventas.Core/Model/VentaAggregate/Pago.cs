using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Helper;
using Common.Core.Model;
using System;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Pago : Entity<long>
    {
        public long IdVenta { get; private set; }
        public MontoPago MontoPago { get; private set; }
        public string Tarjeta { get; private set; }
        public int NumeroCuotas { get; private set; }
        public TipoPago TipoPago { get; private set; }
        public DateTime FechaEdicion { get; private set; }
        public virtual Venta Venta { get; private set; }

        protected Pago()
        {
        }

        public Pago(long idVenta, TipoPago tipoPago, string tarjeta, int numeroCuotas, decimal monto, decimal descuento, decimal cft, decimal iva): base(true)
        {
            if((tipoPago == TipoPago.TarjetaCredito || tipoPago == TipoPago.TarjetaDebito) && string.IsNullOrEmpty(tarjeta))
                    throw new NegocioException("Error al crear el pago. La trajeta no puede ser vacia.");

            if (tipoPago == TipoPago.TarjetaCredito && numeroCuotas == 0)
                throw new NegocioException("Error al crear el pago. La cantidad de cuotas debe ser mayor a cero.");

            IdVenta = IdVenta;
            TipoPago = tipoPago;
            MontoPago = new MontoPago(monto, descuento, cft, iva);
            Tarjeta = tarjeta;
            NumeroCuotas = numeroCuotas;
            FechaEdicion = DateTime.Now;
        }

        public override string ToString()
        {
            string formaPago = "";

            switch (TipoPago)
            {
                case TipoPago.Efectivo:
                    formaPago = "Efectivo";
                    break;
                case TipoPago.TarjetaCredito:
                    formaPago = $"{Tarjeta} ({NumeroCuotas})";
                    break;
                case TipoPago.TarjetaDebito:
                    formaPago = $"{Tarjeta}";
                    break;
                case TipoPago.Cheque:
                    formaPago = "Cheque";
                    break;
                case TipoPago.Deposito:
                    formaPago = "Deposito";
                    break;
                default:
                    throw new InvalidOperationException($"La forma de pago {TipoPago.ToString()} no implementa el metodo ToString().");
            }

            return formaPago;
        }
    }
}
