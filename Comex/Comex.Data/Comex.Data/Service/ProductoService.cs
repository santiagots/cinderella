using Comex.Core.Interfaces;
using Comex.Core.Model.ComexAggregate;
using Comex.Data.Repository;
using Common.Core.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comex.Data.Service
{
    public class ProductoService
    {
        public static List<string> ObtenerNombreYCodigoDeProductos(int idSupplier)
        {
            IProductoRepository bancoRepository = new ProductoRepository(new ComexContext(TipoBase.Local));
            return bancoRepository.ObtenerNombreYCodigoDeProductos(idSupplier);
        }

        public static Task<Producto> BuscarProductoPorCodigoNombreBarras(int idSupplier, string codigo)
        {
            IProductoRepository bancoRepository = new ProductoRepository(new ComexContext(TipoBase.Local));
            return bancoRepository.BuscarProductoPorCodigoNombreBarras(idSupplier, codigo);
        }

        public static Task<List<Producto>> BuscarProducto(int? idSupplier, int? idColor, int? idTipoProducto, int? cantidadLuces, string codigo)
        {
            IProductoRepository bancoRepository = new ProductoRepository(new ComexContext(TipoBase.Local));
            return bancoRepository.BuscarProducto(idSupplier, idColor, idTipoProducto, cantidadLuces, codigo);
        }
    }
}
