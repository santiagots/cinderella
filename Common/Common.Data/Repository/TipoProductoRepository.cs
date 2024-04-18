using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class TipoProductoRepository : BaseRepository<CommonContext>, ITipoProductoRepository
    {
        public TipoProductoRepository(CommonContext context) : base(context)
        {
        }

        public Task Actualizar(TipoProducto tipoProducto)
        {
            _context.AttachRecursive(tipoProducto);
            return _context.SaveChangesAsync();
        }

        public Task<List<TipoProducto>> Buscar(string nombre)
        {
            return _context.TipoProducto.Where(x => x.Nombre.Contains(nombre) && !x.Borrado).ToListAsync();
        }
    }
}
