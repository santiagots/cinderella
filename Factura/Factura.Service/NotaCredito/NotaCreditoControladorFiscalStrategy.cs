using System.Collections.Generic;
using System.Linq;
using Factura.Device.Contracts;
using Factura.Device.Printer;
using Factura.Service.NotaCredito.Contracts;

namespace Common.Service.NotaCredito
{
    public class NotaCreditoControladorFiscalStrategy : INotaCreditoStrategy
    {
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest request)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter(request.TipoCliente, request.CondicionIVA, request.PorcentajeFacturacion, request.NombreYApellido, request.Direccion, request.Localidad, request.Cuit, request.NumeroFacturaOrigen.ToString(), request.PuntoVentaOrigen.ToString(), request.CondicionIVAOriginal))
            {
                //pongo primer los productos con monto positibo y luego con monto negativo porque la controladora no puede operar con mantos negativos
                List<ProductoTicketRequest> productos = request.Productos
                    .Where(x => x.Cantidad >= 0)
                    .Select(x => new ProductoTicketRequest(x.Codigo, x.Nombre, x.Cantidad, x.MontoUnitario, x.DescuentoUnitario, x.CFTUnitario, x.IVA.Valor)).ToList();

                productos.AddRange(
                    request.Productos
                    .Where(x => x.Cantidad < 0)
                    .Select(x => new ProductoTicketRequest(x.Codigo, x.Nombre, x.Cantidad, x.MontoUnitario, x.DescuentoUnitario, x.CFTUnitario, x.IVA.Valor)).ToList());

                List<PagoTicketRequest> pagos = request.Pagos.Select(x => new PagoTicketRequest(x.TipoPago, x.NumeroCuotas, x.Monto, x.Descuento, x.CFT, x.IVA)).ToList();

                string TipoFactura = string.Empty;
                decimal MontoTotal = 0;
                decimal MontoIvaTotal = 0;
                decimal MontoVuelto = 0;

                int numeroNotaCredito = epsonFP.ObtenerNumeroNotaCretido(productos, pagos, out TipoFactura, out MontoTotal, out MontoIvaTotal, out MontoVuelto);

                return new ObtenerNumeroNotaCretidoResponse()
                {
                    SubTotal = MontoTotal - MontoIvaTotal,
                    Iva = MontoIvaTotal,
                    Total = MontoTotal,
                    NumeroNotaCredito = new List<int>() { numeroNotaCredito }
                };
            }
        }
    }
}