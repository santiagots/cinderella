using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.InformeAggregate
{
    public class InformeVentaPorTipoPago
    {
        public TipoPago TipoPago { get; internal set; }
        public TipoCliente TipoCliente { get; internal set; }
        public decimal MontoTotal { get; internal set; }
        public int CantidadCuotas { get; internal set; }
        public int CantidadTotal { get; internal set; }

        public InformeVentaPorTipoPago(TipoPago tipoPago, TipoCliente tipoCliente, int cantidadCuotas, decimal montoTotal, int cantidadTotal)
        {
            TipoPago = tipoPago;
            TipoCliente = tipoCliente;
            MontoTotal = montoTotal;
            CantidadCuotas = cantidadCuotas;
            CantidadTotal = cantidadTotal;
        }
    }
}
