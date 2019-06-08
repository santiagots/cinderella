using Common.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IFacturaRepository
    {
        Factura Obtener(long id);
        void Guardar(Factura factura);
        int ObtenerUltimoNumeroFactura(TipoFactura tipoFactura);
        IEnumerable<Factura> Buscar(int idSucursal, int? numeroFactura, decimal? montoDesde, decimal? montoHasta, string nombre, int? cuit, DateTime? fechaDesde, DateTime? fechaHasta, List<TipoFactura> tiposFacturas);
    }
}
