using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.VentaAggregate
{
    public class ListaPrecio: Entity<int>
    {
        public string Nombre { get; private set; }
        public int IdGrupo { get; private set; }
        public string Grupo { get; private set; }
    }
}
