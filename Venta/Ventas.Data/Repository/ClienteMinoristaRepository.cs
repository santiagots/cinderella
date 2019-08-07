using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Data.Repository
{
    public class ClienteMinoristaRepository : BaseRepository<VentaContext>, IClienteMinoristaRepository
    {
        public ClienteMinoristaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public IEnumerable<ClienteMinorista> Obtener(string nombre, string apellido)
        {
            IQueryable<ClienteMinorista> resultado = _context.ClienteMinorista;

            if (!String.IsNullOrEmpty(nombre))
                resultado = resultado.Where(x => x.Nombre.Contains(nombre));

            if (!String.IsNullOrEmpty(apellido))
                resultado = resultado.Where(x => x.Apellido.Contains(apellido));

            return resultado.ToList();
        }

        public void Guardar(ClienteMinorista clienteMinorista)
        {
            _context.ClienteMinorista.Add(clienteMinorista);
            _context.SaveChanges();
        }
    }
}
