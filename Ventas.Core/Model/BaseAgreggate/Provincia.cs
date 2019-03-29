using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.BaseAgreggate
{
    public class Provincia: Entity<int>
    {
        public string Descripcion { get; internal set; }
        public bool Habilitado { get; internal set; }
    }
}
