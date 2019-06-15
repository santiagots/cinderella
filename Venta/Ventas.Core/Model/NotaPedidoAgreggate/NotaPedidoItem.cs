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
    }
}
