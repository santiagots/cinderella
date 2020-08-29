using Common.Core.Enum;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.ValueObjects;
using Ventas.Data.Repository;

namespace Ventas.Data.Service
{
    public class NotaPedidoService
    {
        public static decimal ObtenerMontoTotalClienteMayorista(TipoBase tipoBase, int idClienteMatorista)
        {
            using (VentaContext context = new VentaContext(tipoBase))
            {
                INotaPedidoRepository NotaPedidoRepository = new NotaPedidoRepository(context);
                return NotaPedidoRepository.ObtenerMontoTotalClienteMayorista(idClienteMatorista);
            }
        }
    }
}
