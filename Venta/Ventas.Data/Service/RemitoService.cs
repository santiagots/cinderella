using Common.Core.Enum;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.RemitoAgreggate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class RemitoService
    {
        public static Task<Remito> ObtenerAsync(long idRemito)
        {
            IRemitoRepository remitoRepository = new RemitoRepository(new VentaContext());
            return remitoRepository.ObtenerAsync(idRemito);
        }

        public static Task<Remito> ObtenerPorVentaAsync(long idVenta)
        {
            IRemitoRepository remitoRepository = new RemitoRepository(new VentaContext());
            return remitoRepository.ObtenerPorVentaAsync(idVenta);
        }

        public static Task GuardarAsync(Remito remito)
        {
            IRemitoRepository remitoRepository = new RemitoRepository(new VentaContext());
            return remitoRepository.GuardarAsync(remito);
        }
    }
}
