using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Data.Repository
{
    public abstract class BaseRepository<T>
    {
        protected readonly T _context;

        public BaseRepository(T ventaContext)
        {
            _context = ventaContext;
        }
    }
}
