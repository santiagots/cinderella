using Common.Core.Enum;
using Common.Core.Extension;
using Common.Data.Repository;
using Stock.Core.Interface;
using Stock.Core.Model.BaseAgreggate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace Stock.Data.Repository
{
    public class BitacoraRepository : BaseRepository<StockContext>, IBitacoraRepository
    {
        public BitacoraRepository(StockContext stockContext) : base(stockContext)
        {
        }

        public Task<List<Bitacora>> BuscarAsync(int idSucursal, DateTime? fechaDesde, DateTime? fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IQueryable<Bitacora> stocks = _context.Bitacora
                                            .IncludeOptimized(x => x.Producto)
                                            .IncludeOptimized(x => x.Usuario)
                                            .Where(x => x.IdSucursal == idSucursal);

            if (fechaDesde.HasValue)
                stocks = stocks.Where(x => DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value);

            if (fechaHasta.HasValue)
                stocks = stocks.Where(x => DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            return stocks.Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos).ToListAsync();
        }

        public Task<decimal?> TotalAsync(int idSucursal, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            IQueryable<Bitacora> stocks = _context.Bitacora
                                            .IncludeOptimized(x => x.Producto)
                                            .Where(x => x.IdSucursal == idSucursal);

            if (fechaDesde.HasValue)
                stocks = stocks.Where(x => DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value);

            if (fechaHasta.HasValue)
                stocks = stocks.Where(x => DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            return stocks.SumAsync(x => (decimal?)(x.StockActual - x.StockActualAnterior) * x.Producto.Costo);
        }
    }
}
