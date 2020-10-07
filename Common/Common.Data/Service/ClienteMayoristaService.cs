using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class ClienteMayoristaService
    {
        public static Task<List<ClienteMayorista>> BuscarAsync(TipoBase tipoBase, string razonSocial, string cuit, CondicionIVA? condicionIva, int? idListaPrecio, int? idCorredor, int? idEmpresa, bool? habilitado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos)
        {
            IClienteMayoristaRepository ClienteMayoristaRepository = new ClienteMayoristaRepository(new CommonContext(tipoBase));
            return ClienteMayoristaRepository.BuscarAsync(razonSocial, cuit, condicionIva, idListaPrecio, idCorredor, idEmpresa, habilitado, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, out totalElementos);
        }

        public static Task GuardarAsync(TipoBase tipoBase, ClienteMayorista cliente)
        {
            IClienteMayoristaRepository ClienteMayoristaRepository = new ClienteMayoristaRepository(new CommonContext(tipoBase));
            return ClienteMayoristaRepository.GuardarAsync(cliente);
        }

        public static Task ActualizarAsync(TipoBase tipoBase, ClienteMayorista cliente)
        {
            IClienteMayoristaRepository ClienteMayoristaRepository = new ClienteMayoristaRepository(new CommonContext(tipoBase));
            return ClienteMayoristaRepository.ActualizarAsync(cliente);
        }

        public static Task<ClienteMayorista> ObtenerAsync(TipoBase tipoBase, int id)
        {
            IClienteMayoristaRepository ClienteMayoristaRepository = new ClienteMayoristaRepository(new CommonContext(tipoBase));
            return ClienteMayoristaRepository.ObtenerAsync(id);
        }
    }
}
