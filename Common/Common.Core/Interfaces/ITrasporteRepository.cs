using Common.Core.Enum;
using Common.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface ITrasporteRepository
    {
        Task Guardar(Transporte transporte);
        Task<List<Transporte>> Buscar(string razonSocial, string cuit, bool? habilitado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalItems);
        Task<Transporte> Obtener(int id);
    }
}
