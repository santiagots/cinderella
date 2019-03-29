using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.BaseAgreggate
{
    public class Domicilio : Entity<int>
    {
        public string Direccion { get; internal set; }
        public int IdProvincia { get; internal set; }
        public Provincia Provincia { get; internal set; }
        public int IdDistrito { get; internal set; }
        public Distrito Distrito { get; internal set; }
        public int IdLocalidad { get; internal set; }
        public Localidad Localidad { get; internal set; }
        public string Telefono { get; internal set; }
        public string Email { get; internal set; }

    }
}
