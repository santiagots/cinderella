using Comex.Core.Enum;
using Common.Core.Exceptions;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Comex.Core.Model.ComexAggregate
{
    public class OrdenCompra : Entity<int>
    {
        public int IdSucursal { get; internal set; }
        public virtual Sucursal Sucursal { get; internal set; }
        public int IdEncargado { get; internal set; }
        public virtual Empleado Encargado { get; internal set; }
        public int IdSupplier { get; internal set; }
        public virtual Supplier Supplier { get; internal set; }
        public DateTime Fecha { get; internal set; }
        public DateTime FechaEdicion { get; internal set; }
        public virtual List<OrdenCompraItem> OrdenCompraItems { get; protected set; }
        public string TerminosDePago { get; protected set; }
        public string PenalidadesPorDemora { get; protected set; }
        public string FechaDeEnvio { get; protected set; }
        public virtual EstadoOrdenCompra Estado { get; protected set; }
        public string MotivoAnulado { get; protected set; }
        public DateTime? FechaAnulado { get; protected set; }

        internal OrdenCompra()
        {
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Modificado;
        }

        public OrdenCompra(int idSucursal) : base(false)
        {
            IdSucursal = idSucursal;
            Fecha = DateTime.Now;
            Estado = EstadoOrdenCompra.Borrador;
            OrdenCompraItems = new List<OrdenCompraItem>();
            EstadoEntidad = Common.Core.Enum.EstadoEntidad.Nuevo;
            ActualizarFechaEdicion();
        }

        public void AgregaOrdenCompraItem(Producto producto, int cantidadCajas)
        {
            OrdenCompraItem ordenCompraItem = OrdenCompraItems.FirstOrDefault(x => x.Producto.Codigo == producto.Codigo);

            if (ordenCompraItem == null)
            {
                ordenCompraItem = new OrdenCompraItem(Id, producto, cantidadCajas);
                OrdenCompraItems.Add(ordenCompraItem);
            }
            else
            {
                ordenCompraItem.Actualizar(cantidadCajas);
            }
            ActualizarFechaEdicion();
        }

        public void QuitarOrdenCompraItem()
        {
            OrdenCompraItems.Clear();
            ActualizarFechaEdicion();
        }

        public void QuitarOrdenCompraItem(string codigo)
        {
            OrdenCompraItem ordenCompraItem = OrdenCompraItems.FirstOrDefault(x => x.Producto.Codigo == codigo);

            if (ordenCompraItem == null)
                throw new NegocioException($"Error al quitar el producto. El producto {codigo} no se ha encontrado.");

            OrdenCompraItems.Remove(ordenCompraItem);
            ActualizarFechaEdicion();
        }

        public void ActualizarOrdenCompraItem(string codigo, int boxQTY)
        {
            OrdenCompraItem ordenCompraItem = OrdenCompraItems.FirstOrDefault(x => x.Producto.Codigo == codigo);

            if (ordenCompraItem == null)
                throw new NegocioException($"Error al actualizar el producto. El producto {codigo} no se ha encontrado.");

            ordenCompraItem.Actualizar(boxQTY);
            ActualizarFechaEdicion();
        }

        public void ActualizarSupplier(Supplier supplier)
        {
            if (supplier == null)
                throw new NegocioException($"Debe seleccionar un supplier. El supplier no puede ser vacío.");

            IdSupplier = supplier.Id;
            Supplier = supplier;
            ActualizarFechaEdicion();
        }

        public void AgregarEncargado(Empleado encargado)
        {
            if (encargado == null)
                throw new NegocioException($"Debe seleccionar un encargado. El encargado no puede ser vacío.");

            IdEncargado = encargado.Id;
            Encargado = encargado;
            ActualizarFechaEdicion();
        }

        public void AgregarTerminosDePago(string terminosDePago)
        {
            if (terminosDePago == null)
                throw new NegocioException($"Debe ingresar terminos de pago. El encargado no puede ser vacío.");

            TerminosDePago = terminosDePago;
            ActualizarFechaEdicion();
        }

        public void AgregarPenalidadesPorDemora(string penalidadesPorDemora)
        {
            if (penalidadesPorDemora == null)
                throw new NegocioException($"Debe ingresar penalidades por demora. El encargado no puede ser vacío.");

            PenalidadesPorDemora = penalidadesPorDemora;
            ActualizarFechaEdicion();
        }

        public void AgregarFechaDeEnvio(string fechaDeEnvio)
        {
            if (fechaDeEnvio == null)
                throw new NegocioException($"Debe ingresar una fecha de envio. El encargado no puede ser vacío.");

            FechaDeEnvio = fechaDeEnvio;
            ActualizarFechaEdicion();
        }

        public void Borrador()
        {
            Estado = EstadoOrdenCompra.Borrador;
            ActualizarFechaEdicion();
        }

        public void Iniciar()
        {
            Estado = EstadoOrdenCompra.Iniciada;
            ActualizarFechaEdicion();
        }

        public void Finalizar()
        {
            Estado = EstadoOrdenCompra.Finalizada;
            ActualizarFechaEdicion();
        }

        public void Anular(string motivo)
        {
            MotivoAnulado = motivo;
            FechaAnulado = DateTime.Now;
            Estado = EstadoOrdenCompra.Anulada;
            ActualizarFechaEdicion();
        }

        private void ActualizarFechaEdicion() => FechaEdicion = DateTime.Now;
    }
}
