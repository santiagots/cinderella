using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Model
{
    public class Feriado: Entity<int>
    {
        public DateTime Fecha { get; private set; }

        protected Feriado(): base(false)
        {
        }
    }
}
