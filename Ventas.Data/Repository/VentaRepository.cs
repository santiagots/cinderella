using Ventas.Core.Model.VentaAggregate;
using Ventas.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Common.Core.Enum;

namespace Ventas.Data.Repository
{
    public class VentaRepository: BaseRepository, IVentaRepository
    {
        public VentaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public List<Venta> Obtener()
        {
            return _context.Venta.Include(x => x.Comisiones)
                                 .Include(x => x.Factura)
                                 .Include(x => x.Pagos).ToList();
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

            //if (anulado.HasValue)
            //TODO: FALTA ANULACION

            if (tiposFacturas != null && tiposFacturas.Any())
                ventas = ventas.Where(x => tiposFacturas.Contains(x.Factura.TipoFactura));

            if (tiposPagos != null && tiposPagos.Any())
                ventas = ventas.Where(x => x.Pagos.Any(y => tiposPagos.Contains(y.TipoPago)));

            if (tiposClientes != null && tiposClientes.Any())
                ventas = ventas.Where(x => tiposClientes.Contains(x.TipoCliente));


            return ventas.ToList();
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
                            .FirstOrDefault(x => x.Id == idVenta);
        }
    }
}
