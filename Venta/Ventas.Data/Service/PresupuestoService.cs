using Common.Core.Enum;
using Common.Core.Extension;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.PresupuestoAgreggate;
using Ventas.Core.Model.RemitoAgreggate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class PresupuestoService
    {
        public static Task<Presupuesto> ObtenerAsync(long idPresupuesto)
        {
            IPresupuestoRepository PresupuestoRepository = new PresupuestoRepository(new VentaContext());
            return PresupuestoRepository.ObtenerAsync(idPresupuesto);
        }

        public static Task<List<Presupuesto>> BuscarAsync(int idSucursal, int? numero, string cliente, DateTime? fechaDesde, DateTime? fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IPresupuestoRepository PresupuestoRepository = new PresupuestoRepository(new VentaContext());
            return PresupuestoRepository.BuscarAsync(idSucursal, numero, cliente, fechaDesde, fechaHasta, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }

        public static Task GuardarAsync(Presupuesto presupuesto)
        {
            IPresupuestoRepository PresupuestoRepository = new PresupuestoRepository(new VentaContext());
            return PresupuestoRepository.GuardarAsync(presupuesto);
        }
    }
}
