using Ventas.Core.Model.VentaAggregate;
using Ventas.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Ventas.Data.Repository
{
    public class VentaRepository: BaseRepository, IVentaRepository
    {
        public VentaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public List<Venta> Obtener()
        {
            List<Venta> a = _context.Venta.Include(x => x.Comisiones).Include(x => x.Factura).Include(x => x.Pagos).ToList();
            return a;
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
    }
}
