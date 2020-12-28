using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface ICuentaBancariaRepository
    {
        Task<List<CuentaBancaria>> ObtenerAsync(int? idBanco, bool? habilitado);
        Task GuardarAsync(CuentaBancaria cuentaBancaria);
        Task ActualizarAsync(CuentaBancaria cuentaBancaria);
        Task<CuentaBancaria> ObtenerAsync(int id);
    }
}
