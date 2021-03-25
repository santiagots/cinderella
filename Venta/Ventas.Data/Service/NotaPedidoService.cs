using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Enum;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.NotaPedidoAgreggate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class NotaPedidoService
    {
        public static Task ActualizarAsync(NotaPedido notaPedidoModel)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext());
            return NotaPedidoRepository.ActualizarAsync(notaPedidoModel);
        }

        public static Task GuardarAsync(NotaPedido notaPedidoModel)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext());
            return NotaPedidoRepository.GuardarAsync(notaPedidoModel);
        }

        public static Task<NotaPedido> ObtenerAsync(long idNotaPedido)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext());
            return NotaPedidoRepository.ObtenerAsync(idNotaPedido);
        }

        public static Task<List<NotaPedido>> BuscarAsync(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext());
            return NotaPedidoRepository.BuscarAsync(idSucursal, numero, estado, tipoCliente, fechaDesde, fechaHasta, idVendedor, nombreCliente, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }

        public static Task<List<NotaPedido>> BuscarAsync(TipoBase tipoBase, int idClienteMayorista, NotaPedidoEstado? estado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext(tipoBase));
            return NotaPedidoRepository.BuscarAsync(idClienteMayorista, estado, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }

        public static Task<decimal?> ObtenerMontoTotal(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext());
            return NotaPedidoRepository.ObtenerMontoTotal(idSucursal, numero, estado, tipoCliente, fechaDesde, fechaHasta, idVendedor, nombreCliente);
        }

        public static Task<decimal?> ObtenerMontoTotalSinIva(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente)
        {
            INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(new VentaContext());
            return NotaPedidoRepository.ObtenerMontoTotalSinIva(idSucursal, numero, estado, tipoCliente, fechaDesde, fechaHasta, idVendedor, nombreCliente);
        }
    }
}
