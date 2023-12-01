using Producto.Core.Model.ProductoAgreggate;
using System.Collections.Generic;

namespace Producto.Core.Interfaces
{
    public interface ISupplierRepository
    {
        List<Supplier> Buscar(string nombre);
        void Actualizar(Supplier supplier);
    }
}
