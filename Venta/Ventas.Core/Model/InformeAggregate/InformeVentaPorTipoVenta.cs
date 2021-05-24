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
        public decimal Monto { get; internal set; }
        public int Cantidad { get; internal set; }

        protected InformeVentaPorTipoVenta() {}
    }
}
