using System.Collections.Generic;
using System.Linq;
using Common.Core.Enum;
using Factura.Device.Printer;
using Factura.Service.Common.Contracts;
using Factura.Service.Factura.Contracts;
using Factura.Service.NotaCredito.Contracts;

namespace Common.Service.NotaCredito
{
    public class NotaCreditoControladorFiscalStrategy : INotaCreditoStrategy
    {
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter(request.TipoCliente, request.CondicionIVA, request.PorcentajeFacturacion, request.NombreYApellido, request.Direccion, request.Localidad, request.Cuit, request.NumeroFacturaOrigen.ToString(), request.PuntoVentaOrigen.ToString(), request.CondicionIVAOriginal))
            {
                List<ProductoPrinter> productos = request.Productos.Select(x => new ProductoPrinter(x.Codigo, x.Nombre, x.Cantidad, x.Monto, x.Descuento, x.CFT, x.IVA.Valor)).ToList();
                List<PagoPrinter> pagos = request.Pagos.Select(x => new PagoPrinter(x.TipoPago, x.NumeroCuotas, x.Monto, x.Descuento, x.CFT, x.IVA)).ToList();

                int numeroNotaCredito = epsonFP.ObtenerNumeroNotaCretido(productos, pagos);

                return new ObtenerNumeroNotaCretidoResponse()
                {
                    NumeroNotaCredito = new List<int>() { numeroNotaCredito }
                };
            }
        }
    }
}