using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class SupplierRepository : BaseRepository<CommonContext>, ISupplierRepository
    {
        public SupplierRepository(CommonContext context) : base(context)
        {
        }

        public Task<List<Supplier>> Buscar(string nombre)
        {
            return _context.Supplier.Where(x => x.Nombre.Contains(nombre) && !x.Borrado).ToListAsync();
        }

        public Task Actualizar(Supplier supplier)
        {
            _context.AttachRecursive(supplier);
            return _context.SaveChangesAsync();
        }
    }
}
