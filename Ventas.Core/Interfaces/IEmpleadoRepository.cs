using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IEmpleadoRepository
    {
        IEnumerable<Empleado> ObtenerPorSucursal(int idSucursal, TipoEmpleado tipoEmpleado);

        IEnumerable<Empleado> ObtenerPresentes(int idSucursal, TipoEmpleado tipoEmpleado);
    }
}
