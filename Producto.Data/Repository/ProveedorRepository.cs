using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using Producto.Core.Interfaces;
using Modelo = Producto.Core.Model.ProductoAgreggate;
using Common.Data.Repository;

namespace Producto.Data.Repository
{
    public class ProveedorRepository : BaseRepository<ProductoContext>, IProveedorRepository
    {
        public ProveedorRepository(ProductoContext productoContext) : base(productoContext)
        {
        }

        public IList<Modelo.Proveedor> Obtener()
        {
            return _context.Proveedor.Where(x => x.Habilitado).OrderBy(x => x.RazonSocial).ToList();
        }
    }
}
