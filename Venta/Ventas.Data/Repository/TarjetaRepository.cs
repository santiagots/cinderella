using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class TarjetaRepository : BaseRepository<VentaContext>, ITarjetaRepository
    {
        public TarjetaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public IEnumerable<Tarjeta> Obtener()
        {
            return _context.Tarjeta.Where(x => x.Habilitado).ToList();
        }
    }
}
