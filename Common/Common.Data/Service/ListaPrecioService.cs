using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class ListaPrecioService
    {
        public static Task<List<ListaPrecio>> Obtener()
        {
            IListaPrecioRepository listaPrecioRepository = new ListaPrecioRepository(new CommonContext());
            return listaPrecioRepository.ObtenerAsync();
        }
    }
}
