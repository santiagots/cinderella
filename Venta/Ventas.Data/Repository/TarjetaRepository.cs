using Common.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class TarjetaRepository : BaseRepository<VentaContext>, ITarjetaRepository
    {
        public TarjetaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public IEnumerable<Tarjeta> Obtener()
        {
            return _context.Tarjeta.Where(x => x.Habilitado && !x.Eliminado).ToList();
        }
    }
}
