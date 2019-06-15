using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.VentaAggregate
{
    public class CostoFinanciero: Entity<int>
    {
        public int IdTarjeta { get; private set; }
        public int NumeroCuota { get; private set; }
        public double PorcentajeRecargo { get; private set; }
    }
}
