using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo = Producto.Core.Model.ProductoAgreggate;

namespace Producto.Core.Interfaces
{
    public interface IProductoRepository
    {
        void Actualizar(Modelo.Producto producto);
        IList<Modelo.Producto> Buscar(string codigo, string nombre, int pagina, int itemsPorPagina);
        IList<Modelo.Categoria> ObtenerCategorias();
        IList<Modelo.SubCategoria> ObtenerSubcategorias(int idCategoria);
        IList<Modelo.Proveedor> ObtenerProveedores();
        int BuscarTotal(string codigo, string nombre);
        void Guardar(Modelo.Producto producto);
        void Eliminar(int idProducto);
        Modelo.Producto ObtenerProducto(int idProducto);
    }
}
