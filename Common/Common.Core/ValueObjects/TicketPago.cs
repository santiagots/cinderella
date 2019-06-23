using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.ValueObjects
{
    public class TicketPago : ValueObjects<TicketPago>
    {
        public TipoPago TipoPago { get; private set; }
        public decimal Monto { get; private set; }
        public decimal Descuento { get; private set; }
        public decimal Cft { get; private set; }
        public int NumeroCuotas { get; private set; }
        public decimal Total { get { return Monto - Descuento + Cft; } }

        public TicketPago(TipoPago tipoPago, decimal monto, decimal descuento, decimal cft, int numeroCuotas)
        {
            TipoPago = tipoPago;
            Monto = monto;
            Descuento = descuento;
            Cft = cft;
            NumeroCuotas = numeroCuotas;
        }

        protected override bool EqualsCore(TicketPago other)
        {
            return Total == other.Total &&
                TipoPago == other.TipoPago;
        }

        protected override int GetHashCodeCore()
        {
            return Total.GetHashCode();
        }
    }
}
