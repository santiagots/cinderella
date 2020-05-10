using Common.Core.Model;

namespace Factura.Service.Common.Contracts
{
    public class ProductoRequest
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoUnitario { get; set; }
        public decimal DescuentoUnitario { get; set; }
        public decimal CFTUnitario { get; set; }
        public decimal MontoTotal { get => MontoUnitario * Cantidad; }
        public decimal DescuentoTotal { get => DescuentoUnitario * Cantidad; }
        public decimal CFTTotal { get => CFTUnitario * Cantidad; }
        public decimal NetoTotal { get => MontoTotal - DescuentoTotal + CFTTotal; }
        public IVA IVA { get; set; }
    }
}
