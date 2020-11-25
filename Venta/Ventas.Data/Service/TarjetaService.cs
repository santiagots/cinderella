
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class TarjetaService
    {
        public static Task<List<Tarjeta>> ObtenerAsync()
        {
            ITarjetaRepository tarjetaRepository = new TarjetaRepository(new VentaContext());
            return tarjetaRepository.Obtener();
        }
    }
}
