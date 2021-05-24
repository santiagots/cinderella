using Common.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.ValueObjects
{
    public class Egreso : ValueObjects<Egreso>
    {
        public decimal Devoluciones { get; protected set; }
        public decimal Mercaderias { get; protected set; }
        public decimal Sueldos { get; protected set; }
        public decimal Gastos { get; protected set; }
        public decimal Impuestos { get; protected set; }
        public decimal EnviosSucursales { get; protected set; }
        public decimal FaltanteCaja { get; protected set; }
        public decimal PendientesAutorizacion { get; protected set; }
        public decimal IngresoCajaFuerte { get; protected set; }
        public decimal RetirosSocios { get; protected set; }

        public Egreso(decimal devoluciones, decimal mercaderias, decimal sueldos, decimal gastos, decimal impuestos, decimal enviosSucursales, decimal faltanteCaja, decimal pendientesAutorizacion, decimal ingresoCajaFuerte, decimal retirosSocios)
        {
            Devoluciones = devoluciones;
            Mercaderias = mercaderias;
            Sueldos = sueldos;
            Gastos = gastos;
            Impuestos = impuestos;
            EnviosSucursales = enviosSucursales;
            FaltanteCaja = faltanteCaja;
            PendientesAutorizacion = pendientesAutorizacion;
            IngresoCajaFuerte = ingresoCajaFuerte;
            RetirosSocios = retirosSocios;
        }

        public decimal Total()
        {
            return EnviosSucursales + Gastos + Mercaderias + Impuestos + RetirosSocios + FaltanteCaja + Sueldos + IngresoCajaFuerte + Devoluciones + PendientesAutorizacion;
        }

        public decimal Disponible()
        {
            return EnviosSucursales + Gastos + Mercaderias + Impuestos + RetirosSocios + FaltanteCaja + Sueldos + Devoluciones;
        }

        protected override bool EqualsCore(Egreso other)
        {
            return Devoluciones == other.Devoluciones &&
                Mercaderias == other.Devoluciones &&
                Sueldos == other.Sueldos &&
                Gastos == other.Gastos &&
                Impuestos == other.Impuestos &&
                EnviosSucursales == other.EnviosSucursales &&
                FaltanteCaja == other.FaltanteCaja &&
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
                FaltanteCaja +
                PendientesAutorizacion +
                IngresoCajaFuerte +
                RetirosSocios).GetHashCode();
        }
    }
}
