using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> Buscar(string nombre);
        Task Actualizar(Supplier supplier);
    }
}
