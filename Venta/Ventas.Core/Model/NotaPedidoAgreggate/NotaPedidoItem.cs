using Common.Core.Enum;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ValueObjects;

namespace Ventas.Core.Model.NotaPedidoAgreggate
{
    public class NotaPedidoItem : TransaccionItem
    {
        public long IdNotaPedido { get; private set; }
        public virtual NotaPedido NotaPedido { get; private set; }

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

        internal void AgregarIdNotaPedido(long idNotaPedido)
        {
            IdNotaPedido = idNotaPedido;
        }
    }
}
