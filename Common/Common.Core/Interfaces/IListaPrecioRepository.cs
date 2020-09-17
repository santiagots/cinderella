using Common.Core.Enum;
using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IListaPrecioRepository
    {
        Task<List<ListaPrecio>> ObtenerAsync();
        Task<List<ListaPrecio>> ObtenerMayoristaAsync();
        Task<List<ListaPrecio>> ObtenerMinoristaAsync();
    }
}
