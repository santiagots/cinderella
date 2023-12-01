using Common.Core.Exceptions;
using Common.Core.Model;

namespace Producto.Core.Model.ProductoAgreggate
{
    public class Supplier : Entity<int>
    {
        public string Nombre { get; set; }
        public string POL { get; set; }
        public int DeliveryTime { get; set; }
        public bool Habilitado { get; set; }
        public bool Borrado { get; set; }

        protected Supplier()
        {
        }

        public Supplier(string nombre, string pol, int deliveryTime, bool habilitado) : base(false)
        {
            if(string.IsNullOrEmpty(nombre))
                throw new NegocioException("Error al registrar el Supplier. El campo nombre no pude ser vacío.");
            if (string.IsNullOrEmpty(pol))
                throw new NegocioException("Error al registrar el Supplier. El campo POL no pude ser vacío.");

            Nombre = nombre;
            POL = pol;
            DeliveryTime = deliveryTime;
            Habilitado = habilitado;
            Borrado = false;
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Nuevo;
        }

        public void Modificar(string nombre, string pol, int deliveryTime, bool habilitado)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new NegocioException("Error al registrar el Supplier. El campo nombre no pude ser vacío.");
            if (string.IsNullOrEmpty(pol))
                throw new NegocioException("Error al registrar el Supplier. El campo POL no pude ser vacío.");

            Nombre = nombre;
            POL = pol;
            DeliveryTime = deliveryTime;
            Habilitado = habilitado;
            Borrado = false;
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Modificado;
        }

        public void Eliminar()
        {
            Borrado = true;
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Modificado;
        }
    }
}
