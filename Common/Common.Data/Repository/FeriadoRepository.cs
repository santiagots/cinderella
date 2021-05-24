using Common.Core.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;

namespace Common.Data.Repository
{
    public class FeriadoRepository : IFeriadoRepository
    {
        private readonly CommonContext _context;

        public FeriadoRepository(CommonContext commonContext)
        {
            _context = commonContext;
        }
        public bool EsFeriado(DateTime fecha)
        {
            return _context.Feriado.Any(x => DbFunctions.TruncateTime(x.Fecha) == DbFunctions.TruncateTime(fecha));
        }
    }
}
