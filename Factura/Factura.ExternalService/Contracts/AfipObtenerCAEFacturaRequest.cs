using Common.Core.Enum;
using System.Collections.Generic;

namespace Factura.ExternalService.Contracts
{
    public class AfipObtenerCAEFacturaRequest
    {
        public TipoCliente TipoCliente { get; set; }
        public TipoDocumentoFiscal TipoDocumentoFiscal { get; set; }
        public CondicionIVA CondicionIVA { get; set; }
        public string Cuit { get; set; }
        public decimal ImporteNeto { get; set; }
        public List<AfipAlicuotaIvaRequest> AlicuotasIva { get; set; }
        public string PasswordCertificado { get; set; }
        public string RutaCertificado { get; set; }
    }
}
