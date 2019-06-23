using Common.Core.Enum;
using Common.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service.NotaCredito
{
    public interface INotaCreditoStrategy
    {
        List<int> ObtenerNumeroNotaCretido(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit, int numeroFacturaOrigen, int puntoVentaOrigen, CondicionIVA condicionesIVAOriginal);
    }
}
