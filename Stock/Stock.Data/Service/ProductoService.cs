using Stock.Core.Interface;
using Stock.Core.Model.BaseAgreggate;
using Stock.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Data.Service
{
    public class ProductoService
    {
        public static Task<List<Producto>> ObtenerListaProductosAsync()
        {
            IProductoRepository productoRepository = new ProductoRepository(new StockContext());
            return productoRepository.ObtenerListaProductosAsync();
        }
    }
}
