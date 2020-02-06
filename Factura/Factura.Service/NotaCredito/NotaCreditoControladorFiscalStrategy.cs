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
                epsonFP.AbrirNotaCredito();

                foreach (ProductoRequest producto in request.Productos)
                {
                    epsonFP.AgregarItemNotaCredito(producto.Codigo, producto.Nombre, producto.Cantidad, producto.Monto, producto.IVA.Valor);
                }

                foreach (ProductoRequest producto in request.Productos)
                {
                    if (producto.Descuento > 0)
                        epsonFP.DescuentosNotaCredito(producto.Nombre, producto.Descuento, producto.IVA.Valor);

                    if (producto.CFT > 0)
                        epsonFP.RecargosNotaCredito(producto.Nombre, producto.CFT, producto.IVA.Valor);
                }

                //if (!request.Pagos.Any(x => x.Descuento > 0) && !request.Pagos.Any(x => x.CFT > 0))
                epsonFP.SubtotalNotaCredito();

                int numeroTicket = epsonFP.CerrarNotaCredito();

                return new ObtenerNumeroNotaCretidoResponse()
                {
                    NumeroNotaCredito = new List<int>() { numeroTicket }
                };
            }
            
        }
    }
}