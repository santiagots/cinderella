using Producto.Core.Model.ProductoAgreggate;
using System.Collections.Generic;

namespace Producto.Core.Interfaces
{
    public interface IProveedorRepository
    {
        IList<Proveedor> Obtener();
    }
}
