using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Producto.Core.Interfaces;
using Modelo = Producto.Core.Model.ProductoAgreggate;
using Ventas.Data.Repository;
using Common.Core.Exceptions;
using Common.Core.Model;

namespace Producto.Data.Repository
{
    public class ProductoRepository : BaseRepository<ProductoContext>, IProductoRepository
    {
        public ProductoRepository(ProductoContext ventaContext) : base(ventaContext)
        {
        }

        public void Actualizar(Modelo.Producto producto)
        {
            foreach(Modelo.Precio precio in producto.Precios)
                _context.Entry(precio).State = EntityState.Modified;

            _context.Producto.Attach(producto);
            _context.Entry(producto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IList<Modelo.Producto> Buscar(string codigo, string nombre, int pagina, int itemsPorPagina)
        {
            IQueryable<Modelo.Producto> productos = _context.Producto
                                                                .Include(x => x.Categoria)
                                                                .Include(x => x.Subcategoria)
                                                                .Include(x => x.Proveedor)
                                                                .Include(x => x.Precios);

            if (!String.IsNullOrEmpty(codigo))
                productos = productos.Where(x => x.Codigo.Contains(codigo));

            if (!String.IsNullOrEmpty(nombre))
                productos = productos.Where(x => x.Nombre.Contains(nombre));

            return productos.OrderBy(x => x.Codigo)
                            .ThenBy(x => x.Nombre)
                            .Skip(itemsPorPagina * (pagina - 1))
                            .Take(itemsPorPagina)
                            .ToList();
        }

        public int BuscarTotal(string codigo, string nombre)
        {
            IQueryable<Modelo.Producto> productos = _context.Producto.AsQueryable();

            if (!String.IsNullOrEmpty(codigo))
                productos = productos.Where(x => x.Codigo.Contains(codigo));

            if (!String.IsNullOrEmpty(nombre))
                productos = productos.Where(x => x.Nombre.Contains(nombre));

            return productos.Count();
        }

        public void Guardar(Modelo.Producto producto)
        {
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                if (_context.Producto.Any(x => x.Codigo.ToUpper() == producto.Codigo.ToUpper()))
                {
                    throw new NegocioException($"El código de producto {producto.Codigo} ya está en uso. Por favor, ingrese otro código de producto.");
                }

                _context.Producto.Add(producto);
                _context.SaveChanges();

                producto.CargarCodigoBarras(producto.Id);
                _context.SaveChanges();

                dbContextTransaction.Commit();
            }
        }

        public void Eliminar(int idProducto)
        {
            _context.Producto.Remove(
                    _context.Producto.Find(idProducto));

            _context.SaveChanges();
        }

        public Modelo.Producto ObtenerProducto(int idProducto)
        {
            return _context.Producto.Include(x => x.Categoria)
                                    .Include(x => x.Subcategoria)
                                    .Include(x => x.Proveedor)
                                    .Include(x => x.Precios)
                                    .Where(x => x.Id == idProducto).FirstOrDefault();
        }

        public IList<Categoria> ObtenerCategorias()
        {
            return _context.Categoria.Where(x => x.Habilitado).OrderBy(x => x.Descripcion).ToList();
        }

        public IList<SubCategoria> ObtenerSubcategorias(int idCategoria)
        {
            return _context.SubCategoria.Where(x => x.IdCategoria == idCategoria && x.Habilitado).OrderBy(x => x.Descripcion).ToList();
        }

        public IList<Modelo.Proveedor> ObtenerProveedores()
        {
            return _context.Proveedor.Where(x => x.Habilitado).OrderBy(x => x.RazonSocial).ToList();
        }
    }
}
