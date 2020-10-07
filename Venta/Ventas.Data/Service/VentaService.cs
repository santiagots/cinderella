using Common.Core.Enum;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class VentaService
    {
        public static Task<Venta> ObtenerAsync(TipoBase tipoBase, long idVenta)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext(tipoBase));
            return Task.Run(() => ventaRepository.Obtener(idVenta));
        }

        public static Venta Obtener(TipoBase tipoBase, long idVenta)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext(tipoBase));
            return ventaRepository.Obtener(idVenta);
        }
    }
}
