using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class VentaService
    {
        public static Task<Venta> ObtenerAsync(TipoBase tipoBase, long idVenta)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext(tipoBase));
            return Task.Run(() => ventaRepository.Obtener(idVenta));
        }

        public static Venta Obtener(TipoBase tipoBase, long idVenta)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext(tipoBase));
            return ventaRepository.Obtener(idVenta);
        }

        public static Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fecha, Boolean? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext());
            return ventaRepository.ObtenerTotalAsync(idSucursal, fecha, facturado, tipoPago, tipoCliente);
        }

        public static Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, Boolean? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext());
            return ventaRepository.ObtenerTotalAsync(idSucursal, fechaDesde, fechaHasta, facturado, tipoPago, tipoCliente);
        }

        public static Task<List<Venta>> BuscarAsync(int idSucursal, int? numeroFacturaDesde, int? numeroFacturaHasta, decimal? montoDesde, decimal? montoHasta, DateTime? fechaDesde, DateTime? fechaHasta, bool? anulado, IEnumerable<TipoFactura> tiposFacturas, IEnumerable<TipoPago> tiposPagos, IEnumerable<TipoCliente> tiposClientes)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext());
            return ventaRepository.BuscarAsync(idSucursal, numeroFacturaDesde, numeroFacturaHasta, montoDesde, montoHasta, fechaDesde, fechaHasta, anulado, tiposFacturas, tiposPagos, tiposClientes);
        }

        public static Task<List<Venta>> BuscarAsync(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext());
            return ventaRepository.BuscarAsync(idSucursal, fechaDesde, fechaHasta, facturado, tipoPago, tipoCliente);
        }

        public static Task<List<Venta>> BuscarAsync(int idSucursal, DateTime fecha, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente)
        {
            IVentaRepository ventaRepository = new VentaRepository(new VentaContext());
            return ventaRepository.BuscarAsync(idSucursal, fecha, facturado, tipoPago, tipoCliente);
        }
    }
}
