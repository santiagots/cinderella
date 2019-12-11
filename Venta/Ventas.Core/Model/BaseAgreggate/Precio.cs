using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.ValueObjects;
using Common.Core.Enum;
using Common.Core.Constants;

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
