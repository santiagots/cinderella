using System.Collections.Generic;
using Common.Core.Enum;
using Common.Core.ValueObjects;

namespace Common.Service.NotaCredito
{
    internal class NotaCreditoManualStrategy : INotaCreditoStrategy
    {
        public List<int> ObtenerNumeroNotaCretido(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, int numeroFacturaOrigen)
        {
            return new List<int>();
        }
    }
}