using Common.Data.Repository;
using Producto.Core.Interfaces;
using Producto.Core.Model.ProductoAgreggate;
using System.Collections.Generic;
using System.Linq;

namespace Producto.Data.Repository
{
    public class SupplierRepository : BaseRepository<ProductoContext>, ISupplierRepository
    {
        public SupplierRepository(ProductoContext context) : base(context)
        {
        }

        public List<Supplier> Buscar(string nombre)
        {
            return _context.Supplier.Where(x => x.Nombre.Contains(nombre) && !x.Borrado).ToList();
        }

        public void Actualizar(Supplier supplier)
        {
            _context.AttachRecursive(supplier);
            _context.SaveChanges();
        }
    }
}
