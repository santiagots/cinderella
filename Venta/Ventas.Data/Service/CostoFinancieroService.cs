
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class CostoFinancieroService
    {
        public static Task<List<CostoFinanciero>> ObtenerAsync(int idTarjeta)
        {
            ICostoFinancieroRepository costoFinancieroRepository = new CostoFinancieroRepository(new VentaContext());
            return costoFinancieroRepository.Obtener(idTarjeta);
        }
    }
}
