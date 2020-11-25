using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class ListaPrecioService
    {
        public static Task<List<ListaPrecio>> ObtenerAsync()
        {
            IListaPrecioRepository listaPrecioRepository = new ListaPrecioRepository(new CommonContext());
            return listaPrecioRepository.ObtenerAsync();
        }

        public static Task<List<ListaPrecio>> ObtenerMayoristaAsync()
        {
            IListaPrecioRepository listaPrecioRepository = new ListaPrecioRepository(new CommonContext());
            return listaPrecioRepository.ObtenerMayoristaAsync();
        }

        public static Task<List<ListaPrecio>> ObtenerMinoristaAsync()
        {
            IListaPrecioRepository listaPrecioRepository = new ListaPrecioRepository(new CommonContext());
            return listaPrecioRepository.ObtenerMinoristaAsync();
        }
    }
}
