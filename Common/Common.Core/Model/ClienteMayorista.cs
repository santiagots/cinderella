using Common.Core.Enum;

namespace Common.Core.Model
{
    public class ClienteMayorista : Entity<int>
    {
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public CondicionIVA CondicionIVA { get; set; }
        public int Comision { get; set; }
        public int Bonificacion { get; set; }
        public int Lista { get; set; }
        public string CondicionPago { get; set; }
        public int ListaPrecio { get; set; }
        public int? IdDomicilioFacturacion { get; set; }
        public Domicilio DomicilioFacturacion { get; set; }
        public int? IdDomicilioEntrega { get; set; }
        public Domicilio DomicilioEntrega { get; set; }
        public string Observaciones { get; set; }
        public bool Habilitado { get; set; }
    }
}
