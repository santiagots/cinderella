using Common.Core.Enum;
using Stock.Core.Model.BaseAgreggate;
using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo = Stock.Core.Model.BaseAgreggate;

namespace Stock.Core.Interface
{
    public interface IStockRepository
    {
        Task<List<Modelo.Stock>> BuscarAsync(int? idSucursal, string codigoNombreProducto, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);
        Task ActualizarAsync(Modelo.Stock stockModel);
        Task GuardarAsync(Modelo.Stock stockModel);
    }
}
