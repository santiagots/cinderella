
using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IDomicilioRepository
    {
        Task<List<Provincia>> ObtenerProvinciaAsync();
        Task<List<Distrito>> ObtenerDistritoAsync(int idProvincia);
        Task<List<Localidad>> ObtenerLocalidadAsync(int idDepartamente);
    }
}
