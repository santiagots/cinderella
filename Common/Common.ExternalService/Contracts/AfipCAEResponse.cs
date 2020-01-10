using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ExternalService.Contracts
{
    public class AfipCAEResponse
    {
        public int NumeroComprobante { get; set; }
        public string Codigo {get; set;}
        public DateTime FechaVencimiento {get; set;}
    }
}
