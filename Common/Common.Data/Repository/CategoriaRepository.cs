using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Linq;

namespace Common.Data.Repository
{
    public class CategoriaRepository : BaseRepository<CommonContext>, ICategoriaRepository
    {
        public CategoriaRepository(CommonContext commonContext) : base(commonContext)
        {
        }

        public IList<Categoria> Obtener()
        {
            return _context.Categoria.Where(x => x.Habilitado).OrderBy(x => x.Descripcion).ToList();
        }
    }
}
