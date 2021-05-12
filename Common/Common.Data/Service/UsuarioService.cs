using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class UsuarioService
    {
        public static Task<Usuario> ObtenerAsync(int IdUsuario)
        {
            IUsuarioRepository usuarioRepository = new UsuarioRepository(new CommonContext());
            return usuarioRepository.ObtenerAsync(IdUsuario);
        }
    }
}
