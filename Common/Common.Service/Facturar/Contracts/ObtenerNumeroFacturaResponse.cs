using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service.Facturar.Contracts
{
    public class ObtenerNumeroFacturaResponse
    {
        public List<int> NumeroFactura { get; set; } = new List<int>();
        public string CAE { get; set; }
        public DateTime? FechaVencimientoCAE { get; set; }
    }
}
