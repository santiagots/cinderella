using Producto.Core.Model.ProductoAgreggate;
using System.Collections.Generic;

namespace Producto.Core.Interfaces
{
    public interface IColorRepository
    {
        void Actualizar(Color color);
        List<Color> Buscar(string nombre);
    }
}
