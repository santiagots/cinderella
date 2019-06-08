using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.BaseAgreggate
{
    public class ClienteMinorista : Entity<int>
    {
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }
        public string Direccion { get; internal set; }
        public string Telefono { get; internal set; }
        public string Email { get; internal set; }
        public bool EnviarNovedades { get; internal set; }
        public string ApellidoYNombre { get { return $" {Apellido} {Nombre}"; } }

        internal ClienteMinorista()
        { }

        public ClienteMinorista(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}
