using Common.Core.Enum;
using System.Linq;
using System.Linq.Dynamic;

namespace Common.Core.Extension
{
    public static class Paginado
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> consulta, string ordenadoPor, OrdenadoDireccion ordenadoDireccion, int pagina, int elementosPorPagina, out int totalElementos)
        {
            totalElementos = consulta.Count();

            return consulta
                        .OrderBy($"{ordenadoPor} {ordenadoDireccion}")
                        .Skip(elementosPorPagina * (pagina - 1))
                        .Take(elementosPorPagina);
        }
    }
}
