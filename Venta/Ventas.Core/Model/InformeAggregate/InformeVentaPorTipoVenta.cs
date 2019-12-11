using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.InformeAggregate
{
    public class InformeVentaPorTipoVenta
    {
        public TipoCliente TipoCliente { get; internal set; }
        public bool Facturado { get; internal set; }
        public decimal MontoTotal { get; internal set; }
        public int CantidadTotal { get; internal set; }

        public InformeVentaPorTipoVenta(TipoCliente tipoCliente,bool facturado, decimal montoTotal, int cantidadTotal)
        {
            TipoCliente = tipoCliente;
            Facturado = facturado;
            MontoTotal = montoTotal;
            CantidadTotal = cantidadTotal;
        }
    }
}
