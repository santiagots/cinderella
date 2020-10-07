using System.Threading.Tasks;
using Ventas.Core.Model.CuentaCorrienteAggregate;

namespace Ventas.Core.Interfaces
{
    public interface IDocumentoDePagoRepository
    {
        Task GuardarAsync(DocumentoDePago documentoDePago);
        Task<int> CantidadAsync(int idSucursal);
        Task<DocumentoDePago> ObtenerAsync(long idDocumentoDePago);
        Task ActualizarAsync(DocumentoDePago documentoDePago);
    }
}
