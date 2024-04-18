using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class ColorRepository : BaseRepository<CommonContext>, IColorRepository
    {
        public ColorRepository(CommonContext context) : base(context)
        {
        }

        public Task Actualizar(Color color)
        {
            _context.AttachRecursive(color);
            return _context.SaveChangesAsync();
        }

        public Task<List<Color>> Buscar(string nombre)
        {
            return _context.Color.Where(x => x.Nombre.Contains(nombre) && !x.Borrado).ToListAsync();
        }
    }
}
