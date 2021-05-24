using Common.Core.Enum;
using Common.Core.Model;
using System.Collections.Generic;

namespace Common.Core.Interfaces
{
    public interface ISubCategoriaRepository
    {
        IList<SubCategoria> Buscar(string descripcion, Categoria categoria, IVA iva, bool habilitado, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina, out int totalItems);
        SubCategoria Obtener(int idSubCategoria);
        IList<SubCategoria> ObtenerPorCategoria(int idCategoria);
        void Guardar(SubCategoria subCategoria);
        void Actualizar(SubCategoria subCategoria);
    }
}
