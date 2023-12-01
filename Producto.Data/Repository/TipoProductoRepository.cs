using Common.Data.Repository;
using Producto.Core.Interfaces;
using Producto.Core.Model.ProductoAgreggate;
using System.Collections.Generic;
using System.Linq;


namespace Producto.Data.Repository
{
    public class TipoProductoRepository : BaseRepository<ProductoContext>, ITipoProductoRepository
    {
        public TipoProductoRepository(ProductoContext context) : base(context)
        {
        }

        public void Actualizar(TipoProducto tipoProducto)
        {
            _context.AttachRecursive(tipoProducto);
            _context.SaveChanges();
        }

        public List<TipoProducto> Buscar(string nombre)
        {
            return _context.TipoProducto.Where(x => x.Nombre.Contains(nombre) && !x.Borrado).ToList();
        }
    }
}
