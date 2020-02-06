using Common.Core.Enum;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common.Core.Exceptions;
using Factura.Device.Printer;
using Factura.Service.Factura.Contracts;
using Factura.Service.Common.Contracts;

namespace Factura.Service.Factura
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

        public void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                epsonFP.BorradoJornadasMemoriaTransacciones(borradasJornadasHasta);
            }
        }

        public void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                if (fechaDesde > fechaHasta)
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

        public ObtenerNumeroFacturaResponse ObtenerNumeroFactura(ObtenerNumeroFacturaRequest request)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter(request.TipoCliente, request.CondicionIVA, request.PorcentajeFacturacion, request.NombreYApellido, request.Direccion, request.Localidad, request.Cuit))
            {

                epsonFP.AbrirTicket();

                foreach (ProductoRequest producto in request.Productos)
                {
                    epsonFP.AgregarItemTicket(producto.Codigo, producto.Nombre, producto.Cantidad, producto.Monto, producto.IVA.Valor);
                }

                foreach (ProductoRequest producto in request.Productos)
                { 
                    if (producto.Descuento > 0)
                        epsonFP.DescuentosTicket(producto.Nombre, producto.Descuento, producto.IVA.Valor);

                    if (producto.CFT > 0)
                        epsonFP.RecargosTicket(producto.Nombre, producto.CFT, producto.IVA.Valor);
                }

                //if (!request.Pagos.Any(x => x.Descuento > 0) && !request.Pagos.Any(x => x.CFT > 0))
                    epsonFP.SubtotalTicket();

                foreach (PagoRequest pago in request.Pagos.Where(x => x.TipoPago != TipoPago.Bonificacion))
                {
                    decimal monto = (pago.Monto - pago.Descuento + pago.CFT) * request.PorcentajeFacturacion + pago.IVA;
                    epsonFP.PagarTicket(pago.TipoPago, pago.NumeroCuotas, monto);
                }

                int numeroTicket = epsonFP.CerrarTicket();

                return new ObtenerNumeroFacturaResponse(){
                    NumeroFactura = new List<int>() { numeroTicket }
                };
            }
        }

        public void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta)
        {
            using (EpsonPrinter epsonFP = new EpsonPrinter())
            {
                epsonFP.ObtenerMemoriaTransacciones(out cintaTestigoDigitalDisponiblesDesde, out cintaTestigoDigitalDisponiblesHasta, out descargarDuplicadosTipoADisponiblesDesde, out descargarDuplicadosTipoADisponiblesHasta, out resumenTotalesDisponiblesDesde, out resumenTotalesDisponiblesHasta, out jornadasDescargadasCompletamenteDesde, out jornadasDescargadasCompletamenteHasta, out jornadasBorradasDesde, out jornadasBorradasHasta);
            }
        }
    }
}
