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
        public decimal MontoTotal { get; internal set; }
        public int CantidadTotal { get; internal set; }

        public InformeVentaPorFecha(DateTime fecha, decimal montoTotal, int cantidadTotal)
        {
            Fecha = fecha;
            MontoTotal = montoTotal;
            CantidadTotal = cantidadTotal;
        }
    }
}
