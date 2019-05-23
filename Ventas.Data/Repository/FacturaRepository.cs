using Common.Core.Enum;
using System;
using System.Linq;
using System.Data.Entity;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class FacturaRepository : BaseRepository, IFacturaRepository
    {
        public FacturaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Factura Obtener(long id)
        {
            return _context.Factura
                .Include(x => x.Venta)
                .Include(x => x.NumeroFactura)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Guardar(Factura factura)
        {
            _context.Factura.Add(factura);
            _context.SaveChanges();
        }

        public int ObtenerUltimoNumeroFactura(TipoFactura tipoFactura)
        {
            Factura factura = _context.Factura.OrderByDescending(x => x.Id).FirstOrDefault(x => x.TipoFactura == tipoFactura);
            if (factura != null)
            {
                return factura.NumeroFactura.Max(x => x.Numero);
            }
            else
            {
                return 0;
            }
        }
    }
}
