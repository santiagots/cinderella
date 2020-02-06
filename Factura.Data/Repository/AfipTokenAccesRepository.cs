using Common.Data.Repository;
using Factura.Core.Interfaces;
using Factura.Core.Model.AfipAgreggate;
using System;
using System.Data.Entity;
using System.Linq;

namespace Factura.Data.Repository
{
    public class AfipTokenAccesRepository : BaseRepository<FacturaContext>, IAfipTokenAccesRepository
    {
        public AfipTokenAccesRepository(FacturaContext facturaContext) : base(facturaContext)
        {          
        }
        public AfipTokenAcces Obtener(DateTime fechaGeneracion)
            => _context.AfipTokenAcces.FirstOrDefault(x => DbFunctions.TruncateTime(x.FechaGeneracion).Value == DbFunctions.TruncateTime(fechaGeneracion).Value);

        public void Guardar(AfipTokenAcces afipTokenAcces)
        {
            _context.AfipTokenAcces.Add(afipTokenAcces);
            _context.SaveChanges();
        }
    }
}
