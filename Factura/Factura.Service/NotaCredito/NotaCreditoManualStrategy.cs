using Common.Core.Helper;
using Factura.Service.NotaCredito.Contracts;

namespace Common.Service.NotaCredito
{
    internal class NotaCreditoManualStrategy : INotaCreditoStrategy
    {
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            decimal subTotal = 0;
            decimal iva = 0;

            request.Productos.ForEach(x => {
                decimal montoSinIva = Monto.ObtenerMontoSegunTipoDeCliente(x.NetoTotal, x.IVA.Valor, request.CondicionIVA);
                subTotal += montoSinIva;
                iva += montoSinIva * x.IVA.Valor;
            });

            return new ObtenerNumeroNotaCretidoResponse()
            {
                SubTotal = Monto.Redondeo(subTotal),
                Iva = Monto.Redondeo(iva),
                Total = Monto.Redondeo(subTotal + iva),
                NumeroNotaCredito = request.NumerosNotaCredito
            };
        }
    }
}