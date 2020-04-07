using Common.Core.Enum;
using Factura.Service.Factura.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.Service.Factura
{
    public class FacturarService
    {
        private IFacturarStrategy facturarStrategy;

        public FacturarService(TipoFactura tiposFactura, string rutaCertificado, string passwordCertificado)
        {
            switch (tiposFactura)
            {
                case TipoFactura.Ticket:
                    facturarStrategy = new FacturarControladorFiscalStrategy();
                    break;
                case TipoFactura.Manual:
                    facturarStrategy = new FacturarManualStrategy();
                    break;
                case TipoFactura.Electronica:
                    facturarStrategy = new FacturarElectrinicaStrategy(rutaCertificado, passwordCertificado);
                    break;
                default:
                    throw new InvalidOperationException($"El método de facturación {tiposFactura.ToString()} no tiene un una forma de facturación definida.");
            }
        }

        public ObtenerNumeroFacturaResponse ObtenerNumeroFactura(ObtenerNumeroFacturaRequest request)
        {
            return facturarStrategy.ObtenerNumeroFactura(request);
        }

        public void ObtenerCierreZ()
        {
            facturarStrategy.ObtenerCierreZ();
        }

        public void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            facturarStrategy.ObtenerCierreZPorFecha(fechaDesde, fechaHasta);
        }

        public void ObtenerCierreZPorJornada(int ControladorFiscalJornadaDesde, int ControladorFiscalJornadaHasta)
        {
            facturarStrategy.ObtenerCierreZPorJornadaFiscal(ControladorFiscalJornadaDesde, ControladorFiscalJornadaHasta);
        }

        public void ObtenerCintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            facturarStrategy.ObtenerCintaTestigoDigitalPorFecha(fechaDesde, fechaHasta, out nombre, out datos);
        }

        public void ObtenerCintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            facturarStrategy.ObtenerCintaTestigoDigitalPorJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombre, out datos);
        }

        public void ObtenerDuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            facturarStrategy.DuplicadosDocumentosTipoAPorFecha(fechaDesde, fechaHasta, out nombre, out datos);
        }

        public void ObtenerDuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            facturarStrategy.DuplicadosDocumentosTipoAPorJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombre, out datos);
        }

        public void ObtenerResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos)
        {
            facturarStrategy.ResumenTotalesPorRangoDeFecha(fechaDesde, fechaHasta, out nombre, out datos);
        }

        public void ObtenerResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos)
        {
            facturarStrategy.ResumenTotalesPorRangoDeJornadaFiscal(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta, out nombre, out datos);
        }

        public void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta)
        {
            facturarStrategy.ObtenerMemoriaTransacciones(out cintaTestigoDigitalDisponiblesDesde, out cintaTestigoDigitalDisponiblesHasta, out descargarDuplicadosTipoADisponiblesDesde, out  descargarDuplicadosTipoADisponiblesHasta, out  resumenTotalesDisponiblesDesde, out  resumenTotalesDisponiblesHasta, out  jornadasDescargadasCompletamenteDesde, out  jornadasDescargadasCompletamenteHasta, out  jornadasBorradasDesde, out  jornadasBorradasHasta);
        }

        public void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta)
        {
            facturarStrategy.BorradoJornadasMemoriaTransacciones(borradasJornadasHasta);
        }
    }
}
