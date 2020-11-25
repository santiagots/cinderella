using Common.Core.Enum;
using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Data.Repository
{
    public class EmpleadoRepository : BaseRepository<VentaContext>, IEmpleadoRepository
    {
        public EmpleadoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task<List<Empleado>> ObtenerPorSucursalAsync(int idSucursal, TipoEmpleado tipoEmpleado)
        {
            string sql = @" select distinct E.id_Empleado as Id, E.Apellido, E.Nombre, E.Habilitado, E.id_TipoEmpleado as Tipo
                            from EMPLEADOS E inner join REL_EMPLEADOS_SUCURSALES ES on E.id_Empleado = ES.id_Empleado
                            Where ES.id_Sucursal = @idSucursal and E.id_TipoEmpleado = @Tipo";

            return Task.Run(() => _context.Empleado.SqlQuery(sql
                                                            , new SqlParameter("@idSucursal", idSucursal), new SqlParameter("@Tipo", tipoEmpleado)).ToList()
                   );
                
        }

        public Task<List<Empleado>> ObtenerPresentesAsync(int idSucursal, TipoEmpleado tipoEmpleado)
        {

            string sql = @" select distinct E.id_Empleado as Id, E.Apellido, E.Nombre, E.Habilitado, E.id_TipoEmpleado as Tipo
                            from REL_REGISTRO_EMPLEADOS REL
                                inner join EMPLEADOS_REGISTROS REG on REL.id_Registro = REG.id_Registro
                                inner join EMPLEADOS E on rel.id_Empleado = E.id_Empleado
                            where
                                REG.Borrado = 0 and
                                REG.Fecha = @fecha and
                                E.id_TipoEmpleado = @Tipo and
                                REG.id_Sucursal = @idSucursal
                            
                            union
                            
                            select distinct E.id_Empleado as Id, E.Apellido, E.Nombre, E.Habilitado, E.id_TipoEmpleado as Tipo
                            from REL_REGISTRO_EMPLEADOS_TARDE REL
                                inner join EMPLEADOS_REGISTROS REG on REL.id_Registro = REG.id_Registro
                                inner join EMPLEADOS E on rel.id_Empleado = E.id_Empleado
                            where
                                REG.Borrado = 0 and
                                REG.Fecha = @fecha and
                                E.id_TipoEmpleado = @Tipo and
                                REG.id_Sucursal = @idSucursal";

            return Task.Run(() =>
                                _context.Empleado.SqlQuery(sql
                                                            , new SqlParameter("@idSucursal", idSucursal), new SqlParameter("@Tipo", (int)tipoEmpleado), new SqlParameter("@fecha", DateTime.Now.ToString("yyyy-MM-dd"))).ToList()
                            );

        }
    }
}
