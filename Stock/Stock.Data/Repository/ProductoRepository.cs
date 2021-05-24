using Common.Data.Repository;
using Stock.Core.Interface;
using Stock.Core.Model.BaseAgreggate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Stock.Data.Repository
{
    public class ProductoRepository : BaseRepository<StockContext>, IProductoRepository
    {
        public ProductoRepository(StockContext stockContext) : base(stockContext)
        {
        }

        public Task<List<Producto>> ObtenerListaProductosAsync()
        {
            return _context.Producto.ToListAsync();
        }

        public Task<List<Producto>> Obtener()
        {
            return _context.Producto.ToListAsync();
        }
    }
}
