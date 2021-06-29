using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class TrasporteService
    {
        public static Task Guardar(TipoBase tipoBase, Transporte transporte)
        {
            ITrasporteRepository listaPrecioRepository = new TrasporteRepository(new CommonContext(tipoBase));
            return listaPrecioRepository.Guardar(transporte);
        }

        public static Task<List<Transporte>> Buscar(TipoBase tipoBase, string razonSocial, string cuit, bool? habilitado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalItems)
        {
            ITrasporteRepository listaPrecioRepository = new TrasporteRepository(new CommonContext(tipoBase));
            return listaPrecioRepository.Buscar(razonSocial, cuit, habilitado, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalItems);
        }

        public static Task<Transporte> Obtener(TipoBase tipoBase, int id)
        {
            ITrasporteRepository listaPrecioRepository = new TrasporteRepository(new CommonContext(tipoBase));
            return listaPrecioRepository.Obtener(id);
        }
    }
}
