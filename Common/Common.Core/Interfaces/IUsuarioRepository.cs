using Common.Core.Model;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> ObtenerAsync(int IdUsuario);
    }
}
