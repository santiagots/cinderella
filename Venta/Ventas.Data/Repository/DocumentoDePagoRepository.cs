using Common.Data.Repository;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.CuentaCorrienteAggregate;

namespace Ventas.Data.Repository
{
    public class DocumentoDePagoRepository : BaseRepository<VentaContext>, IDocumentoDePagoRepository
    {
        public DocumentoDePagoRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public Task ActualizarAsync(DocumentoDePago documentoDePago)
        {
            _context.Entry(documentoDePago.Sucursal).State = EntityState.Unchanged;
            _context.Entry(documentoDePago.ClienteMayorista).State = EntityState.Unchanged;
            _context.Entry(documentoDePago.Encargado).State = EntityState.Unchanged;
            documentoDePago.Pagos.ForEach(x => _context.Entry(x).State = EntityState.Unchanged);

            _context.Entry(documentoDePago).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public Task GuardarAsync(DocumentoDePago documentoDePago)
        {
            _context.Entry(documentoDePago.Encargado).State = EntityState.Unchanged;

            _context.DocumentoDePago.Add(documentoDePago);
            return _context.SaveChangesAsync();
        }

        public Task<int> CantidadAsync(int idSucursal)
        {
            return _context.DocumentoDePago.CountAsync(x => x.IdSucursal == idSucursal);
        }

        public Task<DocumentoDePago> ObtenerAsync(long idDocumentoDePago)
        {
            return _context.DocumentoDePago
                .Include(x => x.Sucursal)
                .Include(x => x.Encargado)
                .Include(x => x.ClienteMayorista)
                .Include(x => x.Pagos)
                .FirstOrDefaultAsync(x => x.Id == idDocumentoDePago);
        }
    }
}
