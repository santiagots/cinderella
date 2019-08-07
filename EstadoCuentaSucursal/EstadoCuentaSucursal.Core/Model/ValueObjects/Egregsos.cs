using Common.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuentaSucursal.Core.Model.ValueObjects
{
    public class Egregsos : ValueObjects<Egregsos>
    {
        public decimal Devoluciones { get; protected set; }
        public decimal Mercaderias { get; protected set; }
        public decimal Sueldos { get; protected set; }
        public decimal Gastos { get; protected set; }
        public decimal Impuestos { get; protected set; }
        public decimal EnviosSucursales { get; protected set; }
        public decimal PendientesAutorizacion { get; protected set; }
        public decimal IngresoCajaFuerte { get; protected set; }
        public decimal RetirosSocios { get; protected set; }

        public Egregsos(decimal devoluciones, decimal mercaderias, decimal sueldos, decimal gastos, decimal impuestos, decimal enviosSucursales, decimal pendientesAutorizacion, decimal ingresoCajaFuerte, decimal retirosSocios)
        {
            Devoluciones = devoluciones;
            Mercaderias = mercaderias;
            Sueldos = sueldos;
            Gastos = gastos;
            Impuestos = impuestos;
            EnviosSucursales = enviosSucursales;
            PendientesAutorizacion = pendientesAutorizacion;
            IngresoCajaFuerte = ingresoCajaFuerte;
            RetirosSocios = retirosSocios;
        }

        protected override bool EqualsCore(Egregsos other)
        {
            return Devoluciones == other.Devoluciones &&
                Mercaderias == other.Devoluciones &&
                Sueldos == other.Sueldos &&
                Gastos == other.Gastos &&
                Impuestos == other.Impuestos &&
                EnviosSucursales == other.EnviosSucursales &&
                PendientesAutorizacion == other.PendientesAutorizacion &&
                IngresoCajaFuerte == other.IngresoCajaFuerte &&
                RetirosSocios == other.RetirosSocios;
        }

        protected override int GetHashCodeCore()
        {
            return (Devoluciones +
                Mercaderias +
                Sueldos +
                Gastos +
                Impuestos +
                EnviosSucursales +
                PendientesAutorizacion +
                IngresoCajaFuerte +
                RetirosSocios).GetHashCode();
        }
    }
}
