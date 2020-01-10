using Common.Core.Enum;
using System.Linq;
using System.Data.Entity;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using System;
using System.Collections.Generic;
using Common.Data.Repository;

namespace Ventas.Data.Repository
{
    public class FacturaRepository : BaseRepository<VentaContext>, IFacturaRepository
    {
        public FacturaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Factura Obtener(long id)
        {
            return _context.Factura
                .Include(x => x.NumeroFactura)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Guardar(Factura factura)
        {
            _context.Factura.Add(factura);
            _context.SaveChanges();
        }

        public int ObtenerUltimoNumeroFactura(int idSucursal, TipoFactura tipoFactura)
        {
            int? factura = _context.NumeroFactura.Where(x => x.Factura.Venta.Sucursal.Id == idSucursal && x.Factura.TipoFactura == tipoFactura)
                                              .OrderByDescending(x => x.Numero)
                                              .Max(x => (int?)x.Numero);

            return factura ?? 0;
        }

        public IEnumerable<Factura> Buscar(int idSucursal, int? numeroFactura, decimal? montoDesde, decimal? montoHasta, string nombre, int? cuit, DateTime? fechaDesde, DateTime? fechaHasta, List<TipoFactura> tiposFacturas)
        {
            IQueryable<Factura> ventas = _context.Factura
                                        .Include(x => x.NumeroFactura)
                                        .Where(x => x.Venta.Sucursal.Id == idSucursal);

            if (cuit.HasValue)
                ventas = ventas.Where(x => x.CUIT == cuit.Value.ToString());

            if (numeroFactura.HasValue)
                ventas = ventas.Where(x => x.NumeroFactura.Any(y => y.Numero == numeroFactura));

            if (montoDesde.HasValue)
                ventas = ventas.Where(x => x.Monto >= montoDesde.Value);

            if (montoHasta.HasValue)
                ventas = ventas.Where(x => x.Monto <= montoHasta.Value);

            if (fechaDesde.HasValue)
                ventas = ventas.Where(x => DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde.Value).Value);

            if (fechaHasta.HasValue)
                ventas = ventas.Where(x => DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta.Value).Value);

            if (!string.IsNullOrWhiteSpace(nombre))
                ventas = ventas.Where(x => x.NombreYApellido.Contains(nombre));

            if (tiposFacturas != null && tiposFacturas.Any())
                ventas = ventas.Where(x => tiposFacturas.Contains(x.TipoFactura));

            return ventas.OrderByDescending(x => x.Fecha).ToList();
        }
    }
}
