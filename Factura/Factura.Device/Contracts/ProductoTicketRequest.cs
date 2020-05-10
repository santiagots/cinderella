namespace Factura.Device.Contracts
{
    public class ProductoTicketRequest
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal Descuento { get; set; }
        public decimal CFT { get; set; }
        public decimal Neto { get => Monto - Descuento + CFT; }
        public decimal IVA { get; set; }

        public ProductoTicketRequest(string codigo, string nombre, int cantidad, decimal monto, decimal descuento, decimal cft, decimal iva)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cantidad = cantidad;
            Monto = monto;
            Descuento = descuento;
            CFT = cft;
            IVA = iva;
        }
    }
}
