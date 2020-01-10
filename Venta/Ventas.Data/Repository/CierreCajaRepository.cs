using System.Data.Entity;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using System;
using System.Linq;
using Ventas.Core.Enum;
using System.Collections.Generic;
using Common.Data.Repository;

namespace Ventas.Data.Repository
{
    public class CierreCajaRepository : BaseRepository<VentaContext>, ICierreCajaRepository
    {
        public CierreCajaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public void Alta(CierreCaja cierreCaja)
        {
            _context.CierreCaja.Add(cierreCaja);
            _context.SaveChanges();
        }

        public void Actualizar(CierreCaja cierreCaja)
        {
            _context.CierreCaja.Attach(cierreCaja);
            _context.Entry(cierreCaja).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public CierreCaja Obtener(int idSucursal, DateTime fecha)
        {
            return _context.CierreCaja.Where(x => x.Borrado == false &&
                                                  x.IdSucursal == idSucursal &&
                                                  DbFunctions.TruncateTime(x.Fecha).Value == DbFunctions.TruncateTime(fecha).Value)
                                      .FirstOrDefault();
        }

        public decimal ObtenerTotal(int idSucursal, DateTime fechaDesde, DateTime fechaHasta)
        {
            IQueryable<CierreCaja> cajas = _context.CierreCaja.Where(x => x.Borrado == false &&
                                                    x.IdSucursal == idSucursal &&
                                                    DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                    DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            return cajas.Sum(x => x.Monto);
        }

        public decimal ObtenerTotalDiferencia(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, CierreCajaSituacion situacionCaja)
        {
            decimal? monto = _context.CierreCaja.Where(x => x.Borrado == false &&
                                                            x.IdSucursal == idSucursal &&
                                                            x.Situacion == situacionCaja &&
                                                            DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                            DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value)
                                                .Sum(x => (decimal?)x.Diferencia);

            return monto ?? 0;
        }

        public IEnumerable<CierreCaja> Buscar(int idSucursal, DateTime fechaDesde, DateTime fechaHasta, CierreCajaSituacion? situacionCaja)
        {
            IQueryable<CierreCaja> cajas = _context.CierreCaja.Where(x => x.Borrado == false &&
                                                    x.IdSucursal == idSucursal &&
                                                    DbFunctions.TruncateTime(x.Fecha).Value >= DbFunctions.TruncateTime(fechaDesde).Value &&
                                                    DbFunctions.TruncateTime(x.Fecha).Value <= DbFunctions.TruncateTime(fechaHasta).Value);

            if (situacionCaja.HasValue)
                cajas = cajas.Where(x => x.Situacion == situacionCaja.Value);

            return cajas.ToList();
        }

        public CierreCaja ObtenerUltima(int idSucursal)
        {
            return _context.CierreCaja.Where(x => x.IdSucursal == idSucursal &&
                                                  x.Estado == CierreCajaEstado.Cerrada &&
                                                  x.Borrado == false)
                                      .OrderByDescending(x => x.Fecha)
                                      .FirstOrDefault();
        }
    }
}
