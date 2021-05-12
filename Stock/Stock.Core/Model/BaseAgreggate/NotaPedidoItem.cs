using Common.Core.Model;

namespace Stock.Core.Model.BaseAgreggate
{
    public class NotaPedidoItem : Entity<long>
    {
        public int Cantidad { get; internal set; }
        public int? IdProducto { get; internal set; }
        public Producto Producto { get; internal set; }
        public long IdNotaPedido { get; internal set; }
        public NotaPedido NotaPedido { get; internal set; }
        public bool Borrado { get; internal set; }
    }
}
