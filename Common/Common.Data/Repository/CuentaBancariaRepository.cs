using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class CuentaBancariaRepository : BaseRepository<CommonContext>, ICuentaBancariaRepository
    {
        public CuentaBancariaRepository(CommonContext commonContext) : base(commonContext)
        {
        }

        public Task<List<CuentaBancaria>> ObtenerAsync(int? idBanco, bool? habilitado)
        {
            IQueryable<CuentaBancaria> cuentaBancaria = _context.CuentaBancaria.Include(x => x.Banco).Select(x => x);

            if (habilitado.HasValue)
                cuentaBancaria = cuentaBancaria.Where(x => x.Habilitado == habilitado);

            if (idBanco.HasValue)
                cuentaBancaria = cuentaBancaria.Where(x => x.IdBanco ==idBanco);

            return cuentaBancaria.ToListAsync();
        }

        public Task GuardarAsync(CuentaBancaria cuentaBancaria)
        {
            _context.Attach(cuentaBancaria.Banco);
            _context.CuentaBancaria.Add(cuentaBancaria);
            return _context.SaveChangesAsync();
        }

        public Task ActualizarAsync(CuentaBancaria cuentaBancaria)
        {
            cuentaBancaria.Banco = (Banco)_context.Attach(cuentaBancaria.Banco);
            _context.Entry(cuentaBancaria).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public Task<CuentaBancaria> ObtenerAsync(int id) => _context.CuentaBancaria.Include(x => x.Banco).FirstOrDefaultAsync(x => x.Id == id);
    }
}
