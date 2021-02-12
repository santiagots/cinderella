using Common.Core.Enum;
using System;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.NotaPedidoAgreggate
{
    public class NotaPedidoItem : TransaccionItem
    {
        public long IdNotaPedido { get; private set; }
        public virtual NotaPedido NotaPedido { get; set; }
        public bool Borrado { get; private set; }

        public NotaPedidoItem() : base()
        {
        }

        internal NotaPedidoItem(long idNotaPedido, Producto producto, decimal monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente) : base(true)
        {
            IdNotaPedido = idNotaPedido;
            IdProducto = producto.Id;
            Producto = producto;
            MontoProducto = ObtenerMontoProducto(monto, porcentajeFacturacion, tipoCliente);
            PorcentajeBonificacion = porcentajeBonificacion;
            Cantidad = cantidad;
            FechaEdicion = DateTime.Now;
        }

        internal NotaPedidoItem(long idNotaPedido, Producto producto, MontoProducto monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente) : base(true)
        {
            IdNotaPedido = idNotaPedido;
            IdProducto = producto.Id;
            Producto = producto;
            MontoProducto = monto;
            PorcentajeBonificacion = porcentajeBonificacion;
            Cantidad = cantidad;
            FechaEdicion = DateTime.Now;
        }

        internal void AgregarIdNotaPedido(long idNotaPedido)
        {
            IdNotaPedido = idNotaPedido;
        }

        internal void Borrar() => Borrado = true;
    }
}
