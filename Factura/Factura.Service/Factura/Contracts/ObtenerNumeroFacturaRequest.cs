using Common.Core.Enum;
using Factura.Service.Common.Contracts;
using System.Collections.Generic;

namespace Factura.Service.Factura.Contracts
{
    public class ObtenerNumeroFacturaRequest
    {
        public TipoCliente TipoCliente { get; set; }
        public CondicionIVA CondicionIVA { get; set; }
        public List<PagoRequest> Pagos { get; set; }
        public List<ProductoRequest> Productos { get; set; }
        public decimal PorcentajeFacturacion { get; set; }
        public string NombreYApellido { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Cuit { get; set; }
    }
}
