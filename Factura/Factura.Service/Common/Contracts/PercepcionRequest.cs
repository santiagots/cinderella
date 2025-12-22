using Common.Core.Enum;

namespace Factura.Service.Common.Contracts
{
    public class PercepcionRequest
    {
        public TipoPercepcionFactura Tipo { get; protected set; }
        public string Comcepto { get; protected set; }
        public decimal Alicuota { get; set; }
        public decimal Monto { get; set; }

        public PercepcionRequest(TipoPercepcionFactura tipo, string comcepto, decimal alicuota, decimal monto)
        {
            Tipo = tipo;
            Comcepto = comcepto;
            Alicuota = alicuota;
            Monto = monto;
        }
    }
}
