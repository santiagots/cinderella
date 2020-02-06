using System;
using System.Collections.Generic;

namespace Factura.Service.NotaCredito.Contracts
{
    public class ObtenerNumeroNotaCretidoResponse
    {
        public List<int> NumeroNotaCredito { get; set; } = new List<int>();
        public string CAE { get; set; }
        public DateTime? FechaVencimientoCAE { get; set; }
    }
}
