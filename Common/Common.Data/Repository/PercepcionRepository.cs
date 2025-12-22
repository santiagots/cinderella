using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    internal class PercepcionRepository : BaseRepository<CommonContext>, IPercepcionRepository
    {
        public PercepcionRepository(CommonContext context) : base(context)
        {
        }

        public Task<List<Percepcion>> Buscar(string provincia, CondicionIVA? condicionIVA, bool? habilitado)
        {
            IQueryable<Percepcion> query = _context.Percepcion.Include(x => x.Provincia);

            if (condicionIVA != null)
                query = query.Where(x => x.CondicionIVA == condicionIVA);

            if (!string.IsNullOrEmpty(provincia))
                query = query.Where(x => x.Provincia.Descripcion == provincia);

            if (habilitado.HasValue)
                query = query.Where(x => x.Habilitado == habilitado.Value);

            return query.ToListAsync();
        }

        public Task Guardar(Percepcion percepcion)
        {
            _context.AttachRecursive(percepcion);
            return _context.SaveChangesAsync();
        }
    }
}
