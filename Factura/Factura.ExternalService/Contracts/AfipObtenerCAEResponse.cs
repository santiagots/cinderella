using System;

namespace Factura.ExternalService.Contracts
{
    public class AfipObtenerCAEResponse
    {
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public int NumeroComprobante { get; set; }
        public string Codigo {get; set;}
        public DateTime FechaVencimiento {get; set;}
    }
}
