using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.ValueObjects
{
    public class TicketPago : ValueObjects<TicketPago>
    {
        public string Nombre { get; private set; }
        public decimal Monto { get; private set; }
        public decimal Descuento { get; private set; }
        public decimal Cft { get; private set; }
        public decimal Total { get { return Monto - Descuento + Cft; } }

        public TicketPago(string nombre, decimal monto, decimal descuento, decimal cft)
        {
            Nombre = nombre;
            Monto = monto;
            Descuento = descuento;
            Cft = cft;
        }

        protected override bool EqualsCore(TicketPago other)
        {
            return Total == other.Total &&
                Nombre == other.Nombre;
        }

        protected override int GetHashCodeCore()
        {
            return Total.GetHashCode();
        }
    }
}
