namespace Factura.Device.Printer
{
    internal class EpsonTMT900FACommand
    {
        internal static EpsonCommand CierreDeCaja = new EpsonCommand("\x8\x2", "\x0\x1");

        internal static EpsonCommand CierreZ = new EpsonCommand("\x8\x1", "\x0\x0");

        internal static EpsonCommand CierrZPorRangoDeFecha = new EpsonCommand("\x8\x12", "\x0\x3");

        internal static EpsonCommand CierrZPorRangoDeJornadaFiscal = new EpsonCommand("\x8\x13", "\x0\x3");

        internal static EpsonCommand CierrZContinuarReporte = new EpsonCommand("\x8\x14", "\x0\x0");

        internal static EpsonCommand CierrZFinalizarReporte = new EpsonCommand("\x8\x15", "\x0\x0");

        internal static EpsonCommand CintaTestigoDigitalPorRangoDeFecha = new EpsonCommand("\x9\x51", "\x0\x0");

        internal static EpsonCommand CintaTestigoDigitalPorRangoDeJornadaFiscal = new EpsonCommand("\x9\x52", "\x0\x0");

        internal static EpsonCommand DuplicadosDocumentosTipoAPorRangoDeFecha = new EpsonCommand("\x9\x51", "\x0\x2");

        internal static EpsonCommand DuplicadosDocumentosTipoAPorRangoDeJornadaFiscal = new EpsonCommand("\x9\x52", "\x0\x2");

        internal static EpsonCommand ResumenTotalesPorRangoDeFecha = new EpsonCommand("\x9\x51", "\x0\x4");

        internal static EpsonCommand ResumenTotalesPorRangoDeJornadaFiscal = new EpsonCommand("\x9\x52", "\x0\x4");

        internal static EpsonCommand InformacionMemoriaTransacciones = new EpsonCommand("\x9\x15", "\x0\x0");

        internal static EpsonCommand BorradoJornadasMemoriaTransacciones = new EpsonCommand("\x9\x10", "\x0\x0");

        internal static EpsonCommand ContinuarDescargaReporte = new EpsonCommand("\x9\x70", "\x0\x0");

        internal static EpsonCommand FinalizarDescargaReporte = new EpsonCommand("\x9\x71", "\x0\x0");

        internal static EpsonCommand CancelarDescargaReporte = new EpsonCommand("\x9\x72", "\x0\x0");

        internal static EpsonCommand Informacionjornada = new EpsonCommand("\x8\x3", "\xC\x0");

        internal static EpsonCommand ObtenerEstadoImpresora = new EpsonCommand("\x0\x1", "\x0\x0");

        internal static EpsonCommand AbrirTicket = new EpsonCommand("\xB\x1", "\x0\x0");

        internal static EpsonCommand AbrirNotaCredito = new EpsonCommand("\xD\x1", "\x0\x0");

        internal static EpsonCommand ItemTicket = new EpsonCommand("\xB\x2", "\x40\x10");

        internal static EpsonCommand ItemTicketRetorno = new EpsonCommand("\xB\x2", "\x40\x16");

        internal static EpsonCommand ItemNotaCredito = new EpsonCommand("\xD\x2", "\x40\x10");

        internal static EpsonCommand ItemNotaCreditoRetorno = new EpsonCommand("\xD\x2", "\x40\x16");

        internal static EpsonCommand DescuentoTicket = new EpsonCommand("\xB\x4", "\x0\x0"); 

        internal static EpsonCommand DescuentoNotaCredito = new EpsonCommand("\xD\x4", "\x0\x0");

        internal static EpsonCommand RecargoTicket = new EpsonCommand("\xB\x4", "\x0\x1");

        internal static EpsonCommand RecargoNotaCredito = new EpsonCommand("\xD\x4", "\x0\x1");

        internal static EpsonCommand SubtotalTicket = new EpsonCommand("\xB\x3", "\x0\x8");

        internal static EpsonCommand SubtotalNotaCredito = new EpsonCommand("\xD\x3", "\x0\x1");

        internal static EpsonCommand Pago = new EpsonCommand("\xB\x5", "\x0\x0");

        internal static EpsonCommand CerraTicket = new EpsonCommand("\xB\x6", "\x0\x3");

        internal static EpsonCommand CerraNotaCredito = new EpsonCommand("\xD\x6", "\x0\x3");
    }
}
