using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Ventas.Core.Interfaces;
using Common.Core.Exceptions;
using Ventas.Core.Model.BaseAgreggate;
using Common.Data.Repository;

namespace Ventas.Data.Repository
{
    public class ProductoRepository: BaseRepository<VentaContext>, IProductoRepository
    {
        public ProductoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Producto Obtener(int idSucursal,int idProducto)
        {
            Producto producto = ObtenerConsulta()
                                .FirstOrDefault(x => x.Id == idProducto);

            if (producto == null)
                throw new NegocioException($"El producto con id {idProducto} no existe.");

            Stock stock = _context.Stock.FirstOrDefault(x => x.IdSucursal == idSucursal && x.IdProducto == producto.Id);

            if (stock == null)
                stock = new Stock(idSucursal, idProducto, 0, 0, 0, 0);

            producto.Stock = stock;

            return producto;
        }

        private IQueryable<Producto> ObtenerConsulta()
        {
            return _context
                        .Producto
                        .Include(x => x.Precios)
                        .Include(x => x.Categoria)
                        .Include(x => x.SubCategoria)
                        .Include(x => x.SubCategoria.IVA);
        }

        public Producto ObtenerPorCodigo(int idSucursal, string codigo)
        {
            Producto producto = ObtenerConsulta().FirstOrDefault(x => x.Codigo == codigo);

            if (producto == null)
                throw new NegocioException($"El producto con código {codigo} no existe.");

            Stock stock = _context.Stock.FirstOrDefault(x => x.IdSucursal == idSucursal && x.IdProducto == producto.Id);

            if (stock == null)
                stock = new Stock(idSucursal, producto.Id, 0, 0, 0, 0);

            producto.Stock = stock;

            return producto;
        }

        public Producto ObtenerPorCodigoBarras(int idSucursal, string codigoBarra)
        {
            Producto producto = ObtenerConsulta().FirstOrDefault(x => x.CodigoBarra == codigoBarra);

            if (producto == null)
                throw new NegocioException($"El producto con el código de barras {codigoBarra} no existe.");

            Stock stock = _context.Stock.FirstOrDefault(x => x.IdSucursal == idSucursal && x.IdProducto == producto.Id);

            if (stock == null)
                stock = new Stock(idSucursal, producto.Id, 0, 0, 0, 0);

            producto.Stock = stock;

            return producto;
        }

        public IList<Producto> Obtener()
        {
            return _context.Producto.ToList();
        }
    }
}
