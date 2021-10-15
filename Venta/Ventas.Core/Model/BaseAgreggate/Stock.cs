using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Core.Model.BaseAgreggate
{
    public class Stock : Entity<long>
    {
        public int IdSucursal { get; private set; } 
        public int IdProducto { get; private set; }
        public int Cantidad { get; private set; }
        public int Minimo { get; private set; }
        public int Optimo { get; private set; }
        public int Reservado { get; private set; }
        public int Disponible => Cantidad - Reservado;
        public bool Habilitado { get; private set; }
        public string MotivoModificacion { get; private set; }
        public int IdUsuario { get; private set; }
        public bool Modificado { get; private set; }
        public bool Borrado { get; private set; }
        public DateTime Fecha { get; private set; }
        public DateTime FechaModificacion { get; private set; }
        public DateTime FechaEdicion { get; private set; }
        public int VentaMensual { get; private set; }

        public Stock()
        {
        }

        public Stock(int idSucursal, int idProducto, int cantidad, int minimo, int optimo, int idUsuario) : base(true)
        {
            IdSucursal = idSucursal;
            IdProducto = idProducto;
            Cantidad = cantidad;
            Minimo = minimo;
            Optimo = optimo;
            IdUsuario = idUsuario;
            Habilitado = true;
            Modificado = false;
            Borrado = false;
            Fecha = DateTime.Now;
            FechaModificacion = DateTime.Now;
            FechaEdicion = DateTime.Now;
            VentaMensual = 0;
        }

        public void Disminuir(int cantidad)
        {
            Cantidad -= cantidad;
        }

        public void Agregar(int cantidad)
        {
            Cantidad += cantidad;
        }

        public void CargarReserva(int reserva)
        {
            Reservado = reserva;
        }
    }
}
