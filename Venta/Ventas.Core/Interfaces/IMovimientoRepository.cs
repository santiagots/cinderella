using Common.Core.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Model.CuentaCorrienteAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IMovimientoRepository
    {
        Task<List<Movimiento>> ObtenerMovimientosAsync(int idClienteMayorista, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);
        Task<decimal> ObtenerSaldoAsync(int idClienteMayorista);
        Task GuardarAsync(Movimiento movimiento);
    }
}
