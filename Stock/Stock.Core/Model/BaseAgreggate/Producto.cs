using Common.Core.Model;
using System.Collections.Generic;

namespace Stock.Core.Model.BaseAgreggate
{
    public class Producto : Entity<int>
    {
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public decimal Costo { get; protected set; }
        public int? IdCategoria { get; protected set; }
        public Categoria Categoria { get; protected set; }
        public List<NotaPedidoItem> NotaPedidoItems { get; protected set; }
    }
}
