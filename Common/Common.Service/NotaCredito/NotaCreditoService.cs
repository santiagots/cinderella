using Common.Core.Enum;
using Common.Core.ValueObjects;
using Common.Service.NotaCredito.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service.NotaCredito
{
    public class NotaCreditoService
    {
        private INotaCreditoStrategy notaCreditoStrategy;

        public NotaCreditoService(TipoFactura tiposFactura)
        {
            switch (tiposFactura)
            {
                case TipoFactura.Ticket:
                    notaCreditoStrategy = new NotaCreditoControladorFiscalStrategy();
                    break;
                case TipoFactura.Manual:
                    notaCreditoStrategy = new NotaCreditoManualStrategy();
                    break;
                case TipoFactura.Electronica:
                    notaCreditoStrategy = new NotaCreditoElectrinicaStrategy();
                    break;
                default:
                    throw new InvalidOperationException($"El método de facturación {tiposFactura.ToString()} no tiene un una forma de facturación definida.");
            }
        }

        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, int numeroFacturaOrigen, int puntoVentaOrigen, CondicionIVA condicionIVAOriginal)
        {
            return notaCreditoStrategy.ObtenerNumeroNotaCretido(tipoCliente, condicionesIVA, pagos, productos, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit, numeroFacturaOrigen, puntoVentaOrigen, condicionIVAOriginal);
        }
    }
}
