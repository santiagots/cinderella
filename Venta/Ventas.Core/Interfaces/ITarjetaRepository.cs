using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface ITarjetaRepository
    {
        Task<List<Tarjeta>> Obtener();
    }
}
