using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Model.CuentaCorrienteAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IMovimientoRepository
    {
        Task<List<Movimiento>> ObtenerMovimientosAsync(int idClienteMayorista, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);
        Task GuardarAsync(Movimiento movimiento);
    }
}
