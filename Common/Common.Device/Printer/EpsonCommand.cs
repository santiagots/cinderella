using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Device.Printer
{
    internal class EpsonCommand
    {
        internal EpsonCommand(string cmd, string cmdExt)
        {
            this.Cmd = cmd;
            this.CmdExt = cmdExt;
        }

        internal string Cmd { get; private set; }

        internal string CmdExt { get; private set; }
    }
}
