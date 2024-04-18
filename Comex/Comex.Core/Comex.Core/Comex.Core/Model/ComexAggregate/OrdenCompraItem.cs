using Common.Core.Model;

namespace Comex.Core.Model.ComexAggregate
{
    public class OrdenCompraItem : Entity<int>
    {
        public int IdOrdenCompra { get; private set; }
        public virtual OrdenCompra OrdenCompra { get; private set; }
        public int IdProducto { get; protected set; }
        public virtual Producto Producto { get; protected set; }
        public int CantidadCajas { get; protected set; }
        public int TotalPCS => Producto.Packing * CantidadCajas;
        public int TotalCBM => Producto.UCBM * CantidadCajas;
        public decimal TotalUSD => Producto.FOBUSD * CantidadCajas;
        public decimal TotalRMB => Producto.FOBRMB * CantidadCajas;

        internal OrdenCompraItem()
        {
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Modificado;
        }

        public OrdenCompraItem(int idOrdenCompra, Producto producto, int cantidadCajas) : base(false)
        {
            IdOrdenCompra = idOrdenCompra;
            IdProducto = producto.Id;
            Producto = producto;
            CantidadCajas = cantidadCajas;
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Nuevo;
        }

        internal void Actualizar(int cantidadCajas)
        {
            CantidadCajas = cantidadCajas;
        }
    }
}
