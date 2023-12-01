using Common.Data.Repository;
using Producto.Core.Interfaces;
using Producto.Core.Model.ProductoAgreggate;
using System.Collections.Generic;
using System.Linq;

namespace Producto.Data.Repository
{
    public class ColorRepository : BaseRepository<ProductoContext>, IColorRepository
    {
        public ColorRepository(ProductoContext context) : base(context)
        {
        }

        public void Actualizar(Color color)
        {
            _context.AttachRecursive(color);
            _context.SaveChanges();
        }

        public List<Color> Buscar(string nombre)
        {
            return _context.Color.Where(x => x.Nombre.Contains(nombre) && !x.Borrado).ToList();
        }
    }
}
