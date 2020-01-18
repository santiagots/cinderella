using Ventas.Core.Model.VentaAggregate;
using Ventas.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Common.Core.Enum;
using Common.Data.Repository;

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
                            .Include(x => x.VentaItems.Select(y => y.Producto))
                            .Include(x => x.Factura)
                            .Include(x => x.Factura.NumeroFactura)
                            .Include(x => x.NotaCredito)
                            .Include(x => x.NotaCredito.NumeroNotaCredito)
                            .FirstOrDefault(x => x.Id == idVenta);
        }

        public decimal ObtenerTotal(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente)
        {
            IQueryable<Pago> pagos = _context.Pago.Where(x => x.Venta.Anulado == false &&
                                                    x.Venta.IdSucursal == idSucursal &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                    DbFunctions.TruncateTime(x.Venta.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            if (facturado.HasValue)
            {
                if (facturado.Value)
                    pagos = pagos.Where(x => x.Venta.Factura != null);
                else
                    pagos = pagos.Where(x => x.Venta.Factura == null);
            }

            if (tipoCliente.HasValue)
                pagos = pagos.Where(x => x.Venta.TipoCliente == tipoCliente);

            if (tipoPago.HasValue)
                pagos = pagos.Where(x => x.TipoPago == tipoPago.Value);
            else
                pagos = pagos.Where(x => x.TipoPago != TipoPago.Bonificacion);

            decimal? resultado = pagos.Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));

            return resultado ?? 0;
        }

        public decimal ObtenerTotal(int idSucursal, DateTime fecha, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente)
        {
            return ObtenerTotal(idSucursal, fecha, fecha, facturado, tipoPago, tipoCliente);
        }

        public int Cantidad(int idSucursal)
        {
            return _context.Venta.Count(x => x.IdSucursal == idSucursal);
        }

        public void Guardar(Venta venta)
        {
            _context.Entry(venta.Encargado).State = EntityState.Unchanged;
            _context.Entry(venta.Vendedor).State = EntityState.Unchanged;
            venta.VentaItems.ToList().ForEach(x => _context.Entry(x.Producto).State = System.Data.Entity.EntityState.Unchanged);
            _context.Venta.Add(venta);
            _context.SaveChanges();
        }

        public IEnumerable<Venta> Buscar(int idSucursal, int? numeroFacturaDesde, int? numeroFacturaHasta, decimal? montoDesde, decimal? montoHasta, DateTime? fechaDesde, DateTime? fechaHasta, bool? anulado, IEnumerable<TipoFactura> tiposFacturas, IEnumerable<TipoPago> tiposPagos, IEnumerable<TipoCliente> tiposClientes)
        {
            IQueryable<Venta> ventas = ObtenerContextoVentaReducido()
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

        public IEnumerable<Venta> Buscar(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente)
        {
            IQueryable<Venta> ventas = ObtenerContextoVentaReducido()
                                                        .Where(x => x.Anulado == false &&
                                                        x.IdSucursal == idSucursal &&
                                                        DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                        DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            if (facturado.HasValue)
            {
                if (facturado.Value)
                    ventas = ventas.Where(x => x.Factura != null);
                else
                    ventas = ventas.Where(x => x.Factura == null);
            }

            if (tipoCliente.HasValue)
                ventas = ventas.Where(x => x.TipoCliente == tipoCliente.Value);

            if (tipoPago.HasValue)
                ventas = ventas.Where(x => x.Pagos.Any(y => y.TipoPago == tipoPago.Value));
            else
                ventas = ventas.Where(x => x.Pagos.Any(y => y.TipoPago != TipoPago.Bonificacion));

            return ventas.OrderByDescending(x => x.Fecha).ToList();
        }

        public IEnumerable<Venta> Buscar(int idSucursal, DateTime fecha, bool? facturado, TipoPago? tipoPago, TipoCliente? tipoCliente)
        {
            return Buscar(idSucursal, fecha, fecha, facturado, tipoPago, tipoCliente);
        }

        private IQueryable<Venta> ObtenerContextoVentaReducido()
        {
            return _context.Venta.Include(x => x.ClienteMayorista)
                                 .Include(x => x.Vendedor)
                                 .Include(x => x.Encargado)
                                 .Include(x => x.Pagos)
                                 .Include(x => x.Factura)
                                 .Include(x => x.Factura.NumeroFactura);
        }
    }
}
