using Common.Core.Enum;
using Factura.Device.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factura.Device.Printer
{
    interface IEpsonTM: IDisposable
    {
        int ObtenreNumeroFactura(List<ProductoTicketRequest> productos, List<PagoTicketRequest> pagos, out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto);
        int ObtenerNumeroNotaCretido(List<ProductoTicketRequest> productos, List<PagoTicketRequest> pagos, out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto);
        void AbrirTicket();
        void AbrirNotaCredito();
        int CerrarTicket(out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto);
        int CerrarNotaCredito(out string TipoFactura, out decimal MontoTotal, out decimal MontoIvaTotal, out decimal MontoVuelto);
        void SubtotalTicket();
        void SubtotalNotaCredito();
        void DescuentosTicket(string descripcion, decimal descuento, decimal iva);
        void RecargosTicket(string descripcion, decimal recargo, decimal iva);
        void DescuentosNotaCredito(string descripcion, decimal descuento, decimal iva);
        void RecargosNotaCredito(string descripcion, decimal recargo, decimal iva);
        void PagarTicket(TipoPago TipoPago, int numeroCuotas, decimal montoPago);
        void AgregarItemTicket(string codigoItem, string descripcion, int cantidad, decimal precioUnitario, decimal iva);
        void AgregarItemNotaCredito(string codigoItem, string descripcion, int cantidad, decimal precioUnitario, decimal iva);
        void CierreX();
        void CierreZ();
        void CierreZPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta);
        void CierreZPorRangoDeJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta);
        void Informacionjornada();
        void ObtenerEstados();
        void CintaTestigoDigitalPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos);
        void CintaTestigoDigitalPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos);
        void DuplicadosDocumentosTipoAPorFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos);
        void DuplicadosDocumentosTipoAPorJornada(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos);
        void ResumenTotalesPorRangoDeFecha(DateTime fechaDesde, DateTime fechaHasta, out string nombreArchivo, out StringBuilder datos);
        void ResumenTotalesPorRangoDeJornadaFiscal(int controladorFiscalJornadaDesde, int controladorFiscalJornadaHasta, out string nombreArchivo, out StringBuilder datos);
        void ObtenerMemoriaTransacciones(out int cintaTestigoDigitalDisponiblesDesde, out int cintaTestigoDigitalDisponiblesHasta, out int descargarDuplicadosTipoADisponiblesDesde, out int descargarDuplicadosTipoADisponiblesHasta, out int resumenTotalesDisponiblesDesde, out int resumenTotalesDisponiblesHasta, out int jornadasDescargadasCompletamenteDesde, out int jornadasDescargadasCompletamenteHasta, out int jornadasBorradasDesde, out int jornadasBorradasHasta);
        void BorradoJornadasMemoriaTransacciones(int borradasJornadasHasta);
    }
}
