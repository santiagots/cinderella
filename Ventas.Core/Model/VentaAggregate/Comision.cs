using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Comision: Entity<long>
    {
        public int IdEmpleado { get; protected set; }
        public int IdSucursal { get; protected set; }
        public long IdVenta { get; protected set; }
        public decimal PorcentajeComision { get; protected set; }
        public decimal Monto { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public bool Borrado { get; protected set; }
        public DateTime FechaEdicion { get; protected set; }
        public Venta Venta { get; protected set; }

        protected Comision()
        {
        }

        public Comision(int idEmpleado, int idSucursal, long idVenta, decimal porcentajeComision, decimal montoTotal): base(true)
        {
            IdEmpleado = idEmpleado;
            IdSucursal = idSucursal;
            IdVenta = idVenta;
            PorcentajeComision = porcentajeComision / 100;
            Monto = montoTotal * PorcentajeComision;
            Fecha = DateTime.Now;
            Borrado = false;
            FechaEdicion = DateTime.Now;
        }
    }
}
