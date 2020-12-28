using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class CuentaBancariaService
    {
        public static Task<List<CuentaBancaria>> ObtenerAsync(TipoBase tipoBase, int? idBanco, bool? habilitado)
        {
            ICuentaBancariaRepository cuentaBancariaRepository = new CuentaBancariaRepository(new CommonContext(tipoBase));
            return cuentaBancariaRepository.ObtenerAsync(idBanco, habilitado);
        }

        public static Task GuardarAsync(TipoBase tipoBase, CuentaBancaria cuentaBancaria)
        {
            ICuentaBancariaRepository cuentaBancariaRepository = new CuentaBancariaRepository(new CommonContext(tipoBase));
            return cuentaBancariaRepository.GuardarAsync(cuentaBancaria);
        }

        public static Task ActualizarAsync(TipoBase tipoBase, CuentaBancaria cuentaBancaria)
        {
            ICuentaBancariaRepository cuentaBancariaRepository = new CuentaBancariaRepository(new CommonContext(tipoBase));
            return cuentaBancariaRepository.ActualizarAsync(cuentaBancaria);
        }

    }
}
