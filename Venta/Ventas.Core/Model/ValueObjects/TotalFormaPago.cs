namespace Ventas.Core.Model.ValueObjects
{
    public class TotalFormaPago
    {
        public decimal Efectivo { get; protected set; }
        public decimal Cheque { get; protected set; }
        public decimal Credito { get; protected set; }
        public decimal Debito { get; protected set; }
        public decimal Deposito { get; protected set; }
        public decimal CuentaCorriente { get; protected set; }

        public TotalFormaPago(decimal efectivo, decimal cheque, decimal credito, decimal debito, decimal deposito, decimal cuentaCorriente)
        {
            Efectivo = efectivo;
            Cheque = cheque;
            Credito = credito;
            Debito = debito;
            Deposito = deposito;
            CuentaCorriente = cuentaCorriente;
        }
    }
}
