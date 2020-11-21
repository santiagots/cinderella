namespace Ventas.Core.Model.ValueObjects
{
    public class SucursalPagos
    {
        private TotalFormaPago TotalFormaPagoEnVentas;
        private TotalFormaPago TotalFormaPagoEnCuentaCorriente;
        public decimal FacturadoVenta { get; protected set; }
        public decimal SinFacturarVenta { get; protected set; }
        public decimal MinoristaVenta { get; protected set; }
        public decimal MayoristaVenta { get; protected set; }

        public SucursalPagos(TotalFormaPago totalFormaPagoEnVentas, TotalFormaPago totalFormaPagoEnCuentaCorriente, decimal facturadoVenta, decimal sinFacturarVenta, decimal minoristaVenta, decimal mayoristaVenta)
        {
            TotalFormaPagoEnVentas = totalFormaPagoEnVentas;
            TotalFormaPagoEnCuentaCorriente = totalFormaPagoEnCuentaCorriente;
            FacturadoVenta = facturadoVenta;
            SinFacturarVenta = sinFacturarVenta;
            MinoristaVenta = minoristaVenta;
            MayoristaVenta = mayoristaVenta;
        }

        public decimal Efectivo => TotalFormaPagoEnVentas.Efectivo + TotalFormaPagoEnCuentaCorriente.Efectivo;
        public decimal Cheque => TotalFormaPagoEnVentas.Cheque + TotalFormaPagoEnCuentaCorriente.Cheque;
        public decimal Deposito => TotalFormaPagoEnVentas.Deposito + TotalFormaPagoEnCuentaCorriente.Deposito;
        public decimal Debito => TotalFormaPagoEnVentas.Debito + TotalFormaPagoEnCuentaCorriente.Debito;
        public decimal Credito => TotalFormaPagoEnVentas.Credito + TotalFormaPagoEnCuentaCorriente.Credito;
        public decimal CuentaCorriente => TotalFormaPagoEnVentas.CuentaCorriente - TotalFormaPagoEnCuentaCorriente.Efectivo
                                                                                 - TotalFormaPagoEnCuentaCorriente.Cheque
                                                                                 - TotalFormaPagoEnCuentaCorriente.Deposito
                                                                                 - TotalFormaPagoEnCuentaCorriente.Debito
                                                                                 - TotalFormaPagoEnCuentaCorriente.Credito;      
    }
}
