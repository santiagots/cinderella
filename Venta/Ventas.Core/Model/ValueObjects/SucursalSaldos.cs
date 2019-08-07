using Common.Core.ValueObjects;
using System;

namespace Ventas.Core.Model.ValueObjects
{
    public class SucursalSaldo : ValueObjects<SucursalSaldo>
    {
        public Venta Venta { get; protected set; }
        public Ingreso Ingreso { get; protected set; }
        public Egreso Egreso { get; protected set; }
        public decimal TotalCajaFuerte { get; protected set; }
        public decimal TotalCheques { get; protected set; }

        public SucursalSaldo(Venta venta, Ingreso ingreso, Egreso egreso, decimal totalCajaFuerte, decimal totalCheques)
        {
            Venta = venta;
            Ingreso = ingreso;
            Egreso = egreso;
            TotalCajaFuerte = totalCajaFuerte;
            TotalCheques = totalCheques;
        }

        public decimal Total()
        {
            decimal ingresos = Venta.Efectivo + Ingreso.SobranteCaja + Ingreso.CajaInicial + Ingreso.RecibidosSucursal + Ingreso.EgresosCajaFuerte + Ingreso.AporteSocios;
            decimal egresos = Egreso.EnviosSucursales + Egreso.Gastos + Egreso.Mercaderias + Egreso.Impuestos + Egreso.RetirosSocios + Egreso.FaltanteCaja + Egreso.Sueldos + Egreso.IngresoCajaFuerte + Egreso.Devoluciones + Egreso.PendientesAutorizacion;
            return ingresos - egresos;
        }

        public decimal Disponible()
        {
            decimal ingresos = Venta.Efectivo + Ingreso.SobranteCaja + Ingreso.CajaInicial + Ingreso.RecibidosSucursal + Ingreso.AporteSocios;
            decimal egresos = Egreso.EnviosSucursales + Egreso.Gastos + Egreso.Mercaderias + Egreso.Impuestos + Egreso.RetirosSocios + Egreso.FaltanteCaja + Egreso.Sueldos + Egreso.Devoluciones;
            return ingresos - egresos + TotalCajaFuerte;
        }

        protected override bool EqualsCore(SucursalSaldo other)
        {
            return Venta.Equals(other) &&
                   Ingreso.Equals(other) &&
                   Egreso.Equals(other);
        }

        protected override int GetHashCodeCore()
        {
            return Venta.GetHashCode() +
                   Ingreso.GetHashCode() +
                   Egreso.GetHashCode();
        }
    }
}
