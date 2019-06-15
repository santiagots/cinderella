using Common.Core.Model;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Tarjeta : Entity<int>
    {
        public string Nombre { get; private set; }
        public bool Habilitado { get; private set; }

        protected Tarjeta()
        {
        }

        public Tarjeta(int id, string nombre, bool habilitado)
        {
            Id = id;
            Nombre = nombre;
            Habilitado = habilitado;
        }
    }
}
