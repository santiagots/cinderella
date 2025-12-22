using Common.Core.Enum;
using System;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ValueObjects;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Model.PresupuestoAgreggate
{
    public class PresupuestoItem : TransaccionItem
    {
        public long IdPresupuesto { get; private set; }
        public virtual Presupuesto Presupuesto { get; set; }
        public bool Borrado { get; private set; }

        internal PresupuestoItem() : base()
        {
        }

        public PresupuestoItem(long idPresupesuto, VentaItem ventaItem, decimal porcentajeFacturacion) : base(true)
        {
            IdPresupuesto = idPresupesuto;
            MontoProducto = new MontoProducto(calcularMonto(ventaItem.MontoProducto.Valor, ventaItem.PorcentajeBonificacion, porcentajeFacturacion), 0);
            Cantidad = ventaItem.Cantidad;
            PorcentajeBonificacion = ventaItem.PorcentajeBonificacion;
            IdProducto = ventaItem.IdProducto;
            Producto = ventaItem.Producto;
            EstadoEntidad = EstadoEntidad.Nuevo;
            FechaEdicion = DateTime.Now;
        }

        private decimal calcularMonto(decimal monto, decimal porcentajeBonificacion, decimal porcentajeFacturado)
        {
            return monto * (1 - porcentajeBonificacion) * (1 - porcentajeFacturado);
        }
    }
}
