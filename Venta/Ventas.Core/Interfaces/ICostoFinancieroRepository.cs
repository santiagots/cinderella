using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface ICostoFinancieroRepository
    {
        Task<List<CostoFinanciero>> Obtener(int idTarjeta);
    }
}
