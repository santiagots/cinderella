using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Producto.Data.Repository
{
    public class CategoriaRepository : BaseRepository<ProductoContext>, ICategoriaRepository
    {
        public CategoriaRepository(ProductoContext commonContext) : base(commonContext)
        {
        }

        public IList<Categoria> Obtener()
        {
            return _context.Categoria.Where(x => x.Habilitado).OrderBy(x => x.Descripcion).ToList();
        }
    }
}
