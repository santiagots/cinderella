using System.Collections.Generic;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface IProductoRepository
    {
        Producto Obtener(int idSucursal, int idProducto);
        Producto ObtenerPorCodigo(int idSucursal, string Codigo);
        Producto ObtenerPorCodigoBarras(int idSucursal, string Codigo);
        IList<Producto> Obtener();
    }
}
