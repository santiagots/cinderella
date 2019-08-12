using Ventas.Core.Model.VentaAggregate;
using Ventas.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Common.Core.Enum;

namespace Ventas.Data.Repository
{
    public class VentaRepository: BaseRepository<VentaContext>, IVentaRepository
    {
        public VentaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public void Actualizar(Venta venta)
        {
            _context.Entry(venta).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public Venta Obtener(long idVenta)
        {
            return _context.Venta
                            .Include(x => x.Sucursal)
                            .Include(x => x.Encargado)
                            .Include(x => x.Vendedor)
                            .Include(x => x.ClienteMayorista)
                            .Include(x => x.Comisiones)
                            .Include(x => x.Pagos)
                            .Include(x => x.Cheques)
                            .Include(x => x.VentaItems)
                            .Include(x => x.Factura)
                            .Include(x => x.Factura.NumeroFactura)
                            .Include(x => x.NotaCredito)
                            .Include(x => x.NotaCredito.NumeroNotaCredito)
                            .FirstOrDefault(x => x.Id == idVenta);
        }

        public decimal ObtenerTotal(int idSucursal, DateTime fechaDesde, DateTime fechaHasta)
        {
            decimal? resultado = _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                    x.Venta.IdSucursal == idSucursal &&
                                                    x.TipoPago != TipoPago.Bonificacion &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value)
                                            .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));
            return resultado ?? 0;
        }

        public decimal ObtenerTotal(int idSucursal, DateTime fecha)
        {
            decimal? resultado = _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                    x.Venta.IdSucursal == idSucursal &&
                                                    x.TipoPago != TipoPago.Bonificacion &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value == DbFunctions.TruncateTime(fecha).Value)
                                            .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));
            return resultado ?? 0;
        }

        public decimal ObtenerTotalPorTipoPago(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoPago tipoPago)
        {
            decimal? resultado = _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                    x.Venta.IdSucursal == idSucursal &&
                                                    x.TipoPago == tipoPago &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value)
                                            .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));
            return resultado ?? 0;
        }

        public decimal ObtenerTotalPorTipoPago(int idSucursal, DateTime fecha, TipoPago tipoPago)
        {
            decimal? resultado = _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                    x.Venta.IdSucursal == idSucursal &&
                                                    x.TipoPago == tipoPago &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fecha).Value)
                                                .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));

            return resultado ?? 0;
        }

        public decimal ObtenerTotalPorFacturacion(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, bool facturado)
        {
            decimal? resultado = null;
            IQueryable<Pago> Pagos =  _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                            x.Venta.IdSucursal == idSucursal &&
                                                            DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                            DbFunctions.TruncateTime(x.Venta.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            if(facturado)
                resultado = Pagos.Where(x => x.Venta.Factura != null)
                                .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));
            else
                resultado = Pagos.Where(x => x.Venta.Factura == null)
                                .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));

            return resultado ?? 0;
        }

        public decimal ObtenerTotalPorFacturacion(int idSucursal, DateTime fecha, bool facturado)
        {
            decimal? resultado = null;
            IQueryable<Pago> Pagos = _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                           x.Venta.IdSucursal == idSucursal &&
                                                           DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fecha).Value);

            if (facturado)
                resultado = Pagos.Where(x => x.Venta.Factura != null)
                                .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));
            else
                resultado = Pagos.Where(x => x.Venta.Factura == null)
                                .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));

            return resultado ?? 0;
        }

        public decimal ObtenerTotalPorTipoCliente(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoCliente tipoCliente)
        {
            decimal? resultado = _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                    x.Venta.IdSucursal == idSucursal &&
                                                    x.Venta.TipoCliente == tipoCliente &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value)
                                            .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));

            return resultado ?? 0;
        }

        public decimal ObtenerTotalPorTipoCliente(int idSucursal, DateTime fecha, TipoCliente tipoCliente)
        {
            decimal? resultado = _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                    x.Venta.IdSucursal == idSucursal &&
                                                    x.Venta.TipoCliente == tipoCliente &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fecha).Value)
                                            .Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));

            return resultado ?? 0;
        }

        public int Cantidad(int idSucursal)
        {
            return _context.Venta.Count(x => x.IdSucursal == idSucursal);
        }

        public void Guardar(Venta venta)
        {
            _context.Entry(venta.Encargado).State = System.Data.Entity.EntityState.Unchanged;
            _context.Entry(venta.Vendedor).State = System.Data.Entity.EntityState.Unchanged;
            _context.Venta.Add(venta);
            _context.SaveChanges();
        }

        public IEnumerable<Venta> Buscar(int idSucursal, int? numeroFacturaDesde, int? numeroFacturaHasta, decimal? montoDesde, decimal? montoHasta, DateTime? fechaDesde, DateTime? fechaHasta, bool? anulado, IEnumerable<TipoFactura> tiposFacturas, IEnumerable<TipoPago> tiposPagos, IEnumerable<TipoCliente> tiposClientes)
        {
            IQueryable<Venta> ventas = _context.Venta
                                        .Include(x => x.ClienteMayorista)
                                        .Include(x => x.Vendedor)
                                        .Include(x => x.Encargado)
                                        .Include(x => x.Pagos)
                                        .Include(x => x.Factura)
                                        .Include(x => x.Factura.NumeroFactura)
                                        .Where(x => x.Sucursal.Id == idSucursal);
            
            if(numeroFacturaDesde.HasValue)
                ventas = ventas.Where(x => x.Factura.NumeroFactura.Any(y => y.Numero >= numeroFacturaDesde.Value));

            if (numeroFacturaHasta.HasValue)
                ventas = ventas.Where(x => x.Factura.NumeroFactura.Any(y => y.Numero <= numeroFacturaHasta.Value));

            if (montoDesde.HasValue)
                ventas = ventas.Where(x => x.MontoTotal.Valor + x.MontoTotal.Iva >= montoDesde.Value);

            if (montoHasta.HasValue)
                ventas = ventas.Where(x => x.MontoTotal.Valor + x.MontoTotal.Iva <= montoHasta.Value);

            if (fechaDesde.HasValue)
                ventas = ventas.Where(x => DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde.Value).Value);

            if (fechaHasta.HasValue)
                ventas = ventas.Where(x => DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta.Value).Value);

            if (anulado.HasValue)
                ventas = ventas.Where(x => x.Anulado == anulado.Value);

            if (tiposFacturas != null && tiposFacturas.Any())
                ventas = ventas.Where(x => tiposFacturas.Contains(x.Factura.TipoFactura));

            if (tiposPagos != null && tiposPagos.Any())
                ventas = ventas.Where(x => x.Pagos.Any(y => tiposPagos.Contains(y.TipoPago)));

            if (tiposClientes != null && tiposClientes.Any())
                ventas = ventas.Where(x => tiposClientes.Contains(x.TipoCliente));


            return ventas.OrderByDescending(x => x.Fecha).ToList();
        }
    }
}
