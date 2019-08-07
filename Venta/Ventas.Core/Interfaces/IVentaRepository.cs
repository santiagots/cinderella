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
        Venta Obtener(long idVenta);
        decimal ObtenerTotal(int idSucursal, DateTime fechaDesde, DateTime fechaHasta);
        decimal ObtenerTotal(int idSucursal, DateTime fecha);
        decimal ObtenerTotalPorTipoPago(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoPago tipoPago);
        decimal ObtenerTotalPorTipoPago(int idSucursal, DateTime fecha, TipoPago tipoPago);
        decimal ObtenerTotalPorFacturacion(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, bool facturado);
        decimal ObtenerTotalPorFacturacion(int idSucursal, DateTime fecha, bool facturado);
        decimal ObtenerTotalPorTipoCliente(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoCliente tipoCliente);
        decimal ObtenerTotalPorTipoCliente(int idSucursal, DateTime fecha, TipoCliente tipoCliente);
    }
}
