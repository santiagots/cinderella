using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Interfaces;
using Common.Core.Model;

namespace Common.Data.Repository
{
    public class SubCategoriaRepository : BaseRepository<CommonContext>, ISubCategoriaRepository
    {
        public SubCategoriaRepository(CommonContext commonContext) : base(commonContext)
        {
        }

        public void Actualizar(SubCategoria subCategoria)
        {
            _context.SubCategoria.Attach(subCategoria);
            _context.Entry(subCategoria.Categoria).State = EntityState.Unchanged;
            _context.Entry(subCategoria).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IList<SubCategoria> Buscar(string descripcion, Categoria categoria, IVA iva, bool habilitado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalItems)
        {
            IQueryable<SubCategoria> subcategoria = _context
                                                        .SubCategoria
                                                        .Include(x => x.Categoria)
                                                        .Include(x => x.IVA);

            subcategoria = subcategoria.Where(x => x.Habilitado == habilitado);

            if (!string.IsNullOrEmpty(descripcion))
                subcategoria = subcategoria.Where(x => x.Descripcion.Contains(descripcion));

            if (categoria != null)
                subcategoria = subcategoria.Where(x => x.IdCategoria == categoria.Id);

            if (iva != null)
                subcategoria = subcategoria.Where(x => x.IVA.Id == iva.Id);

            totalItems = subcategoria.Count();

            return subcategoria
                            .OrderBy($"{ordenadoPor} {ordenarDireccion.ToString()}")
                            .Skip(itemsPorPagina * (pagina - 1))
                            .Take(itemsPorPagina)
                            .ToList();
        }

        public SubCategoria Obtener(int idSubCategoria)
        {
            return _context
                .SubCategoria
                .Include(x => x.Categoria)
                .Include(x => x.IVA)
                .FirstOrDefault(x => x.Id == idSubCategoria);
        }

        public IList<SubCategoria> ObtenerPorCategoria(int idCategoria)
        {
            return _context.SubCategoria.Where(x => x.IdCategoria == idCategoria && x.Habilitado).OrderBy(x => x.Descripcion).ToList();
        }

        public void Guardar(SubCategoria subCategoria)
        {
            if (_context.SubCategoria.Any(x => x.Descripcion.ToUpper() == subCategoria.Descripcion.ToUpper() &&
                                                x.Categoria.Descripcion.ToUpper() == subCategoria.Categoria.Descripcion.ToUpper()))
            {
                throw new NegocioException($"La subcategoría {subCategoria.Descripcion} ya está registrada para la categoría {subCategoria.Categoria.Descripcion}. Por favor, ingrese otro subcategoría.");
            }

            _context.Entry(subCategoria.IVA).State = EntityState.Unchanged;
            _context.Entry(subCategoria.Categoria).State = EntityState.Unchanged;

            _context.SubCategoria.Add(subCategoria);
            _context.SaveChanges();
        }
    }
}
