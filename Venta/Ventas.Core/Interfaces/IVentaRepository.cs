using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Core.Enum;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IVentaRepository
    {
        void Actualizar(Venta venta);
        void Guardar(Venta venta);
        int Cantidad(int idSucursal);
        IEnumerable<Venta> Buscar(int idSucursal, int? numeroFacturaDesde, int? numeroFacturaHasta, decimal? montoDesde, decimal? montoHasta, DateTime? fechaDesde, DateTime? fechaHasta, bool? anulado, IEnumerable<TipoFactura> tiposFacturas, IEnumerable<TipoPago> tiposPagos, IEnumerable<TipoCliente> tiposClientes);
        IEnumerable<Venta> Buscar(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente);
        IEnumerable<Venta> Buscar(int idSucursal, DateTime fecha, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente);
        Task<Venta> ObtenerAsync(TipoBase tipoBase, long idVenta);
        Venta Obtener(long idVenta);
        Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fecha, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente);
        Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente);
    }
}
