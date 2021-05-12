using Common.Core.Interfaces;
using Common.Core.Model;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    class UsuarioRepository : BaseRepository<CommonContext>, IUsuarioRepository
    {
        public UsuarioRepository(CommonContext context) : base(context)
        {
        }

        public Task<Usuario> ObtenerAsync(int IdUsuario)
        {
            return _context.Usuario.FirstOrDefaultAsync(x => x.Id == IdUsuario);
        }
    }
}
