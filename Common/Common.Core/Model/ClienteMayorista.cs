using Common.Core.Enum;
using System;
using System.Reflection;

namespace Common.Core.Model
{
    public class ClienteMayorista : Entity<int>
    {
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public CondicionIVA CondicionIVA { get; set; }
        public decimal PorcentajeComision { get; set; }
        public decimal PorcentajeBonificacion { get; set; }
        public decimal PorcentajeLista { get; set; }
        public string CondicionPago { get; set; }
        public int IdListaPrecio { get; set; }
        public ListaPrecio ListaPrecio { get; set; }
        public int? IdDomicilioFacturacion { get; set; }
        public Domicilio DomicilioFacturacion { get; set; }
        public int? IdDomicilioEntrega { get; set; }
        public Domicilio DomicilioEntrega { get; set; }
        public string Observaciones { get; set; }
        public decimal MontoCuentaCorriente { get; set; }
        public decimal MontoNotasPedido { get; set; }
        public int? IdTransporte { get; set; }
        public Transporte Transporte { get; set; }
        public bool Habilitado { get; set; }

        public void DebitarSaldoCuentaCorriente(decimal monto)
        {
            MontoCuentaCorriente -= monto;
        }

        public void AcreditarSaldoCuentaCorriente(decimal monto)
        {
            MontoCuentaCorriente += monto;
        }
    }
}
