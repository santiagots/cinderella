using System;
using System.Text;
using Factura.Service.Factura.Contracts;

namespace Factura.Service.Factura
{
    public interface IFacturarStrategy
    {
        ObtenerNumeroFacturaResponse ObtenerNumeroFactura(ObtenerNumeroFacturaRequest request);
        void ObtenerCierreZ();
        void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta);
        void ObtenerCierreZPorJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta);
        void ObtenerCintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos);
        void ObtenerCintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos);
        void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos);
        void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos);
        void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos);
        void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos);
        void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta);
        void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta);
    }
}