using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.ExternalService.Contracts
{
    public class AfipAlicuotaIvaRequest
    {
        public int Codigo { get; set; }
        public decimal Monto { get; set; }
        public decimal IvaMonto { get; set; }
    }
}
