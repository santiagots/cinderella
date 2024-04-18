using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IColorRepository
    {
        Task Actualizar(Color color);
        Task<List<Color>> Buscar(string nombre);
    }
}
