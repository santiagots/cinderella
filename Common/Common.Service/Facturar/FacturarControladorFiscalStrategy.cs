using Common.Core.Enum;
using System.Collections.Generic;
using System.Linq;
using Common.Device.Printer;
using Common.Core.ValueObjects;
using System;
using System.Text;
using Common.Core.Exceptions;

namespace Common.Service.Facturar
{
    public class FacturarControladorFiscalStrategy : IFacturarStrategy
    {
        public void ObtenerCierreZ()
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            { 
                epsonFP.CierreZ();
            }
        }

        public void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if (fechaDesde < fechaHasta)
                    throw new NegocioException("Error, el valor de la fecha desde no puede ser mayor a la fecha hasta.");

                epsonFP.CierreZPorRangoDeFecha(fechaDesde, fechaHasta);
            }
        }

        public void ObtenerCierreZPorJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if(controladorFiscalJornadaDesde == 0 || controladorFiscalJornadaHasta == 0)
                    throw new NegocioException("Error, el valor de la jornada desde o hasta debe ser mayor a cero.");

                if (controladorFiscalJornadaDesde > controladorFiscalJornadaHasta)
                    throw new NegocioException("Error, el valor de la jornada desde no puede ser mayor a la jornada hasta.");

                epsonFP.CierreZPorRangoDeJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta);
            }
        }

        public void ObtenerCintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if (fechaDesde < fechaHasta)
                    throw new NegocioException("Error, la fecha desde no puede ser mayor a la fecha hasta.");

                epsonFP.CintaTestigoDigitalPorFecha(fechaDesde, fechaHasta, out nombre, out datos);
            }
        }

        public void ObtenerCintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if (controladorFiscalJornadaDesde == 0 || controladorFiscalJornadaHasta == 0)
                    throw new NegocioException("Error, el valor de la jornada desde o hasta debe ser mayor a cero.");

                if (controladorFiscalJornadaDesde > controladorFiscalJornadaHasta)
                    throw new NegocioException("Error, el valor de la jornada desde no puede ser mayor a la jornada hasta.");

                epsonFP.CintaTestigoDigitalPorJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombre, out datos);
            }
        }

        public void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if (fechaDesde < fechaHasta)
                    throw new NegocioException("Error, la fecha desde no puede ser mayor a la fecha hasta.");

                epsonFP.DuplicadosDocumentosTipoAPorFecha(fechaDesde, fechaHasta, out nombre, out datos);
            }
        }

        public void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if (controladorFiscalJornadaDesde == 0 || controladorFiscalJornadaHasta == 0)
                    throw new NegocioException("Error, el valor de la jornada desde o hasta debe ser mayor a cero.");

                if (controladorFiscalJornadaDesde > controladorFiscalJornadaHasta)
                    throw new NegocioException("Error, el valor de la jornada desde no puede ser mayor a la jornada hasta.");

                epsonFP.DuplicadosDocumentosTipoAPorJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombre, out datos);
            }
        }

        public void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if (fechaDesde < fechaHasta)
                    throw new NegocioException("Error, la fecha desde no puede ser mayor a la fecha hasta.");

                epsonFP.ResumenTotalesPorRangoDeFecha(fechaDesde, fechaHasta, out nombre, out datos);
            }
        }

        public void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if (controladorFiscalJornadaDesde == 0 || controladorFiscalJornadaHasta == 0)
                    throw new NegocioException("Error, el valor de la jornada desde o hasta debe ser mayor a cero.");

                if (controladorFiscalJornadaDesde > controladorFiscalJornadaHasta)
                    throw new NegocioException("Error, el valor de la jornada desde no puede ser mayor a la jornada hasta.");

                epsonFP.ResumenTotalesPorRangoDeJornadaFiscal(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombre, out datos);
            }
        }

        public List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit)
        {
            List<int> numeroFacturaRespuesta = new List<int>();
            using (EpsonPrinter epsonFP = new EpsonPrinter(tipoCliente, condicionesIVA, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit))
            {

                epsonFP.AbrirTicket();

                foreach (TicketProducto ticketProducto in productos)
                {
                    epsonFP.AgregarItemTicket(ticketProducto.Codigo, ticketProducto.Nombre, ticketProducto.Cantidad, ticketProducto.Monto);
                }

                if (pagos.Any(x => x.Descuento > 0))
                    epsonFP.DescuentosTicket("Bonificación", pagos.Sum(x => x.Descuento));

                if (pagos.Any(x => x.Cft > 0))
                    epsonFP.RecargosTicket("Costo Financiero", pagos.Sum(x => x.Cft));

                if (!pagos.Any(x => x.Descuento > 0) && !pagos.Any(x => x.Cft > 0))
                    epsonFP.SubtotalTicket();

                foreach (TicketPago pago in pagos)
                {
                    epsonFP.PagarTicket(pago.TipoPago, pago.NumeroCuotas, pago.Total);
                }

                int numeroTicket = epsonFP.CerrarTicket();

                numeroFacturaRespuesta.Add(numeroTicket);
                return numeroFacturaRespuesta;
            }
        }
    }
}
