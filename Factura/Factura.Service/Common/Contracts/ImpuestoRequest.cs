namespace Factura.Service.Common.Contracts
{
    public class ImpuestoRequest
    {
        public string Descripcion { get; set; }

        public decimal Monto { get; set; }
    }
}
