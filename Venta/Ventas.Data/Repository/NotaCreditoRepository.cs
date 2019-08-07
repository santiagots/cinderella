using System.Linq;
using System.Data.Entity;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using Common.Core.Enum;
using System;
using System.Collections.Generic;

namespace Ventas.Data.Repository
{
    public class NotaCreditoRepository : BaseRepository<VentaContext>, INotaCreditoRepository
    {
        public NotaCreditoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public object Buscar(int idSucursal, int? numeroNotaCredito, decimal? montoDesde, decimal? montoHasta, string nombre, int? cuit, DateTime? fechaDesde, DateTime? fechaHasta, List<TipoFactura> tiposFacturas)
        {
            IQueryable<NotaCredito> ventas = _context.NotaCredito
                                                    .Include(x => x.NumeroNotaCredito)
                                                    .Where(x => x.Venta.Sucursal.Id == idSucursal);

            if (cuit.HasValue)
                ventas = ventas.Where(x => x.CUIT == cuit.Value.ToString());

            if (numeroNotaCredito.HasValue)
                ventas = ventas.Where(x => x.NumeroNotaCredito.Any(y => y.Numero == numeroNotaCredito));

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

        public void Guardar(NotaCredito notaCredito)
        {
            _context.NotaCredito.Add(notaCredito);
            _context.SaveChanges();
        }

        public NotaCredito Obtener(long id)
        {
                return _context.NotaCredito
                    .Include(x => x.NumeroNotaCredito)
                    .FirstOrDefault(x => x.Id == id);
        }
    }
}
