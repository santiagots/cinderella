using Common.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuentaSucursal.Core.Model.ValueObjects
{
    public class Ingresos : ValueObjects<Ingresos>
    {
        public decimal TotalVentas { get; protected set; }
        public decimal CajaInicial { get; protected set; }
        public decimal RecibidosSucursal { get; protected set; }
        public decimal SobranteCaja { get; protected set; }
        public decimal EgresosCajaFuerte { get; protected set; }
        public decimal AporteSocios { get; protected set; }

        public Ingresos(decimal totalVentas, decimal cajaInicial, decimal recibidosSucursal, decimal sobranteCaja, decimal egresosCajaFuerte, decimal aporteSocios)
        {
            TotalVentas = totalVentas;
            CajaInicial = cajaInicial;
            RecibidosSucursal = recibidosSucursal;
            SobranteCaja = sobranteCaja;
            EgresosCajaFuerte = egresosCajaFuerte;
            AporteSocios = aporteSocios;
        }

        protected override bool EqualsCore(Ingresos other)
        {
            return TotalVentas == other.TotalVentas &&
                CajaInicial == other.CajaInicial &&
                RecibidosSucursal == other.RecibidosSucursal &&
                SobranteCaja == other.SobranteCaja &&
                EgresosCajaFuerte == other.EgresosCajaFuerte &&
                AporteSocios == other.AporteSocios;
        }

        protected override int GetHashCodeCore()
        {
            return (TotalVentas +
                CajaInicial +
                RecibidosSucursal +
                SobranteCaja +
                EgresosCajaFuerte +
                AporteSocios).GetHashCode();
        }
    }
}
