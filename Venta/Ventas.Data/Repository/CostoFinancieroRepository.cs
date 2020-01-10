using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class CostoFinancieroRepository : BaseRepository<VentaContext>, ICostoFinancieroRepository
    {
        public CostoFinancieroRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public IEnumerable<CostoFinanciero> Obtener(int idTarjeta)
        {
            return _context.CostoFinanciero.Where(x => x.IdTarjeta == idTarjeta).ToList();
        }
    }
}
