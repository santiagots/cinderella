using Common.Core.Enum;
using Stock.Core.Model.BaseAgreggate;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Core.Interface
{
    public interface IBitacoraRepository
    {
        Task<List<Bitacora>> BuscarAsync(int idSucursal, DateTime? fechaDesde, DateTime? fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);

        Task<Decimal?> TotalAsync(int idSucursal, DateTime? fechaDesde, DateTime? fechaHasta);
    }
}
