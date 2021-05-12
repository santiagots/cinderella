using Common.Core.Enum;
using Common.Core.Model;

namespace Stock.Core.Model.BaseAgreggate
{
    public class NotaPedido : Entity<long>
    {
        public NotaPedidoEstado Estado { get; protected set; }
        public bool Borrado { get; internal set; }
    }
}
