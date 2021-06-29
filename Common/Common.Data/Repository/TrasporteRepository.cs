using Common.Core.Enum;
using Common.Core.Extension;
using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class TrasporteRepository : BaseRepository<CommonContext>, ITrasporteRepository
    {
        public TrasporteRepository(CommonContext commonContext) : base(commonContext)
        {
        }

        public Task Guardar(Transporte transporte)
        {
            _context.AttachRecursive(transporte);
            return _context.SaveChangesAsync();
        }

        public Task<List<Transporte>> Buscar(string razonSocial, string cuit, bool? habilitado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalItems)
        {
            IQueryable<Transporte> trasporte = _context.Transporte
                                                        .Include(x => x.Domicilio)
                                                        .Include(x => x.Domicilio.Localidad)
                                                        .Include(x => x.Domicilio.Distrito)
                                                        .Include(x => x.Domicilio.Provincia)
                                                        .AsQueryable();

            if(habilitado.HasValue)
                trasporte = trasporte.Where(x => x.Habilitado == habilitado.Value);

            if (!string.IsNullOrEmpty(razonSocial))
                trasporte = trasporte.Where(x => x.RazonSocial.Contains(razonSocial));

            if (!string.IsNullOrEmpty(cuit))
                trasporte = trasporte.Where(x => x.Cuit.Contains(cuit));

            return trasporte.Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalItems).ToListAsync();
        }

        public Task<Transporte> Obtener(int id)
        {
            return _context.Transporte
                            .Include(x => x.Domicilio)
                            .Include(x => x.Domicilio.Provincia)
                            .Include(x => x.Domicilio.Distrito)
                            .Include(x => x.Domicilio.Localidad)
                            .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
