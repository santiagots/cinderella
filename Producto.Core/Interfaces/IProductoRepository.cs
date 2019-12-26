using Common.Core.Enum;
using Common.Core.Model;
using System.Collections.Generic;
using Modelo = Producto.Core.Model.ProductoAgreggate;

namespace Producto.Core.Interfaces
{
    public interface IProductoRepository
    {
        void Actualizar(Modelo.Producto producto);
        IList<Modelo.Producto> Buscar(string codigo, string nombre, string ordenadoPor, OrdenadoDireccion ordenarDireccion, int pagina, int itemsPorPagina);
        IList<Categoria> ObtenerCategorias();
        IList<SubCategoria> ObtenerSubcategorias(int idCategoria);
        IList<Modelo.Proveedor> ObtenerProveedores();
        int BuscarTotal(string codigo, string nombre);
        void Guardar(Modelo.Producto producto);
        void Eliminar(int idProducto);
        Modelo.Producto ObtenerProducto(int idProducto);
    }
}
