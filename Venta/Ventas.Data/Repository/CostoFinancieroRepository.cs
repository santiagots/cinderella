using Common.Data.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class CostoFinancieroRepository : BaseRepository<VentaContext>, ICostoFinancieroRepository
    {
        public CostoFinancieroRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task<List<CostoFinanciero>> Obtener(int idTarjeta)
        {
            return _context.CostoFinanciero.Where(x => x.IdTarjeta == idTarjeta).ToListAsync();
        }
    }
}
