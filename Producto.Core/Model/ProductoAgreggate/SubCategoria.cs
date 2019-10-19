using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.Core.Model.ProductoAgreggate
{
    public class SubCategoria : Entity<int>
    {
        public int IdCategoria { get; private set; }
        public Categoria Categoria { get; private set; }
        public string Descripcion { get; protected set; }
        public bool Habilitado { get; protected set; }

        internal SubCategoria()
        { }
    }
}
