using Common.Core.Interfaces;
using Common.Core.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Common.Data.Repository
{
    public class AfipTokenAccesRepository : BaseRepository<CommonContext>, IAfipTokenAccesRepository
    {
        public AfipTokenAccesRepository(CommonContext commonContext) : base(commonContext)
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
