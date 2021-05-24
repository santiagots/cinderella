using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class DomicilioRepository : BaseRepository<CommonContext>, IDomicilioRepository
    {
        public DomicilioRepository(CommonContext commonContext) : base(commonContext)
        {
        }

        public Task<List<Provincia>> ObtenerProvinciaAsync()
        {
            return _context.Provincia.OrderBy(x => x.Descripcion).ToListAsync();
        }

        public Task<List<Distrito>> ObtenerDistritoAsync(int idProvincia)
        {
            return _context.Distrito.Where(x => x.IdProvincia == idProvincia).OrderBy(x => x.Descripcion).ToListAsync();
        }

        public Task<List<Localidad>> ObtenerLocalidadAsync(int idDepartamente)
        {
            return _context.Localidad.Where(x => x.IdDepartamente == idDepartamente).OrderBy(x => x.Descripcion).ToListAsync();
        }
    }
}
