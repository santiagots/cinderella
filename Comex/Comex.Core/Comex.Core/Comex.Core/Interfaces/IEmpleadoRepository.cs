using Comex.Core.Model.ComexAggregate;
using Common.Core.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Core.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<List<Empleado>> ObtenerPorSucursalAsync(int? idSucursal, TipoEmpleado tipoEmpleado);
    }
}
