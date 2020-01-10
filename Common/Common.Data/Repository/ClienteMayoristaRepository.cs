using System.Linq;
using System.Data.Entity;
using Common.Core.Interfaces;
using Common.Core.Model;

namespace Common.Data.Repository
{
    public class ClienteMayoristaRepository : BaseRepository<CommonContext>, IClienteMayoristaRepository
    {
        public ClienteMayoristaRepository(CommonContext commonContext) : base(commonContext)
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
