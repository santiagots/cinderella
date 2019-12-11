using System.Collections.Generic;
using Ventas.Core.Model.BaseAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface IStockRepository
    {
        void Actualizar(IEnumerable<Stock> stocks);
    }
}
