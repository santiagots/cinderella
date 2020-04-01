using System;

namespace Factura.ExternalService.Contracts
{
    public class AfipObtenerCAEResponse
    {
        public int NumeroComprobante { get; set; }
        public string Codigo {get; set;}
        public DateTime FechaVencimiento {get; set;}
    }
}
