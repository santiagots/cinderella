
using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IBancoRepository
    {
        Task<List<Banco>> ObtenerAsync();
    }
}
