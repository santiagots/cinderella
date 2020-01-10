using System.Collections.Generic;
using Common.Core.Enum;
using Common.Core.ValueObjects;
using Common.Service.NotaCredito.Contracts;

namespace Common.Service.NotaCredito
{
    internal class NotaCreditoManualStrategy : INotaCreditoStrategy
    {
        public ObtenerNumeroNotaCretidoResponse ObtenerNumeroNotaCretido(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, int numeroFacturaOrigen, int puntoVentaOrigen, CondicionIVA condicionIvaOriginal)
        {
            return new ObtenerNumeroNotaCretidoResponse();
        }
    }
}