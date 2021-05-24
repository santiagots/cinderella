using Common.Core.Interfaces;
using Common.Data.Repository;
using System.Threading.Tasks;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Data.Service
{
    public class SucursalService
    {
        public static Task<Sucursal> Obtener(int idSucursal)
        {
            IRepository<Sucursal> sucursalRepository = new Repository<Sucursal>(new VentaContext());
            return sucursalRepository.GetByIdAsync(idSucursal);
        }
    }
}
