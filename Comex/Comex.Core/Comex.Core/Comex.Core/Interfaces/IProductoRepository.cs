using Comex.Core.Model.ComexAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Core.Interfaces
{
    public interface IProductoRepository
    {
        List<string> ObtenerNombreYCodigoDeProductos(int idSupplier);
        Task<Producto> BuscarProductoPorCodigoNombreBarras(int idSupplier, string codigo);
        Task<List<Producto>> BuscarProducto(int? idSupplier, int? idColor, int? idTipoProducto, int? cantidadLuces, string codigo);
    }
}
