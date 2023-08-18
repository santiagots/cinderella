using Common.Core.ValueObjects;
using System;

namespace Ventas.Core.Model.ValueObjects
{
    public class SucursalSaldo : ValueObjects<SucursalSaldo>
    {
        public Ingreso Ingreso { get; protected set; }
        public Egreso Egreso { get; protected set; }
        public SucursalPagos SucursalPagos { get; protected set; }
        public decimal TotalCajaFuerte { get; protected set; }

        public SucursalSaldo(Ingreso ingreso, Egreso egreso, SucursalPagos sucursalPagos, decimal totalCajaFuerte)
        {
            Ingreso = ingreso;
            Egreso = egreso;
            SucursalPagos = sucursalPagos;
            TotalCajaFuerte = totalCajaFuerte;
        }

        public decimal Total()
        {
            return Ingreso.Total() - Egreso.Total();
        }

        public decimal Disponible()
        {
            return Ingreso.Total() - Egreso.Total() + TotalCajaFuerte;
        }

        protected override bool EqualsCore(SucursalSaldo other)
        {
            return Ingreso.Equals(other) &&
                   Egreso.Equals(other);
        }

        protected override int GetHashCodeCore()
        {
            return Ingreso.GetHashCode() +
                   Egreso.GetHashCode();
        }
    }
}
