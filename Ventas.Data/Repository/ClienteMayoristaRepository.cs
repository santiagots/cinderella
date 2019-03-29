using System.Linq;
using Ventas.Core.Interfaces;
using System.Data.Entity;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Data.Repository
{
    public class ClienteMayoristaRepository : BaseRepository, IClienteMayoristaRepository
    {
        public ClienteMayoristaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public ClienteMayorista Obtener(int id)
        {
            return _context.ClienteMayorista
                        .Include(x => x.DomicilioFacturacion)
                        .Include(x => x.DomicilioFacturacion.Localidad)
                        .Include(x => x.DomicilioFacturacion.Provincia)
                        .Include(x => x.DomicilioFacturacion.Distrito)
                        .FirstOrDefault(x => x.Id == id);
        }
    }
}
