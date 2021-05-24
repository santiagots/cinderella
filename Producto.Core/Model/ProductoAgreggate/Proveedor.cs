using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.Core.Model.ProductoAgreggate
{
    public class Proveedor : Entity<int>
    {
        public string RazonSocial { get; protected set; }
        public bool Habilitado { get; protected set; }
    }
}
