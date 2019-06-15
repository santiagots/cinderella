using Common.Core.Enum;
using Common.Core.Exceptions;
using System.Collections.Generic;
using Common.Core.ValueObjects;

namespace Common.Service.Facturar
{
    public class FacturarElectrinicaStrategy : IFacturarStrategy
    {
        public List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            throw new NegocioException("El metodo de facturación electrónico no se encuentra implementado");
        }
    }
}
