using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface ITipoProductoRepository
    {
        Task Actualizar(TipoProducto tipoProducto);
        Task<List<TipoProducto>> Buscar(string nombre);
    }
}
