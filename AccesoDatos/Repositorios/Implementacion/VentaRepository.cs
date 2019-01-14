using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace AccesoDatos.Repositorios
{
    public class VentaRepository : Repository, IRepository<Venta>
    {
        public VentaRepository(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public Venta Add(Venta entity)
        {
            string sql = @"INSERT INTO VENTAS 
                            (@id_Venta,
                            @id_Sucursal,
                            @id_Encargado,
                            @id_Empleado,
                            @id_TipoVenta,
                            @id_Cliente,
                            @PorcentajeFacturacion,
                            @Fecha,
                            @Habilitado,
                            @Anulado,
                            @Facturado,
                            @DescripcionAnulado,
                            @FechaAnulado,
                            @Numero,
                            @id_ListaPrecio,
                            @Senia,
                            @Fecha_Edicion,
                            @id_ClienteMinorista)";
            Connection.Execute(sql, entity);
            return entity;
        }

        public void Delete(Venta entity)
        {
            string sql = @" UPDATE VENTAS
                            SET Anulado = @Anulada,
                                Fecha_Edicion = @FechaEdicion
                            WHERE id_Venta=@id_Venta;";

            Connection.Execute(sql, new { Anulada = true, FechaEdicion = DateTime.Now, id_Venta = entity.id_Venta });
        }

        public Venta FindById(int id)
        {
            string sql = @" SELECT * 
                            FROM VENTAS v 
                            WHERE v.id_Venta=@id_Venta";

            return Connection.Query<Venta>(sql, new { id_Venta = id }).FirstOrDefault();
        }

        public IEnumerable<Venta> List()
        {
            string sql = @" SELECT * 
                            FROM VENTAS v";

            return Connection.Query<Venta>(sql);
        }

        public void Update(Venta entity)
        {
            string sql = @" UPDATE VENTAS SET
                            id_Venta = @id_Venta,
                            id_Sucursal = @id_Sucursal,
                            id_Encargado = @id_Encargado,
                            id_Empleado = @id_Empleado,
                            id_TipoVenta = @id_TipoVenta,
                            id_Cliente = @id_Cliente,
                            PorcentajeFacturacion = @PorcentajeFacturacion,
                            Fecha = @Fecha,
                            Habilitado = @Habilitado,
                            Anulado = @Anulado,
                            Facturado = @Facturado,
                            DescripcionAnulado = @DescripcionAnulado,
                            FechaAnulado = @FechaAnulado,
                            Numero = @Numero,
                            id_ListaPrecio = @id_ListaPrecio,
                            Senia = @Senia,
                            Fecha_Edicion = @Fecha_Edicion,
                            id_ClienteMinorista = @id_ClienteMinorista
                            WHERE id_Venta = @id_Venta";

            Connection.Execute(sql, entity);
        }
    }
}
