using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface IClienteMinoristaRepository
    {
        IEnumerable<ClienteMinorista> Obtener(string nombre, string apellido);
    }
}
