using Common.Core.Model;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Banco: Entity<int>
    {
        public string Nombre { get; private set; }

        public Banco(string nombre)
        {
            Nombre = nombre;
        }
    }
}
