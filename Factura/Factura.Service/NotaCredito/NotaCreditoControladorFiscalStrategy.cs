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
                List<ProductoTicketRequest> productos = request.Productos.Select(x => new ProductoTicketRequest(x.Codigo, x.Nombre, x.Cantidad, x.MontoUnitario, x.DescuentoUnitario, x.CFTUnitario, x.IVA.Valor)).ToList();
                List<PagoTicketRequest> pagos = request.Pagos.Select(x => new PagoTicketRequest(x.TipoPago, x.NumeroCuotas, x.Monto, x.Descuento, x.CFT, x.IVA)).ToList();

                int numeroNotaCredito = epsonFP.ObtenerNumeroNotaCretido(productos, pagos);

                return new ObtenerNumeroNotaCretidoResponse()
                {
                    NumeroNotaCredito = new List<int>() { numeroNotaCredito }
                };
            }
        }
    }
}