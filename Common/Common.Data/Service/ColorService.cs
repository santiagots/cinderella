using Common.Core.Enum;
using Common.Core.Interfaces;
using Common.Core.Model;
using Common.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Data.Service
{
    public class ColorService
    {
        public static Task<List<Color>> BuscarColores(TipoBase tipoBase, string nombre)
        {
            IColorRepository ColorRepository = new ColorRepository(new CommonContext(tipoBase));
            return ColorRepository.Buscar(nombre);
        }

        public static Task AltaColor(Color color)
        {
            IRepository<Color> ColorRepository = new Repository<Color>(new CommonContext(TipoBase.Remota));
            return Task.Run(() => ColorRepository.Insert(color));
        }

        public static Task ModificarColor(Color color)
        {
            IColorRepository ColorRepository = new ColorRepository(new CommonContext(TipoBase.Remota));
            return ColorRepository.Actualizar(color);
        }

        public static Task<Color> ObtenerColor(int id)
        {
            IRepository<Color> ColorRepository = new Repository<Color>(new CommonContext(TipoBase.Remota));
            return Task.Run(() => ColorRepository.GetById(id));
        }
    }
}
