
using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Device.Printer
{
    interface IEpsonTM: IDisposable
    {
        void AbrirTicket();
        void AbrirNotaCredito();
        int CerrarTicket();
        int CerrarNotaCredito();
        void SubtotalTicket();
        void SubtotalNotaCredito();
        void DescuentosTicket(string descripcion, decimal descuento);
        void RecargosTicket(string descripcion, decimal recargo);
        void DescuentosNotaCredito(string descripcion, decimal descuento);
        void RecargosNotaCredito(string descripcion, decimal recargo);
        void PagarTicket(TipoPago TipoPago, int numeroCuotas, decimal montoPago);
        void AgregarItemTicket(string codigoItem, string descripcion, int cantidad, decimal precioUnitario);
        void AgregarItemNotaCredito(string codigoItem, string descripcion, int cantidad, decimal precioUnitario);
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
