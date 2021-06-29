using Common.Core.Enum;
using Common.Data.Repository;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.RemitoAgreggate;

namespace Ventas.Data.Repository
{
    public class RemitoRepository : BaseRepository<VentaContext>, IRemitoRepository
    {
        public RemitoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task GuardarAsync(Remito remito)
        {
            _context.AttachRecursive(remito);
            return _context.SaveChangesAsync();
        }

        public Task<Remito> ObtenerAsync(long idRemito)
        {
            return _context.Remito
                .Include(x => x.RemitoItems)
                .Where(x => x.Id == idRemito).FirstOrDefaultAsync();
        }

        public Task<Remito> ObtenerPorVentaAsync(long idVenta)
        {
            return _context.Remito
                .Include(x => x.RemitoItems)
                .Where(x => x.IdVenta == idVenta).FirstOrDefaultAsync();
        }
    }
}
