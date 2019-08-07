using Common.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuentaSucursal.Core.Model.ValueObjects
{
    public class Ventas : ValueObjects<Ventas>
    {
        public decimal Efectivo { get; protected set; }
        public decimal Cheque { get; protected set; }
        public decimal Credito { get; protected set; }
        public decimal Debito { get; protected set; }
        public decimal Facturado { get; protected set; }
        public decimal Minorista { get; protected set; }
        public decimal Mayorista { get; protected set; }

        public Ventas(decimal efectivo, decimal cheque, decimal credito, decimal debito, decimal facturado, decimal minorista, decimal mayorista)
        {
            Efectivo = efectivo;
            Cheque = cheque;
            Credito = credito;
            Debito = debito;
            Facturado = facturado;
            Minorista = minorista;
            Mayorista = mayorista;
        }

        protected override bool EqualsCore(Ventas other)
        {
            return Efectivo == other.Efectivo &&
                Cheque == other.Cheque &&
                Credito == other.Credito &&
                Debito == other.Debito &&
                Facturado == other.Facturado &&
                Minorista == other.Minorista &&
                Mayorista == other.Mayorista;
        }

        protected override int GetHashCodeCore()
        {
            return (Efectivo +
                Cheque +
                Credito +
                Debito +
                Facturado +
                Minorista +
                Mayorista).GetHashCode();
        }
    }
}
