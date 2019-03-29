using Common.Core.Exceptions;
using Common.Core.Model;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Venta: Entity<long>
    {
        public IList<Pago> Pagos { get; protected set; }
        public IList<VentaItem> VentaItems { get; protected set; }
        public int CantidadTotal { get; private set; }
        public MontoProducto MontoTotal { get; private set; }
        public MontoPago PagoTotal { get; private set; }
        public bool EstaPaga { get { return !VentaItems.Any(x => x.PorcentajePago != 1); } }

        public Venta()
        {
            VentaItems = new List<VentaItem>();
            Pagos = new List<Pago>();
        }

        public void AgregaVentaItem(VentaItem ventaItem)
        {
            VentaItems.Add(ventaItem);
            ActualizarTotalesVenta();
        }

        public void AgregaPago(Pago pago)
        {
            if (VentaItems.Count == 0)
                throw new NegocioException("Error al registrar el pago. No se encuentran productos registrados en la venta.");
            if (EstaPaga)
                throw new NegocioException("Error al registrar el pago. La venta ya cuenta con el/los pagos necesarios para ser finalizada.");

            decimal montoPago = pago.MontoPago.Total;

            foreach (VentaItem ventaItem in VentaItems.Where(x => x.PorcentajePago != 1))
            {
                montoPago = ventaItem.Pagar(montoPago);
            }

            Pagos.Add(pago);
            ActualizarTotalesPago();
        }

        public void QuitarVentaItem(VentaItem ventaItem)
        {
            VentaItems.Remove(ventaItem);
            ActualizarTotalesVenta();
        }

        public void QuitarPago(Pago pago)
        {
            Pagos.Remove(pago);
            ActualizarTotalesPago();
        }

        public MontoProducto ObtenerPendientePago()
        {
            if (EstaPaga)
                return new MontoProducto(0, 0);

            return VentaItems.Select(x => x.ObtenerPendientePago()).Aggregate((x, y) => x + y);
        }

        private void ActualizarTotalesVenta()
        {
            if (VentaItems.Count == 0)
            {
                CantidadTotal = 0;
                MontoTotal = new MontoProducto(0, 0);
            }
            else
            {
                CantidadTotal = VentaItems.Sum(x => x.Costo.Cantidad);
                MontoTotal = VentaItems.Select(x => x.Costo.MontoProducto).Aggregate((x, y) => x + y);
            }
        }

        private void ActualizarTotalesPago()
        {
            PagoTotal = Pagos.Select(x => x.MontoPago).Aggregate((x, y) => x + y);
        }
    }
}
