using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.ExternalService.Contracts
{
    public class AfipObtenerCAERequest
    {
        public TipoCliente TipoCliente { get; set; }
        public TipoDocumentoFiscal TipoDocumentoFiscal { get; set; }
        public CondicionIVA CondicionIVA { get; set; }
        public string Cuit { get; set; }
        public decimal ImporteNeto { get; set; }
        public List<AfipAlicuotaIvaRequest> AlicuotasIva { get; set; }
        public int NumeroFacturaOrigen { get; set; }
        public int PuntoVentaOrigen { get; set; }
        public string PasswordCertificado { get; set; }
        public string RutaCertificado { get; set; }
    }
}
