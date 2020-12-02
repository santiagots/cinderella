using Common.Core.ValueObjects;

namespace Ventas.Core.Model.ValueObjects
{
    public class Ingreso : ValueObjects<Ingreso>
    {
        public decimal TotalEfectivoVentas { get; protected set; }
        public decimal TotalEfectivoCuentaCorriente { get; protected set; }
        public decimal CajaInicial { get; protected set; }
        public decimal RecibidosSucursal { get; protected set; }
        public decimal SobranteCaja { get; protected set; }
        public decimal EgresosCajaFuerte { get; protected set; }
        public decimal AporteSocios { get; protected set; }

        public Ingreso(decimal totalEfectivoVentas, decimal totalEfectivoCuentaCorriente, decimal cajaInicial, decimal recibidosSucursal, decimal sobranteCaja, decimal egresosCajaFuerte, decimal aporteSocios)
        {
            TotalEfectivoVentas = totalEfectivoVentas;
            TotalEfectivoCuentaCorriente = totalEfectivoCuentaCorriente;
            CajaInicial = cajaInicial;
            RecibidosSucursal = recibidosSucursal;
            SobranteCaja = sobranteCaja;
            EgresosCajaFuerte = egresosCajaFuerte;
            AporteSocios = aporteSocios;
        }

        public decimal Total()
        {
            return TotalEfectivoVentas + TotalEfectivoCuentaCorriente + SobranteCaja + CajaInicial + RecibidosSucursal + EgresosCajaFuerte + AporteSocios;
        }

        public decimal Disponible()
        {
            return TotalEfectivoVentas + SobranteCaja + CajaInicial + RecibidosSucursal + AporteSocios;
        }

        protected override bool EqualsCore(Ingreso other)
        {
            return TotalEfectivoVentas == other.TotalEfectivoVentas &&
                CajaInicial == other.CajaInicial &&
                RecibidosSucursal == other.RecibidosSucursal &&
                SobranteCaja == other.SobranteCaja &&
                EgresosCajaFuerte == other.EgresosCajaFuerte &&
                AporteSocios == other.AporteSocios;
        }

        protected override int GetHashCodeCore()
        {
            return (TotalEfectivoVentas +
                CajaInicial +
                RecibidosSucursal +
                SobranteCaja +
                EgresosCajaFuerte +
                AporteSocios).GetHashCode();
        }
    }
}
