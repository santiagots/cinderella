using Common.Core.Model;

namespace Comex.Core.Model.ComexAggregate
{
    public class Sucursal : Entity<int>
    {
        public string Nombre { get; private set; }
        public string CodigoVenta { get; private set; }
    }
}
