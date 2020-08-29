using Common.Core.Interfaces;
using Common.Core.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Data.Repository
{
    public class ListaPrecioRepository : BaseRepository<CommonContext>, IListaPrecioRepository
    {
        public ListaPrecioRepository(CommonContext commonContext) : base(commonContext)
        {
        }

        public Task<List<ListaPrecio>> ObtenerAsync()
        {
            string sql = @" SELECT P.id_Lista as Id
                                  ,P.ListaPrecio as Nombre
	                              ,G.id_Lista as IdGrupo
                                  ,G.ListaPrecio as Grupo
                            FROM LISTA_PRECIO P INNER JOIN LISTA_GRUPO G ON P.Id_ListaGrupo = G.id_Lista";

            return _context.ListaPrecio.SqlQuery(sql).ToListAsync();
        }
    }
}
