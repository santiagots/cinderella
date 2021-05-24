using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.VentaAggregate
{
    public class NumeroFactura : Entity<long>
    {
        public int Numero { get; protected set; }
        public long IdFactura { get; protected set; }
        public Factura Factura { get; protected set; }

        protected NumeroFactura()
        {
        }

        public NumeroFactura(int numero, long idFactura) : base(true)
        {
            this.Numero = numero;
            this.IdFactura = idFactura;
        }
    }
}
