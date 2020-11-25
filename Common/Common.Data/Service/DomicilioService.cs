using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class DomicilioService
    {
        public static Task<List<Provincia>> ObtenerProvinciaAsync()
        {
            IDomicilioRepository domicilioRepository = new DomicilioRepository(new CommonContext());
            return domicilioRepository.ObtenerProvinciaAsync();
        }

        public static Task<List<Distrito>> ObtenerDistritoAsync(int idProvincia)
        {
            IDomicilioRepository domicilioRepository = new DomicilioRepository(new CommonContext());
            return domicilioRepository.ObtenerDistritoAsync(idProvincia);
        }

        public static Task<List<Localidad>> ObtenerLocalidadAsync(int idDepartamente)
        {
            IDomicilioRepository domicilioRepository = new DomicilioRepository(new CommonContext());
            return domicilioRepository.ObtenerLocalidadAsync(idDepartamente);
        }
    }
}
