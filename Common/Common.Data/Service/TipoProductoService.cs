using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class TipoProductoService
    {
        public static Task<List<TipoProducto>> BuscarTipoProducto(TipoBase tipoBase, string nombre)
        {
            ITipoProductoRepository ProductoContext = new TipoProductoRepository(new CommonContext(tipoBase));
            return ProductoContext.Buscar(nombre);
        }

        public static Task AltaTipoProducto(TipoProducto tipoProducto)
        {
            IRepository<TipoProducto> ProductoContext = new Repository<TipoProducto>(new CommonContext(TipoBase.Remota));
            return Task.Run( () => ProductoContext.Insert(tipoProducto));
        }

        public static Task ModificarTipoProducto(TipoProducto tipoProducto)
        {
            ITipoProductoRepository ProductoContext = new TipoProductoRepository(new CommonContext(TipoBase.Remota));
            return ProductoContext.Actualizar(tipoProducto);
        }

        public static Task<TipoProducto> ObtenerTipoProducto(int id)
        {
            IRepository<TipoProducto> tipoProductoRepository = new Repository<TipoProducto>(new CommonContext(TipoBase.Remota));
            return Task.Run(() => tipoProductoRepository.GetById(id));
        }
    }
}
