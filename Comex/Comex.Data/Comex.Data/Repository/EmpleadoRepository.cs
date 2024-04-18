using Comex.Core.Interfaces;
using Comex.Core.Model.ComexAggregate;
using Common.Core.Enum;
using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Comex.Data.Repository
{
    public class EmpleadoRepository : BaseRepository<ComexContext>, IEmpleadoRepository
    {
        public EmpleadoRepository(ComexContext comexContext) : base(comexContext)
        {
        }

        public Task<List<Empleado>> ObtenerPorSucursalAsync(int? idSucursal, TipoEmpleado tipoEmpleado)
        {
            if (idSucursal.HasValue)
            {
                string sql = @" select distinct E.id_Empleado as Id, E.Apellido, E.Nombre, E.Habilitado, E.id_TipoEmpleado as Tipo
                            from EMPLEADOS E inner join REL_EMPLEADOS_SUCURSALES ES on E.id_Empleado = ES.id_Empleado
                            Where ES.id_Sucursal = @idSucursal and E.id_TipoEmpleado = @Tipo";
                return Task.Run(() => _context.Empleado.SqlQuery(sql, new SqlParameter("@idSucursal", idSucursal), new SqlParameter("@Tipo", tipoEmpleado)).ToList());
            }
            else
            {
                string sql = @" select distinct E.id_Empleado as Id, E.Apellido, E.Nombre, E.Habilitado, E.id_TipoEmpleado as Tipo
                            from EMPLEADOS E inner join REL_EMPLEADOS_SUCURSALES ES on E.id_Empleado = ES.id_Empleado
                            Where E.id_TipoEmpleado = @Tipo";

                return Task.Run(() => _context.Empleado.SqlQuery(sql, new SqlParameter("@Tipo", tipoEmpleado)).ToList());
            }
        }
    }
}
