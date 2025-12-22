using Common.Core.Enum;

namespace Factura.ExternalService.Contracts
{
    public class AfipTributoRequest
    {
        public short Codigo { get; set; }
        public string Comcepto { get; set; }
        public decimal Alicuota { get; set; }
        public decimal Monto { get; set; }
    }
}
