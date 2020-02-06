using System;
using System.Collections.Generic;

namespace Factura.Service.Factura.Contracts
{
    public class ObtenerNumeroFacturaResponse
    {
        public List<int> NumeroFactura { get; set; } = new List<int>();
        public string CAE { get; set; }
        public DateTime? FechaVencimientoCAE { get; set; }
    }
}
