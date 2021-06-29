using System.Threading.Tasks;
using Ventas.Core.Model.RemitoAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface IRemitoRepository
    {
        Task GuardarAsync(Remito remito);
        Task<Remito> ObtenerAsync(long idRemito);
        Task<Remito> ObtenerPorVentaAsync(long idVenta);
    }
}
