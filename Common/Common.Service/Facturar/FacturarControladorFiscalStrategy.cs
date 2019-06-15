using Common.Core.Enum;
using System.Collections.Generic;
using System.Linq;
using Common.Device.Printer;
using Common.Core.ValueObjects;

namespace Common.Service.Facturar
{
    public class FacturarControladorFiscalStrategy : IFacturarStrategy
    {
        public List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            List<int> numeroFacturaRespuesta = new List<int>();
            EpsonFP epsonFP = new EpsonFP(tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit);

            epsonFP.AbrirTicket();

            foreach (TicketProducto ticketProducto in productos)
            {
                epsonFP.AgregarItemTicket(ticketProducto.Nombre, ticketProducto.Cantidad, ticketProducto.Monto);
            }

            if (pagos.Any(x => x.Descuento > 0))
                epsonFP.DescuentosTicket("Descuento", pagos.Sum(x => x.Descuento));

            if (pagos.Any(x => x.Cft > 0))
                epsonFP.RecargosTicket("Costo Financiero", pagos.Sum(x => x.Cft));

            if (!pagos.Any(x => x.Descuento > 0) && !pagos.Any(x => x.Cft > 0))
                epsonFP.SubtotalTicket();

            foreach (TicketPago pago in pagos)
            {
                epsonFP.PagarTicket(pago.Nombre, pago.Total);
            }

            int numeroTicket = epsonFP.CerrarTicket();

            numeroFacturaRespuesta.Add(numeroTicket);
            return numeroFacturaRespuesta;
        }
    }
}
