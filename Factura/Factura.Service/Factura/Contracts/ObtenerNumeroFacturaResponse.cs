using System;
using System.Collections.Generic;

namespace Factura.Service.Factura.Contracts
{
    public class ObtenerNumeroFacturaResponse
    {
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public List<int> NumeroFactura { get; set; } = new List<int>();
        public string CAE { get; set; }
        public DateTime? FechaVencimientoCAE { get; set; }
    }
}
