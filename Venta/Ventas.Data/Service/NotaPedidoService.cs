using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Enum;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.CuentaCorrienteAggregate;
using Ventas.Core.Model.NotaPedidoAgreggate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class NotaPedidoService
    {
        public static Task<List<NotaPedido>> ObtenerAsync(int idSucursal, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext());
            return NotaPedidoRepository.ObtenerAsync(idSucursal, estado, tipoCliente, fechaDesde, fechaHasta, idVendedor, nombreCliente, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }

        public static Task<List<NotaPedido>> ObtenerAsync(TipoBase tipoBase, int idClienteMayorista, NotaPedidoEstado? estado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext(tipoBase));
            return NotaPedidoRepository.ObtenerAsync(idClienteMayorista, estado, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }
    }
}
