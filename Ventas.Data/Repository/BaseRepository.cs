using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Data.Repository
{
    public abstract class BaseRepository
    {
        protected readonly VentaContext _context;

        public BaseRepository(VentaContext ventaContext)
        {
            _context = ventaContext;
        }
    }
}
