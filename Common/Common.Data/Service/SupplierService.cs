using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class SupplierService
    {
        public static Task<List<Supplier>> BuscarSupplier(TipoBase tipoBase, string nombre)
        {
            ISupplierRepository supplierRepository = new SupplierRepository(new CommonContext(tipoBase));
            return supplierRepository.Buscar(nombre);
        }

        public static Task AltaSupplier(Supplier supplier)
        {
            IRepository<Supplier> supplierRepository = new Repository<Supplier>(new CommonContext(TipoBase.Remota));
            return Task.Run(() => supplierRepository.Insert(supplier));
        }

        public static Task ModificarSupplier(Supplier supplier)
        {
            ISupplierRepository supplierRepository = new SupplierRepository(new CommonContext(TipoBase.Remota));
            return supplierRepository.Actualizar(supplier);
        }

        public static Task<Supplier> ObtenerSupplier(int id)
        {
            IRepository<Supplier> supplierRepository = new Repository<Supplier>(new CommonContext(TipoBase.Remota));
            return Task.Run(() => supplierRepository.GetById(id));
        }
    }
}
