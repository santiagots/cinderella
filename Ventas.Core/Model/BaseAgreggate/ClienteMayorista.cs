using Common.Core.Enum;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.BaseAgreggate
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
