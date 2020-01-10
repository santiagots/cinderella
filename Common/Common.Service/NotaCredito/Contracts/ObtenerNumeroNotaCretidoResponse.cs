using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service.NotaCredito.Contracts
{
    public class ObtenerNumeroNotaCretidoResponse
    {
        public List<int> NumeroNotaCredito { get; set; } = new List<int>();
        public string CAE { get; set; }
        public DateTime? FechaVencimientoCAE { get; set; }
    }
}
