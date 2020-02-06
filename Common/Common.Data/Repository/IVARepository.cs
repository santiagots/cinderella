using Common.Core.Interfaces;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class IVARepository : BaseRepository<CommonContext>, IIVARepository
    {
        public IVARepository(CommonContext context) : base(context)
        {
        }

        public IList<IVA> Obtener()
        {
            return _context.IVA.OrderBy(x => x.Valor).ToList();
        }

        public IVA Obtener(decimal porcentaje)
        {
            return _context.IVA.FirstOrDefault(x => x.Valor == porcentaje);
        }
    }
}
