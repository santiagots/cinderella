using Common.Core.Enum;
using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.CuentaCorrienteAggregate;

namespace Ventas.Data.Repository
{
    public class DocumentoDePagoRepository : BaseRepository<VentaContext>, IDocumentoDePagoRepository
    {
        public DocumentoDePagoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task ActualizarAsync(DocumentoDePago documentoDePago)
        {
            _context.Entry(documentoDePago.Sucursal).State = EntityState.Unchanged;
            _context.Entry(documentoDePago.ClienteMayorista).State = EntityState.Unchanged;
            _context.Entry(documentoDePago.Encargado).State = EntityState.Unchanged;
            documentoDePago.Pagos.ForEach(x => _context.Entry(x).State = EntityState.Unchanged);

            _context.Entry(documentoDePago).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public Task GuardarAsync(DocumentoDePago documentoDePago)
        {
            _context.Entry(documentoDePago.ClienteMayorista).State = EntityState.Unchanged;
            _context.Entry(documentoDePago.Encargado).State = EntityState.Unchanged;
            documentoDePago.Pagos.Where(x => x.TipoPago == TipoPago.Deposito).ToList().ForEach(x => _context.Entry(x.CuentaBancaria).State = EntityState.Unchanged);

            _context.DocumentoDePago.Add(documentoDePago);
            return _context.SaveChangesAsync();
        }

        public Task<List<DocumentoDePago>> BuscarAsync(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoPago? tipoPago, TipoAccionDocumentoPago? tipoAccion)
        {
            IQueryable<DocumentoDePago> documentoDePagos = Includes().Where(x => x.Anulado == false &&
                                                                                x.IdSucursal == idSucursal &&
                                                                                DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                                                DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            if (tipoPago.HasValue)
                documentoDePagos = documentoDePagos.Where(x => x.Pagos.Any(y => y.TipoPago == tipoPago.Value));
            else
                documentoDePagos = documentoDePagos.Where(x => x.Pagos.Any(y => y.TipoPago != TipoPago.Bonificacion));

            if (tipoAccion.HasValue)
                documentoDePagos = documentoDePagos.Where(x => x.TipoAccion == TipoAccionDocumentoPago.MovimientoFondos);

            return documentoDePagos.OrderByDescending(x => x.Fecha).ToListAsync();
        }

        public Task<int> CantidadAsync(int idSucursal)
        {
            return _context.DocumentoDePago.CountAsync(x => x.IdSucursal == idSucursal);
        }

        public Task<DocumentoDePago> ObtenerAsync(long idDocumentoDePago)
        {
            return Includes().FirstOrDefaultAsync(x => x.Id == idDocumentoDePago);
        }

        private decimal ObtenerTotal(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, TipoPago? tipoPago)
        {
            IQueryable<DocumentoDePagoPago> pagos = _context.DocumentoDePago.Where(x => x.Anulado == false &&
                                                                                x.IdSucursal == idSucursal &&
                                                                                DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                                                DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value &&
                                                                                x.TipoAccion == TipoAccionDocumentoPago.MovimientoFondos)
                                                                            .SelectMany(x => x.Pagos);

            if (tipoPago.HasValue)
                pagos = pagos.Where(x => x.TipoPago == tipoPago.Value);
            else
                pagos = pagos.Where(x => x.TipoPago != TipoPago.Bonificacion);

            decimal? resultado = pagos.Sum(x => (decimal?)(x.MontoPago.Monto - x.MontoPago.Descuento + x.MontoPago.IVA + x.MontoPago.CFT));

            return resultado ?? 0;
        }

        public Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fechaDesde, DateTime fechahasta, TipoPago? tipoPago)
        {
            return Task.Run(() => ObtenerTotal(idSucursal, fechaDesde, fechahasta, tipoPago));
        }

        public Task<decimal> ObtenerTotalAsync(int idSucursal, DateTime fecha, TipoPago? tipoPago)
        {
            return Task.Run(() => ObtenerTotal(idSucursal, fecha, fecha, tipoPago));
        }

        private IQueryable<DocumentoDePago> Includes() {
            return _context.DocumentoDePago
                .Include(x => x.Sucursal)
                .Include(x => x.Encargado)
                .Include(x => x.ClienteMayorista.DomicilioEntrega.Distrito)
                .Include(x => x.ClienteMayorista.DomicilioEntrega.Localidad)
                .Include(x => x.ClienteMayorista.DomicilioEntrega.Provincia)
                .Include(x => x.ClienteMayorista.DomicilioFacturacion.Distrito)
                .Include(x => x.ClienteMayorista.DomicilioFacturacion.Localidad)
                .Include(x => x.ClienteMayorista.DomicilioFacturacion.Provincia)
                .Include(x => x.Pagos.Select(y => y.CuentaBancaria.Banco))
                .Include(x => x.Cheques.Select(y => y.BancoEmisor));
        }
    }
}
