using Common.Core.Enum;
using System;
using System.Linq;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class FacturaRepository : BaseRepository, IFacturaRepository
    {
        public FacturaRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public int ObtenerUltimoNumeroFactura(TipoFactura tipoFactura)
        {
            Factura factura = _context.Factura.OrderBy(x => x.Id).FirstOrDefault(x => x.TipoFactura == tipoFactura);
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
