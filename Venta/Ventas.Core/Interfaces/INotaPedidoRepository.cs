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
        void Guardar(NotaPedido notaPedido);

        Task<List<NotaPedido>> ObtenerAsync(int idClienteMayorista, NotaPedidoEstado? estado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);

        Task<List<NotaPedido>> ObtenerAsync(int idSucursal, NotaPedidoEstado? estado, TipoCliente? tipoCliente, DateTime? fechaDesde, DateTime? fechaHasta, int? idVendedor, string nombreCliente, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);

        decimal ObtenerMontoTotalClienteMayorista(int idClienteMatorista);

        int ObtenerCantidad(int idSucursal, NotaPedidoEstado? estado);
        
        void Actualizar(NotaPedido notaPedido);
    }
}
