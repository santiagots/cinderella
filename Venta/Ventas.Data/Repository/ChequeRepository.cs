using Common.Core.Enum;
using Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.ChequeAggregate;

namespace Ventas.Data.Repository
{
    public class ChequeRepository : BaseRepository<VentaContext>, IChequeRepository
    {
        public ChequeRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public void Alta(Cheque cheque)
        {
            _context.Cheque.Add(cheque);
            _context.SaveChanges();
        }

        public void Actualizar(Cheque cheque)
        {
            _context.Cheque.Attach(cheque);
            _context.Entry(cheque).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<Cheque> Buscar(int idSucursal, bool? facturado, string cliente, string librador, DateTime? fechaIngresoDesde, DateTime? fechaIngresoHasta, DateTime? fechaDepositoDesde, DateTime? fechaDepositoHasta, DateTime? fechaVencimientoDesde, DateTime? fechaVencimientoHasta, DateTime? fechaSalidaDesde, DateTime? fechaSalidaHasta, IEnumerable<EstadoCheque> estado, IEnumerable<DestinoSalidaCheque> destinoSalida, decimal? montoDesde, decimal? montoHasta, int? numero, int? idBanco)
        {
            IQueryable<Cheque> cheques = _context.Cheque.Include(x => x.BancoEmisor).Where(x => x.IdSucursal == idSucursal);

            if (facturado.HasValue)
                cheques = cheques.Where(x => x.MarcaFacturado == facturado.Value);

            if (!String.IsNullOrEmpty(cliente))
                cheques = cheques.Where(x => x.ClienteNombre.Contains(cliente));

            if (!String.IsNullOrEmpty(librador))
                cheques = cheques.Where(x => x.LibradorNombre.Contains(librador));

            if (fechaIngresoDesde.HasValue && fechaIngresoHasta.HasValue)
                cheques = cheques.Where(x => DbFunctions.TruncateTime(x.FechaIngreso).Value >= DbFunctions.TruncateTime(fechaIngresoDesde).Value && DbFunctions.TruncateTime(x.FechaIngreso).Value <= DbFunctions.TruncateTime(fechaIngresoHasta).Value);

            if (fechaDepositoDesde.HasValue && fechaDepositoHasta.HasValue)
                cheques = cheques.Where(x => DbFunctions.TruncateTime(x.FechaDesposito).Value >= DbFunctions.TruncateTime(fechaDepositoDesde).Value && DbFunctions.TruncateTime(x.FechaDesposito).Value <= DbFunctions.TruncateTime(fechaDepositoHasta).Value);

            if (fechaVencimientoDesde.HasValue && fechaVencimientoHasta.HasValue)
                cheques = cheques.Where(x => DbFunctions.TruncateTime(x.FechaVencimiento).Value >= DbFunctions.TruncateTime(fechaVencimientoDesde).Value && DbFunctions.TruncateTime(x.FechaVencimiento).Value <= DbFunctions.TruncateTime(fechaVencimientoHasta).Value);

            if (fechaSalidaDesde.HasValue && fechaSalidaHasta.HasValue)
                cheques = cheques.Where(x => DbFunctions.TruncateTime(x.FechaSalida).Value >= DbFunctions.TruncateTime(fechaSalidaDesde).Value && DbFunctions.TruncateTime(x.FechaSalida).Value <= DbFunctions.TruncateTime(fechaSalidaHasta).Value);

            if (estado != null && estado.Any())
                cheques = cheques.Where(x => estado.Contains(x.Estado));

            if (destinoSalida != null && destinoSalida.Any())
                cheques = cheques.Where(x => destinoSalida.Contains(x.DestinoSalida));

            if (montoDesde.HasValue)
                cheques = cheques.Where(x => x.Monto >= montoDesde);

            if (montoHasta.HasValue)
                cheques = cheques.Where(x => x.Monto <= montoHasta);

            if (numero.HasValue)
                cheques = cheques.Where(x => x.NumeroCheque == numero);

            if (idBanco.HasValue)
                cheques = cheques.Where(x => x.IdBancoEmisor == idBanco);

            return cheques.ToList();
        }

        public Cheque Obtener(long idCheque)
        {
            return _context.Cheque.Include(x => x.BancoEmisor)
                                  .FirstOrDefault(x => x.Id == idCheque);
        }

        public decimal TotalCartera(int idSucursal)
        {
            decimal? total = _context.Cheque.Where(x => x.IdSucursal == idSucursal && x.Estado != EstadoCheque.Salido).Sum(x => (decimal?) x.Monto);
            return total ?? 0;
        }

        public int UltimoNumeroDeOrden(int idSucursal)
        {
            if (_context.Cheque.Any())
                return _context.Cheque.Max(x => x.NumeroOrden);
            else
                return 0;
        }
    }
}
