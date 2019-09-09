using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Device.Printer
{
    internal class EpsonFPCommand
    {
        private EpsonFPCommand(string cmd, string cmdExt)
        {
            this.Cmd = cmd;
            this.CmdExt = cmdExt;
        }

        internal string Cmd { get; private set; }

        internal string CmdExt { get; private set; }

        internal static EpsonFPCommand CierreDeCaja = new EpsonFPCommand("\x8\x2", "\x0\x1");

        internal static EpsonFPCommand CierreDeDia = new EpsonFPCommand("\x8\x1", "\xC\x0");

        internal static EpsonFPCommand CierreDeDiaPorFecha = new EpsonFPCommand("\x8\x10", "\x0\x1");

        internal static EpsonFPCommand Informacionjornada = new EpsonFPCommand("\x8\x3", "\xC\x0");

        internal static EpsonFPCommand ObtenerEstadoImpresora = new EpsonFPCommand("\x0\x1", "\x0\x0");

        internal static EpsonFPCommand AbrirTicket = new EpsonFPCommand("\xB\x1", "\x0\x0");

        internal static EpsonFPCommand AbrirNotaCredito = new EpsonFPCommand("\xD\x1", "\x0\x0");

        internal static EpsonFPCommand ItemTicket = new EpsonFPCommand("\xB\x2", "\x0\x8");

        internal static EpsonFPCommand ItemNotaCredito = new EpsonFPCommand("\xD\x2", "\x1\x8");

        internal static EpsonFPCommand DescuentoTicket = new EpsonFPCommand("\xB\x4", "\x0\x0");

        internal static EpsonFPCommand DescuentoNotaCredito = new EpsonFPCommand("\xD\x4", "\x0\x0");

        internal static EpsonFPCommand RecargoTicket = new EpsonFPCommand("\xB\x4", "\x0\x1");

        internal static EpsonFPCommand RecargoNotaCredito = new EpsonFPCommand("\xD\x4", "\x0\x1");

        internal static EpsonFPCommand SubtotalTicket = new EpsonFPCommand("\xB\x3", "\x0\x8");

        internal static EpsonFPCommand SubtotalNotaCredito = new EpsonFPCommand("\xD\x3", "\x0\x1");

        internal static EpsonFPCommand Pago = new EpsonFPCommand("\xB\x5", "\x0\x0");

        internal static EpsonFPCommand CerraTicket = new EpsonFPCommand("\xB\x6", "\x0\x3");

        internal static EpsonFPCommand CerraNotaCredito = new EpsonFPCommand("\xD\x6", "\x0\x3");

        internal static EpsonFPCommand CloseTicket1 = new EpsonFPCommand("\xB\x6", "\x0\x1");

        internal static EpsonFPCommand CloseTicket2 = new EpsonFPCommand("\x8\xA", "\x0\x0");
    }
}

