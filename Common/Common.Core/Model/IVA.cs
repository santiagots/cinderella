using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Model
{
    public class IVA : Entity<int>
    {
        public decimal Valor { get; private set; }

        protected IVA() : base(false)
        {
        }
    }
}
