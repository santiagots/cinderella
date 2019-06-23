using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.ValueObjects
{
    public class TicketProducto : ValueObjects<TicketProducto>
    {
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public int Cantidad { get; private set; }
        public decimal Monto { get; private set; }
        public decimal Total { get { return Cantidad * Monto;  } }

        public TicketProducto(string codigo, string nombre, int cantidad, decimal monto)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cantidad = cantidad;
            Monto = monto;
        }

        protected override bool EqualsCore(TicketProducto other)
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
