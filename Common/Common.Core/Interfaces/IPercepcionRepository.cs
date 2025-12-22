using Common.Core.Enum;
using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IPercepcionRepository
    {
        Task<List<Percepcion>> Buscar(string provincia, CondicionIVA? condicionIVA, bool? habilitado);
        Task Guardar(Percepcion percepcion);
    }
}
