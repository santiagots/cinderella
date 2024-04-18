using Comex.Core.Enum;
using Comex.Core.Interfaces;
using Comex.Core.Model.ComexAggregate;
using Comex.Data.Repository;
using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Data.Service
{
    public class OrdenCompraService
    {
        public static Task<List<OrdenCompra>> BuscarAsync(int? idOrden, int? idSucursal, int? idSuplier, int? idEncargado, EstadoOrdenCompra? estado, DateTime fechaDesde, DateTime fechaHasta, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IOrdenCompraRepository ordenCompraRepository = new OrdenCompraRepository(new ComexContext(TipoBase.Remota));
            return ordenCompraRepository.BuscarAsync(idOrden, idSucursal, idSuplier, idEncargado, estado, fechaDesde, fechaHasta, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }

        public static Task GuardarAsync (OrdenCompra ordenCompra)
        {        
            IOrdenCompraRepository ordenCompraRepository = new OrdenCompraRepository(new ComexContext(TipoBase.Remota));
            return ordenCompraRepository.GuardarAsync(ordenCompra);
        }
    }
}
