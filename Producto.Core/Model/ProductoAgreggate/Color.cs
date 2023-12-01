using Common.Core.Exceptions;
using Common.Core.Model;

namespace Producto.Core.Model.ProductoAgreggate
{
    public class Color : Entity<int>
    {
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public bool Borrado { get; set; }

        public Color() : base()
        { }

        public Color(string nombre, bool habilitado)
        {
            Nombre = nombre;
            Habilitado = habilitado;
            Borrado = false;

            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Nuevo;
        }

        public void Modificar(string nombre, bool habilitado)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new NegocioException("Error al registrar el Color. El campo nombre no pude ser vacío.");

            Nombre = nombre;
            Habilitado = habilitado;
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Modificado;
        }

        public void Eliminar()
        {
            Borrado = true;
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Modificado;
        }
    }
}
