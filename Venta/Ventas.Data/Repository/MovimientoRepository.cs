using Common.Core.Enum;
using Common.Core.Extension;
using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.CuentaCorrienteAggregate;

namespace Ventas.Data.Repository
{
    public class MovimientoRepository : BaseRepository<VentaContext>, IMovimientoRepository
    {
        public MovimientoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task<List<Movimiento>> ObtenerMovimientosAsync(int idClienteMayorista, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            return _context.Movimiento
                           .Include(x => x.Sucursal)
                           .Where(x => x.IdClienteMayorista == idClienteMayorista &&
                                    DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                    DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value)
                           .Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos).ToListAsync();
        }

        public Task GuardarAsync(Movimiento movimiento)
        {
            _context.Movimiento.Add(movimiento);
            return _context.SaveChangesAsync();
        }
    }
}
