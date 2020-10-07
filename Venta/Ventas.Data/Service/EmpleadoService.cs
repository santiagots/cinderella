using Common.Core.Enum;
using Common.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class EmpleadoService
    {
        public static async Task<List<Empleado>> ObtenerEmpleados(TipoEmpleado tipoEmpleado, int idSucursal)
        {
            List<Empleado> empleado = new List<Empleado>();
                IEmpleadoRepository empleadoRepository = new EmpleadoRepository(new VentaContext());
                empleado = await empleadoRepository.ObtenerPresentesAsync(idSucursal, tipoEmpleado);

                if ((empleado.Count == 0))
                    empleado = await empleadoRepository.ObtenerPorSucursalAsync(idSucursal, tipoEmpleado);

                if ((empleado.Count == 0))
                    throw new NegocioException($"La sucursal no tiene configurado un {tipoEmpleado.ToString()}. Por favor, registre un {tipoEmpleado.ToString()} en el menú de empleados o contacte al administrador.");

            return empleado;
        }

    }
}
