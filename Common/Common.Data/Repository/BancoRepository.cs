using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    class BancoRepository : BaseRepository<CommonContext>, IBancoRepository
    {
        public BancoRepository(CommonContext commonContext) : base(commonContext)
        {
        }

        public Task<List<Banco>> ObtenerAsync()
        {
            return _context.Banco.Where(x => x.Habilitado).OrderBy(x => x.Nombre).ToListAsync();
        }
    }
}
