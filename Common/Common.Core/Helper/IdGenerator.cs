using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Core.Helper
{
    public class IdGenerator
    {
        public static int ID_SUCURSAL { get; set; }

        public static long ObtenerId()
        {
            if (ID_SUCURSAL == 0)
                throw new InvalidOperationException("Error al general un ID, no se encuentra definida un numero de sucursal");

            //Duerno la ejecucion 10 ms para asegurarme que no se generen claves duplicadas
            Thread.Sleep(10);
            return long.Parse($"{ID_SUCURSAL}{DateTime.Now.ToString("yyyMMddHHmmssfff")}");
        }    
    }
}
