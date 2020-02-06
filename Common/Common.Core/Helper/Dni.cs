using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Helper
{
    public class Dni
    {
        public static bool Validar(string dni)
        {
            if (!string.IsNullOrWhiteSpace(dni)
                && long.TryParse(dni, out long valor)
                && dni.Length >= 6
                && dni.Length <= 9)
                return true;
            else
                return false;
        }
    }
}
