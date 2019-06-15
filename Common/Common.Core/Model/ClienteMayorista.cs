using Common.Core.Enum;

namespace Common.Core.Model
{
    public class ClienteMayorista : Entity<int>
    {
        public string RazonSocial { get; internal set; }
        public string Cuit { get; internal set; }
        public CondicionIVA CondicionIVA { get; internal set; }
        public int? IdDireccionFacturacion { get; internal set; }
        public Domicilio DomicilioFacturacion { get; internal set; }
    }
}
