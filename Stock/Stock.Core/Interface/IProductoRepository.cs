using Stock.Core.Model.BaseAgreggate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Core.Interface
{
    public interface IProductoRepository
    {
        Task<List<Producto>> ObtenerListaProductosAsync();
    }
}
