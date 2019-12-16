using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.InformeAggregate
{
    public class InformeVentaPorFecha
    {
        public DateTime Fecha { get; internal set; }
        public decimal Monto { get; internal set; }
        public int Cantidad { get; internal set; }

        protected InformeVentaPorFecha() {}
    }
}
