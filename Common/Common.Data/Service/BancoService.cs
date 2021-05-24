using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class BancoService
    {
        public static Task<List<Banco>> ObtenerAsync(TipoBase tipoBase)
        {
            IBancoRepository bancoRepository = new BancoRepository(new CommonContext(tipoBase));
            return bancoRepository.ObtenerAsync();
        }
    }
}
