using Common.Core.Enum;
using Common.Core.ValueObjects;
using System.Collections.Generic;
using System;
using System.Text;

namespace Common.Service.Facturar
{
    public interface IFacturarStrategy
    {
        List<int> ObtenerNumeroFactura(TipoCliente tipoCliente, CondicionIVA condicionesIVA, List<TicketPago> pagos, IList<TicketProducto> productos, decimal porcentajeFacturacion, string nombreYApellido, string direccion, string localidad, string cuit);
        void ObtenerCierreZ();
        void ObtenerCierreZPorFecha(DateTime fechaDesde, DateTime fechaHasta);
        void ObtenerCierreZPorJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta);
        void ObtenerCintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos);
        void ObtenerCintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos);
        void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos);
        void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos);
        void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombre, out StringBuilder datos);
        void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombre, out StringBuilder datos);
    }
}