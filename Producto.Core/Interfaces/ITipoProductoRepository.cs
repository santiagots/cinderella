using Producto.Core.Model.ProductoAgreggate;
using System.Collections.Generic;

namespace Producto.Core.Interfaces
{
    public interface ITipoProductoRepository
    {
        void Actualizar(TipoProducto tipoProducto);
        List<TipoProducto> Buscar(string nombre);
    }
}
