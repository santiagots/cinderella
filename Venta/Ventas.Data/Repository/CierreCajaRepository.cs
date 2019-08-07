using System.Data.Entity;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;
using System;
using System.Linq;

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
            return _context.CierreCaja.Where(x => x.IdSucursal == idSucursal && DbFunctions.TruncateTime(x.Fecha).Value == DbFunctions.TruncateTime(fecha).Value).FirstOrDefault();
        }

        public CierreCaja ObtenerUltima(int idSucursal)
        {
            return _context.CierreCaja.Where(x => x.IdSucursal == idSucursal).OrderByDescending(x => x.Fecha).FirstOrDefault();
        }
    }
}
