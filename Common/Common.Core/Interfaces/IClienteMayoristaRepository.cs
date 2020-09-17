
using Common.Core.Enum;
using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IClienteMayoristaRepository
    {
        Task<List<ClienteMayorista>> BuscarAsync(string razonSocial, string cuit, CondicionIVA? condicionIva, int? idListaPrecio, int? idCorredor, int? idEmpresa, bool? habilitado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalElementos);
        Task<ClienteMayorista> Obtener(int id);
        Task GuardarAsync(ClienteMayorista cliente);
        Task ActualizarAsync(ClienteMayorista cliente);
    }
}
