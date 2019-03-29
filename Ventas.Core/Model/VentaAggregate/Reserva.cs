using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Enum;

namespace Ventas.Core.Model.VentaAggregate
{
    public class Reserva : Entity<long>
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Telefono { get; private set; }
        public string Email { get; private set; }
        public string Direccion { get; private set; }
        public DateTime FechaEstimadaRetiro { get; private set; }
        public ReservaMetodoEntrega MetodoEntrega { get; private set; }
        public string Observaciones { get; private set; }
        public DateTime FechaAlta { get; private set; }
        public bool Entregada { get; private set; }
        public DateTime? FechaEntrega { get; private set; }
        public Decimal MontoTotal { get; private set; }
        public Decimal MontoReserva { get; private set; }
        public bool Borrado { get; protected set; }
        public DateTime FechaEdicion { get; internal set; }
        public long IdVentaReserva { get; internal set; }
        public virtual Venta VentaReserva { get; internal set; }
        public long IdVentaEntrega { get; internal set; }
        public virtual Venta VentaEntrega { get; internal set; }

        internal Reserva(): base(false)
        { }

        public Reserva(string nombre,
                       string apellido,
                       string telefono,
                       string email,
                       string direccion,
                       DateTime fechaEstimadaRetiro,
                       ReservaMetodoEntrega metodoEntrega,
                       string observaciones,
                       Venta venta) : base(true)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            FechaAlta = venta.Fecha;
            FechaEstimadaRetiro = fechaEstimadaRetiro;
            MontoTotal = venta.MontoTotal.toDecimal();
            MontoReserva = venta.PagoTotal.Total;
            MetodoEntrega = metodoEntrega;
            Observaciones = observaciones;
            FechaEdicion = venta.FechaEdicion;
            IdVentaReserva = venta.Id;
            VentaReserva = venta;
        }

        public void Entregar(Venta venta)
        {
            Entregada = true;
            FechaEntrega = venta.Fecha;
            FechaEdicion = venta.FechaEdicion;
            IdVentaEntrega = venta.Id;
            VentaEntrega = venta;
        }
    }
}
