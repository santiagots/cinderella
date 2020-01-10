using Common.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Interfaces;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data.Repository
{
    public class ListaPrecioRepository : BaseRepository<VentaContext>, IListaPrecioRepository
    {
        public ListaPrecioRepository(VentaContext ventaContext) : base(ventaContext)
        {
        }

        public IEnumerable<ListaPrecio> Obtener()
        {
            string sql = @" SELECT P.id_Lista as Id
                                  ,P.ListaPrecio as Nombre
	                              ,G.id_Lista as IdGrupo
                                  ,G.ListaPrecio as Grupo
                            FROM LISTA_PRECIO P INNER JOIN LISTA_GRUPO G ON P.Id_ListaGrupo = G.id_Lista";

            return _context.ListaPrecio.SqlQuery(sql).ToList();
        }
    }
}
