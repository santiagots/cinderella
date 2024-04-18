using Comex.Core.Interfaces;
using Comex.Core.Model.ComexAggregate;
using Comex.Data.Repository;
using Common.Core.Enum;
using Common.Core.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Data.Service
{
    public class EmpleadoService
    {
        public static async Task<List<Empleado>> ObtenerAsync(TipoEmpleado tipoEmpleado, int? idSucursal)
        {
            List<Empleado> empleado = new List<Empleado>();
                IEmpleadoRepository empleadoRepository = new EmpleadoRepository(new ComexContext());
                empleado = await empleadoRepository.ObtenerPorSucursalAsync(idSucursal, tipoEmpleado);

                if ((empleado.Count == 0))
                    throw new NegocioException($"La sucursal no tiene configurado un {tipoEmpleado.ToString()}. Por favor, registre un {tipoEmpleado.ToString()} en el menú de empleados o contacte al administrador.");

            return empleado;
        }

    }
}
