using Common.Core.Enum;
using Common.Core.Model;
using System;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.BaseAgreggate
{
    public abstract class TransaccionItem : Entity<long>
    {
        public MontoProducto MontoProducto { get; internal set; }
        public int Cantidad { get; internal set; }
        public MontoProducto Total { get { return MontoProducto * Cantidad; } }
        public decimal PorcentajeBonificacion { get; internal set; }
        public int IdProducto { get; internal set; }
        public virtual Producto Producto { get; set; }
        public DateTime FechaEdicion { get; internal set; }

        internal TransaccionItem() : base()
        { }

        public TransaccionItem(bool GenerarId) : base(GenerarId)
        { }

        internal MontoProducto ObtenerMontoProducto(decimal monto, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            if (tipoCliente == TipoCliente.Minorista)
                return new MontoProducto(monto, 0);
            else
                return new MontoProducto(monto, monto * Producto.SubCategoria.IVA.Valor * porcentajeFacturacion);
        }

        internal void Actualizar(decimal monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            Cantidad = cantidad;
            PorcentajeBonificacion = porcentajeBonificacion;
            MontoProducto = ObtenerMontoProducto(monto, porcentajeFacturacion, tipoCliente);
        }

        internal void Actualizar(MontoProducto monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            Cantidad = cantidad;
            PorcentajeBonificacion = porcentajeBonificacion;
            MontoProducto = monto;
        }
    }
}
