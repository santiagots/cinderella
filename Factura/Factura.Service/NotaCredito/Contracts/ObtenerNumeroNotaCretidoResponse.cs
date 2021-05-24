using System;
using System.Collections.Generic;

namespace Factura.Service.NotaCredito.Contracts
{
    public class ObtenerNumeroNotaCretidoResponse
    {
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public List<int> NumeroNotaCredito { get; set; } = new List<int>();
        public string CAE { get; set; }
        public DateTime? FechaVencimientoCAE { get; set; }
    }
}
