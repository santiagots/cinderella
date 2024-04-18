using Comex.Core.Model.ComexAggregate;
using Common.Core.Interfaces;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Data.Service
{
    public class SucursalService
    {
        public static Task<List<Sucursal>> ObtenerAsync()
        {
            IRepository<Sucursal> sucursalRepository = new Repository<Sucursal>(new ComexContext());
            return sucursalRepository.ListAsync();
        }
    }
}
