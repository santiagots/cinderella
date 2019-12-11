using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.InformeAggregate
{
    public class InformeVentaPorProducto
    {
        public int IdProducto { get; internal set; }
        public string Nombre { get; internal set; }
        public decimal MontoTotal { get; internal set; }
        public int CantidadTotal { get; internal set; }

        public InformeVentaPorProducto(string nombre, int idProducto, decimal montoTotal, int cantidadTotal)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            MontoTotal = montoTotal;
            CantidadTotal = cantidadTotal;
        }
    }
}
