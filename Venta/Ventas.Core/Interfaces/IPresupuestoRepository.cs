using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Model.PresupuestoAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface IPresupuestoRepository
    {
        Task<List<Presupuesto>> BuscarAsync(int idSucursal, int? numero, string cliente, DateTime? fechaDesde, DateTime? fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);
        Task GuardarAsync(Presupuesto presupuesto);
        Task<Presupuesto> ObtenerAsync(long idPresupuesto);
    }
}
