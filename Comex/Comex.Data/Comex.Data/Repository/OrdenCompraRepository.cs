using Comex.Core.Enum;
using Comex.Core.Interfaces;
using Comex.Core.Model.ComexAggregate;
using Common.Core.Enum;
using Common.Core.Extension;
using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Comex.Data.Repository
{
    public class OrdenCompraRepository : BaseRepository<ComexContext>, IOrdenCompraRepository
    {
        public OrdenCompraRepository(ComexContext context) : base(context)
        {
        }

        public Task<List<OrdenCompra>> BuscarAsync(int? idOrden, int? idSucursal, int? idSuplier, int? idEncargado, EstadoOrdenCompra? estado, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IQueryable<OrdenCompra> query = _context.OrdenCompra
                .Include(x => x.OrdenCompraItems)
                .Include(x => x.OrdenCompraItems.Select(y => y.Producto))
                .Include(x => x.Sucursal)
                .Include(x => x.Supplier)
                .Include(x => x.Encargado)
                .Where(x => DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value
                         && DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            if (idOrden.HasValue)
                query = query.Where(x => x.Id == idOrden);

            if (idSucursal.HasValue)
                query = query.Where(x => x.IdSucursal == idSucursal);

            if (idSuplier.HasValue)
                query = query.Where(x => x.IdSupplier == idSuplier);

            if (idEncargado.HasValue)
                query = query.Where(x => x.IdEncargado == idSuplier);

            if (estado.HasValue)
                query = query.Where(x => x.Estado == estado);


            return query.Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos)
                             .ToListAsync();
        }

        public Task GuardarAsync(OrdenCompra ordenCompra)
        {
            _context.AttachRecursive(ordenCompra);

            return _context.SaveChangesAsync();
        }
    }
}
