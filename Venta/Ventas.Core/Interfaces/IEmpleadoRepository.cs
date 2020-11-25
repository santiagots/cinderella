using Common.Core.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<List<Empleado>> ObtenerPorSucursalAsync(int idSucursal, TipoEmpleado tipoEmpleado);

        Task<List<Empleado>> ObtenerPresentesAsync(int idSucursal, TipoEmpleado tipoEmpleado);
    }
}
