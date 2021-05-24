using Common.Core.Model;

namespace Ventas.Core.Model.BaseAgreggate
{
    public class Precio : Entity<int>
    {
        public Producto Producto { get; private set; }
        public int IdProducto { get; private set; }
        public int IdLista { get; private set; }
        public decimal Monto { get; private set; }
        public bool Habilitado { get; private set; }

        protected Precio()
        {
        }
    }
}
