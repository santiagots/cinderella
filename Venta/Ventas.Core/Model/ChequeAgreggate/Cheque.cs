using Common.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Model;
using System;
using Ventas.Core.Model.CuentaCorrienteAggregate;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Model.ChequeAggregate
{
    public class Cheque : Entity<long>
    {
        public int IdSucursal { get; internal set; }
        public long? IdVenta { get; internal set; }
        public virtual Venta Venta { get; internal set; }
        public long? IdDocumentoDePago { get; internal set; }
        public virtual DocumentoDePago DocumentoDePago { get; internal set; }
        public int NumeroOrden { get; internal set; }
        public int NumeroCheque { get; internal set; }
        public bool MarcaFacturado { get; internal set; }
        public decimal Monto { get; internal set; }
        public int IdBancoEmisor { get; internal set; }
        public Banco BancoEmisor { get; internal set; }
        public int IdCliente { get; internal set; }
        public string ClienteNombre { get; internal set; }
        public int IdLibrador { get; internal set; }
        public string LibradorNombre { get; internal set; }
        public DateTime FechaIngreso { get; internal set; }
        public DateTime FechaDesposito { get; internal set; }
        public DateTime FechaVencimiento { get; internal set; }
        public DateTime? FechaSalida { get; internal set; }
        public string DetalleSalida { get; internal set; }
        public EstadoCheque Estado { get; internal set; }
        public DestinoSalidaCheque DestinoSalida { get; internal set; }
        public bool Borrado { get; internal set; }
        public DateTime FechaEdicion { get; internal set; }

        public Cheque()
        { }

        public Cheque(int idSucursal, int numeroOrden, int numeroCheque, bool marcaFacturado, decimal monto, int? idBancoEmisor, int idCliente, string clienteNombre, int idLibrador, string libradorNombre, DateTime fechaIngreso, DateTime fechaDesposito, DateTime fechaVencimiento, DateTime? fechaSalida, string detalleSalida, EstadoCheque estado, DestinoSalidaCheque destinoSalida)
            : base(true)
        {
            if (numeroCheque <= 0)
                throw new NegocioException("Error al generar el Cheque. El numero de cheque debe ser mayo a cero.");

            if (idCliente <= 0 || String.IsNullOrWhiteSpace(clienteNombre))
                throw new NegocioException("Error al generar el Cheque. El cliente no puede ser vacío.");

            if (idLibrador <= 0 || String.IsNullOrWhiteSpace(libradorNombre))
                throw new NegocioException("Error al generar el Cheque. El librador no puede ser vacío.");

            if (monto <= 0)
                throw new NegocioException("Error al generar el Cheque. El motno debe ser mayo a cero.");

            if (!idBancoEmisor.HasValue)
                throw new NegocioException("Error al generar el Cheque. Debe seleccionar un banco emisor.");

            if (destinoSalida != DestinoSalidaCheque.SinSalida && string.IsNullOrWhiteSpace(detalleSalida))
                throw new NegocioException("Error al generar el Cheque. Debe ingresar un detalle de salidad.");

            IdSucursal = idSucursal;
            NumeroOrden = numeroOrden;
            NumeroCheque = numeroCheque;
            MarcaFacturado = marcaFacturado;
            Monto = monto;
            IdBancoEmisor = idBancoEmisor.Value;
            IdCliente = idCliente;
            ClienteNombre = clienteNombre;
            IdLibrador = idLibrador;
            LibradorNombre = libradorNombre;
            FechaIngreso = fechaIngreso;
            FechaDesposito = fechaDesposito;
            FechaVencimiento = fechaVencimiento;
            FechaSalida = fechaSalida == DateTime.MinValue? (DateTime?) null: fechaSalida;
            DetalleSalida = detalleSalida;
            Estado = estado;
            DestinoSalida = destinoSalida;
            Borrado = false;
            FechaEdicion = DateTime.Now;
        }

        public Cheque(long id, int idSucursal, int numeroOrden, int numeroCheque, bool marcaFacturado, decimal monto, int? idBancoEmisor, int idCliente, string clienteNombre, int idLibrador, string libradorNombre, DateTime fechaIngreso, DateTime fechaDesposito, DateTime fechaVencimiento, DateTime? fechaSalida, string detalleSalida, EstadoCheque estado, DestinoSalidaCheque destinoSalida) 
            : this(idSucursal, numeroOrden, numeroCheque, marcaFacturado, monto, idBancoEmisor, idCliente, clienteNombre, idLibrador, libradorNombre, fechaIngreso, fechaDesposito, fechaVencimiento, fechaSalida, detalleSalida, estado, destinoSalida)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Nro. {NumeroCheque} Librador {LibradorNombre} Banco {BancoEmisor.Nombre} F.Dep. {FechaDesposito.ToShortDateString()} F.Ing. {FechaIngreso.ToShortDateString()}";
        }
    }
}
