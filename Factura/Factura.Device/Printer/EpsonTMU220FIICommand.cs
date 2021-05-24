﻿
namespace Factura.Device.Printer
{
    internal class EpsonTMU220FIICommand
    {
        internal static EpsonCommand CierreDeCaja = new EpsonCommand("\x8\x2", "\x0\x1");

        internal static EpsonCommand CierreZ = new EpsonCommand("\x8\x1", "\xC\x0");

        internal static EpsonCommand CierreZPorRangoDeFecha = new EpsonCommand("\x8\x10", "\x0\x1");

        internal static EpsonCommand CierreZPorRangoDeJornada = new EpsonCommand("\x8\x11", "\x0\x1");

        internal static EpsonCommand Informacionjornada = new EpsonCommand("\x8\x3", "\xC\x0");

        internal static EpsonCommand ObtenerEstadoImpresora = new EpsonCommand("\x0\x1", "\x0\x0");

        internal static EpsonCommand AbrirTicket = new EpsonCommand("\xB\x1", "\x0\x0");

        internal static EpsonCommand AbrirNotaCredito = new EpsonCommand("\xD\x1", "\x0\x0");

        internal static EpsonCommand ItemTicket = new EpsonCommand("\xB\x2", "\x0\x18");

        internal static EpsonCommand ItemTicketRetorno = new EpsonCommand("\xB\x2", "\x0\x1C");

        internal static EpsonCommand ItemNotaCredito = new EpsonCommand("\xD\x2", "\x0\x18");

        internal static EpsonCommand ItemNotaCreditoRetorno = new EpsonCommand("\xD\x2", "\x0\x1C");

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

