using Common.Core.Model;

namespace Factura.Service.Common.Contracts
{
    public class ProductoRequest
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal Descuento { get; set; }
        public decimal CFT { get; set; }
        public decimal Neto { get => Monto - Descuento + CFT; }
        public IVA IVA { get; set; }
    }
}
