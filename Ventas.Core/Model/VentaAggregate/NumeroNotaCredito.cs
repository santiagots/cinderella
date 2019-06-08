using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.VentaAggregate
{
    public class NumeroNotaCredito : Entity<long>
    {
        public int Numero { get; protected set; }
        public long IdNotaCredito { get; protected set; }
        public NotaCredito NotaCredito { get; protected set; }

        protected NumeroNotaCredito()
        {
        }

        public NumeroNotaCredito(int numero, long idNotaCredito) : base(true)
        {
            this.Numero = numero;
            this.IdNotaCredito = idNotaCredito;
        }
    }
}
