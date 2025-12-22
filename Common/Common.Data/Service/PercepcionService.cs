using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class PercepcionService
    {
        public static Task<List<Percepcion>> Buscar(TipoBase tipoBase,string provincia = "", CondicionIVA? condicionIVA = null, bool? habilitado=null)
        {
            IPercepcionRepository repository = new PercepcionRepository(new CommonContext(tipoBase));
            return repository.Buscar(provincia, condicionIVA, habilitado);
        }

        public static Task Guardar(Percepcion percepcion)
        {
            IPercepcionRepository repository = new PercepcionRepository(new CommonContext(TipoBase.Remota));
            return repository.Guardar(percepcion);
        }

        public static Task Borrar(Percepcion percepcion)
        {
            IRepository<Percepcion> repository = new Repository<Percepcion>(new CommonContext(TipoBase.Remota));
            return Task.Run(() => repository.Delete(percepcion.Id));
        }
    }
}
