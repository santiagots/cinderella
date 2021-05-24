using Common.Data.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class TarjetaRepository : BaseRepository<VentaContext>, ITarjetaRepository
    {
        public TarjetaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task<List<Tarjeta>> Obtener()
        {
            return _context.Tarjeta.Where(x => x.Habilitado && !x.Eliminado).ToListAsync();
        }
    }
}
