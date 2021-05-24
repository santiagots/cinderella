using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Model;
using System;
using System.Linq;

namespace Stock.Core.Model.BaseAgreggate
{
    public class Stock : Entity<long>
    {
        public int IdSucursal { get; private set; }
        public int IdProducto { get; private set; }
        public Producto Producto { get; private set; }
        public int Cantidad { get; private set; }
        public int Minimo { get; private set; }
        public int Optimo { get; private set; }
        public int VentaMensual { get; private set; }
        public int Reservado { get; private set; }
        public int Restante => Cantidad - Reservado;
        public bool Habilitado { get; private set; }
        public string MotivoModificacion { get; private set; }
        public int? IdUsuario { get; private set; }
        public Usuario Usuario { get; private set; }
        public bool Modificado { get; private set; }
        public bool Borrado { get; private set; }
        public DateTime Fecha { get; private set; }
        public DateTime FechaModificacion { get; private set; }
        public DateTime FechaEdicion { get; private set; }

        public Stock()
        {
        }

        public Stock(int idSucursal, Producto producto, int cantidad, int minimo, int optimo, bool habilitado, Usuario usuario) : base(true)
        {
            IdSucursal = idSucursal;
            IdProducto = producto.Id;
            Producto = producto;
            Cantidad = cantidad;
            Minimo = minimo;
            Optimo = optimo;
            IdUsuario = usuario.Id;
            Usuario = usuario;
            Habilitado = habilitado;
            Modificado = false;
            Borrado = false;
            Fecha = DateTime.Now;
            FechaModificacion = DateTime.Now;
            FechaEdicion = DateTime.Now;
            VentaMensual = 0;
        }

        public void Actualiza(int? cantidad, int? minimo, int? optimo, int? ventaMensual, bool? habilitado, string motivo, bool? borrado, Usuario usuario)
        {
            if (minimo > optimo)
                throw new NegocioException("Error al actualizar el stock. El stock minimo no puede ser mayor al optimo.");

            if (string.IsNullOrWhiteSpace(motivo))
                if(!borrado.HasValue)
                    throw new NegocioException("Error al actualizar el stock. Debe ingresar un motivo.");
                else
                    throw new NegocioException("Error al borrar el stock. Debe ingresar un motivo.");

            if(cantidad.HasValue)
                Cantidad = cantidad.Value;

            if (minimo.HasValue)
                Minimo = minimo.Value;

            if (optimo.HasValue)
                Optimo = optimo.Value;

            if (ventaMensual.HasValue)
                VentaMensual = ventaMensual.Value;

            if (habilitado.HasValue)
                Habilitado = habilitado.Value;

            if (borrado.HasValue)
                Borrado = borrado.Value;

            MotivoModificacion = motivo;
            IdUsuario = usuario.Id;
            Usuario = usuario;
            Modificado = true;
            FechaModificacion = DateTime.Now;
            FechaEdicion = DateTime.Now;
        }

        public void CargarReserva(int reserva)
        {
            Reservado = reserva;
        }
    }
}
