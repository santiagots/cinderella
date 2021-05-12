using Common.Core.Enum;
using System.Linq;

namespace Common.Core.Extension
{
    public static class Paginado
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> consulta, string ordenadoPor, OrdenadoDireccion ordenadoDireccion, int pagina, int elementosPorPagina, out int totalElementos)
        {
            totalElementos = consulta.Count();

            if (ordenadoDireccion == OrdenadoDireccion.ASC)
            {
                return consulta
                            .OrderByDynamic(x => $"x.{ordenadoPor}")
                            .Skip(elementosPorPagina * (pagina - 1))
                            .Take(elementosPorPagina);
            }
            else
            {
                return consulta
                            .OrderByDescendingDynamic(x => $"x.{ordenadoPor}")
                            .Skip(elementosPorPagina * (pagina - 1))
                            .Take(elementosPorPagina);
            }
        }

        public static IQueryable<T> Paginar<T>(this IQueryable<T> consulta, string ordenadoPor, OrdenadoDireccion ordenadoDireccion, int pagina, int elementosPorPagina)
        {
            if (ordenadoDireccion == OrdenadoDireccion.ASC)
            {
                return consulta
                            .OrderByDynamic(x => $"x.{ordenadoPor}")
                            .Skip(elementosPorPagina * (pagina - 1))
                            .Take(elementosPorPagina);
            }
            else
            {
                return consulta
                            .OrderByDescendingDynamic(x => $"x.{ordenadoPor}")
                            .Skip(elementosPorPagina * (pagina - 1))
                            .Take(elementosPorPagina);
            }
        }
    }
}
