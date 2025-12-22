using Common.Core.Enum;
using Common.Core.Extension;
using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.PresupuestoAgreggate;
using Z.EntityFramework.Plus;

namespace Ventas.Data.Repository
{
    public class PresupuestoRepository : BaseRepository<VentaContext>, IPresupuestoRepository
    {
        public PresupuestoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task<List<Presupuesto>> BuscarAsync(int idSucursal, int? numero, string cliente, DateTime? fechaDesde, DateTime? fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IQueryable<Presupuesto> presupuestos = ObtenerConsulta()
                                                    .Where(x => x.IdSucursal == idSucursal);

            if (numero.HasValue)
                presupuestos = presupuestos.Where(x => x.Numero == numero.Value);

            if (!string.IsNullOrEmpty(cliente))
                presupuestos = presupuestos.Where(x => x.ClienteMayorista.RazonSocial.Contains(cliente));

            if (fechaDesde.HasValue)
                presupuestos = presupuestos.Where(x => DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value);

            if (fechaHasta.HasValue)
                presupuestos = presupuestos.Where(x => DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            return presupuestos.Paginar(ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos)
                               .ToListAsync();
        }

        public Task<Presupuesto> ObtenerAsync(long idPresupuesto)
        {
            return ObtenerConsulta().FirstOrDefaultAsync(x => x.Id == idPresupuesto);
        }

        public Task GuardarAsync(Presupuesto presupuesto)
        {
            if (presupuesto.Numero == 0)
            {
                Presupuesto UltimaPresupuesto = _context.Presupuesto
                                            .Where(x => x.IdSucursal == presupuesto.IdSucursal)
                                            .OrderByDescending(x => x.Numero)
                                            .FirstOrDefault();

                if (UltimaPresupuesto == null)
                    presupuesto.AgregarNumero(1);
                else
                    presupuesto.AgregarNumero(UltimaPresupuesto.Numero + 1);
            }

            _context.AttachRecursive(presupuesto);
            return _context.SaveChangesAsync();
        }

        private IQueryable<Presupuesto> ObtenerConsulta()
        {
            return _context.Presupuesto
                            .IncludeFilter(x => x.ClienteMayorista)
                            .IncludeFilter(x => x.ClienteMinorista)
                            .IncludeFilter(x => x.Encargado)
                            .IncludeFilter(x => x.Vendedor)
                            .IncludeFilter(x => x.PresupuestoItems)
                            .IncludeFilter(x => x.PresupuestoItems.Select(y => y.Producto));
        }
    }
}
