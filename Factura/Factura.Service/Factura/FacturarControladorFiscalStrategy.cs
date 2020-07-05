using Common.Core.Enum;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common.Core.Exceptions;
using Factura.Device.Printer;
using Factura.Service.Factura.Contracts;
using Factura.Service.Common.Contracts;
using Factura.Device.Contracts;

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
                //pongo primer los productos con monto positibo y luego con monto negativo porque la controladora no puede operar con mantos negativos
                List<ProductoTicketRequest> productos = request.Productos
                    .Where(x => x.Cantidad >= 0)
                    .Select(x => new ProductoTicketRequest(x.Codigo, x.Nombre, x.Cantidad, x.MontoUnitario, x.DescuentoUnitario, x.CFTUnitario, x.IVA.Valor)).ToList();

                productos.AddRange(
                    request.Productos
                    .Where(x => x.Cantidad < 0)
                    .Select(x => new ProductoTicketRequest(x.Codigo, x.Nombre, x.Cantidad, x.MontoUnitario, x.DescuentoUnitario, x.CFTUnitario, x.IVA.Valor)).ToList());

                List<PagoTicketRequest> pagos = request.Pagos.Select(x => new PagoTicketRequest(x.TipoPago, x.NumeroCuotas, x.Monto, x.Descuento, x.CFT, x.IVA)).ToList();

                string TipoFactura = string.Empty;
                decimal MontoTotal = 0;
                decimal MontoIvaTotal = 0;
                decimal MontoVuelto = 0;

                int numeroFactura = epsonFP.ObtenreNumeroFactura(productos, pagos, out TipoFactura, out MontoTotal, out MontoIvaTotal, out MontoVuelto);

                return new ObtenerNumeroFacturaResponse() {
                    SubTotal = MontoTotal - MontoIvaTotal,
                    Iva = MontoIvaTotal,
                    Total = MontoTotal,
                    NumeroFactura = new List<int>() { numeroFactura }
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
