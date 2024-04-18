using Comex.Core.Enum;
using Comex.Core.Model.ComexAggregate;
using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Core.Interfaces
{
    public interface IOrdenCompraRepository
    {
        Task<List<OrdenCompra>> BuscarAsync(int? idOrden, int? idSucursal, int? idSuplier, int? idEmpleado, EstadoOrdenCompra? estado, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);
        Task GuardarAsync(OrdenCompra ordenCompra);
    }
}
