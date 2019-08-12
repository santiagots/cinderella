using Common.Core.ValueObjects;

namespace Ventas.Core.Model.ValueObjects
{
    public class Venta : ValueObjects<Venta>
    {
        public decimal Efectivo { get; protected set; }
        public decimal Cheque { get; protected set; }
        public decimal Credito { get; protected set; }
        public decimal Debito { get; protected set; }
        public decimal Deposito { get; protected set; }
        public decimal Facturado { get; protected set; }
        public decimal Minorista { get; protected set; }
        public decimal Mayorista { get; protected set; }

        public Venta(decimal efectivo, decimal cheque, decimal credito, decimal debito, decimal deposito, decimal facturado, decimal minorista, decimal mayorista)
        {
            Efectivo = efectivo;
            Cheque = cheque;
            Credito = credito;
            Debito = debito;
            Deposito = deposito;
            Facturado = facturado;
            Minorista = minorista;
            Mayorista = mayorista;
        }

        protected override bool EqualsCore(Venta other)
        {
            return Efectivo == other.Efectivo &&
                Cheque == other.Cheque &&
                Credito == other.Credito &&
                Debito == other.Debito &&
                Deposito == other.Deposito &&
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
                Deposito +
                Facturado +
                Minorista +
                Mayorista).GetHashCode();
        }
    }
}
