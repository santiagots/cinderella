using Common.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ValueObjects;
using Common.Core.Enum;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Model.PresupuestoAgreggate
{
    public class Presupuesto : Transaccion
    {
        public int Numero { get; protected set; }
        public virtual IList<PresupuestoItem> PresupuestoItems { get; protected set; } = new List<PresupuestoItem>();
        public long? IdClienteMinorista { get; protected set; }
        public ClienteMinorista ClienteMinorista { get; internal set; }
        public string MotivoAnulado { get; protected set; }
        public TipoPago CondicionPago { get; protected set; }
        public bool Anulado { get; protected set; }
        public DateTime? FechaAnulado { get; protected set; }
        public new MontoProducto MontoTotal => PresupuestoItems.Count(x => !x.Borrado) > 0 ? PresupuestoItems.Where(x => !x.Borrado).Select(x => x.MontoProducto * x.Cantidad).Aggregate((x, y) => x + y) : new MontoProducto(0, 0);

        internal Presupuesto() : base()
        {
        }

        public Presupuesto(Venta venta) : base(true)
        {
            IdClienteMayorista = venta.IdClienteMayorista;
            ClienteMayorista = venta.ClienteMayorista;
            TipoCliente = venta.TipoCliente;
            IdSucursal = venta.IdSucursal;
            Sucursal = venta.Sucursal;
            IdEncargado = venta.IdEncargado;
            Encargado = venta.Encargado;
            IdVendedor = venta.IdVendedor;
            Vendedor = venta.Vendedor;
            PorcentajeFacturacion = venta.PorcentajeFacturacion;
            IdClienteMayorista = venta.IdClienteMayorista;
            ClienteMayorista = venta.ClienteMayorista;
            Fecha = DateTime.Now;
            FechaEdicion = Fecha;
            CondicionPago = venta.Pagos.First().TipoPago;
            EstadoEntidad = EstadoEntidad.Nuevo;

            PresupuestoItems = new List<PresupuestoItem>();

            foreach (var ventaItem in venta.VentaItems)
            {
                PresupuestoItems.Add(new PresupuestoItem(Id, ventaItem, PorcentajeFacturacion));
            }
        }

        public void AgregarNumero(int numero)
        {
            Numero = numero;
        }

        public void Anular(string motivo, string usuario)
        {
            if (Anulado)
                throw new NegocioException("Error al anular el presupuesto. El presupuesto ya se encuentra anulada.");

            if (string.IsNullOrWhiteSpace(motivo))
                throw new NegocioException("Error al anular el presupuesto. Debe ingresar un motivo para anular el presupuesto.");

            Anulado = true;
            MotivoAnulado = $"{DateTime.Now.ToString()} - {usuario.ToString()} - {motivo}";
            FechaAnulado = DateTime.Now;
            EstadoEntidad = EstadoEntidad.Modificado;
        }
    }
}
