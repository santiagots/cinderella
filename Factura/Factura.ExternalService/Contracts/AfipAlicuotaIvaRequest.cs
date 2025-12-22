namespace Factura.ExternalService.Contracts
{
    public class AfipAlicuotaIvaRequest
    {
        public int Codigo { get; set; }
        public decimal Monto { get; set; }
        public decimal IvaMonto { get; set; }
    }
}
