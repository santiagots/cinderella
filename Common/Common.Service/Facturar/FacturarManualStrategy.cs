using System.Collections.Generic;
using Common.Core.Enum;
using Common.Core.ValueObjects;

namespace Common.Service.Facturar
{
    class FacturarManualStrategy : IFacturarStrategy
    {
        public List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            return new List<int>();
        }
    }
}
