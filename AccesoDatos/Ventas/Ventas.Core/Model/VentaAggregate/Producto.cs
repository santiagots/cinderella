using Common.Core.Model;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Producto : Entity<int>
    {
        public string Codigo { get; private set; }
        public string Nombre {get; private set; }
        public string Cantidad { get; private set; }

        public Producto(string nombre)
        {
            Nombre = nombre;
        }
    }
}
