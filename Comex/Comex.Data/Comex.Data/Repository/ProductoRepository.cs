using Comex.Core.Interfaces;
using Comex.Core.Model.ComexAggregate;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Comex.Data.Repository
{
    public class ProductoRepository : BaseRepository<ComexContext>, IProductoRepository
    {
        public ProductoRepository(ComexContext context) : base(context)
        {
        }

        public List<string> ObtenerNombreYCodigoDeProductos(int idSupplier)
        {
            var query = _context.Producto.Where(x => x.Supplier.Id == idSupplier);
            List<string> nombreYCodigo = new List<string>();
            nombreYCodigo.AddRange(query.Select(x => x.Nombre).ToList());
            nombreYCodigo.AddRange(query.Select(x => x.Nombre).ToList());
            return nombreYCodigo;
        }

        public Task<Producto> BuscarProductoPorCodigoNombreBarras(int idSupplier, string CodigoNombreBarras)
        {
            return  ObtenerContextoCompleto()
                    .FirstOrDefaultAsync(x => x.Supplier.Id == idSupplier && (x.Codigo == CodigoNombreBarras || x.Nombre == CodigoNombreBarras || x.CodigoBarra == CodigoNombreBarras));
        }

        public Task<List<Producto>> BuscarProducto(int? idSupplier, int? idColor, int? idTipoProducto, int? cantidadLuces, string codigo)
        {
            IQueryable<Producto> consulta = ObtenerContextoCompleto();

            if(idSupplier != null)
                consulta = consulta.Where(x => x.IdSupplier == idSupplier);

            if(idColor != null)
                consulta = consulta.Where(x => x.IdColor == idSupplier);

            if (idTipoProducto != null)
                consulta = consulta.Where(x => x.IdProductType == idTipoProducto);

            if (cantidadLuces != null)
                consulta = consulta.Where(x => x.QtyOfLights == cantidadLuces);

            if (!string.IsNullOrEmpty(codigo))
                consulta = consulta.Where(x => x.Codigo.Contains(codigo) || x.Nombre.Contains(codigo));

            return consulta.ToListAsync();
        }

        private IQueryable<Producto> ObtenerContextoCompleto()
        {
            return _context.Producto.Include(x => x.Supplier)
                                    .Include(x => x.Color)
                                    .Include(x => x.ProductType);
        }
    }
}
