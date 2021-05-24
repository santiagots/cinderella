using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Enum;
using Ventas.Core.Model.NotaPedidoAgreggate;

namespace Ventas.Core.Interfaces
{
    public interface INotaPedidoRepository
    {
        Task GuardarAsync(NotaPedido notaPedido);

        Task<NotaPedido> ObtenerAsync(long idNotaPedido);

        Task<List<NotaPedido>> BuscarAsync(int idClienteMayorista, NotaPedidoEstado? estado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);

        Task<List<NotaPedido>> BuscarAsync(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);

        Task<List<NotaPedido>> BuscarAsync(int idSucursal, int? idProducto, List<NotaPedidoEstado> estados, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);

        Task<decimal?> ObtenerMontoTotalSinIva(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente);

        Task<decimal?> ObtenerMontoTotal(int idSucursal, int? numero, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente);

        int ObtenerCantidad(int idSucursal, List<NotaPedidoEstado> estado);

        Task ActualizarAsync(NotaPedido notaPedidoModel);
    }
}
