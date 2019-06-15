using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IProductoRepository
    {
        Producto Obtener(int idSucursal, int idProducto);
        IList<Producto> Obtener();
    }
}
