using Common.Core.Enum;
using Common.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Enum;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ValueObjects;
using static System.Net.Mime.MediaTypeNames;

namespace Ventas.Core.Model.NotaPedidoAgreggate
{
    public class NotaPedido : Transaccion
    {
        public int Numero { get; protected set; }
        public virtual IList<NotaPedidoItem> NotaPedidoItems { get; protected set; } = new List<NotaPedidoItem>();
        public new int? IdEncargado { get; internal set; }
        public long? IdClienteMinorista { get; protected set; }
        public string Comentarios { get; protected set; }
        public ClienteMinorista ClienteMinorista { get; internal set; }
        public NotaPedidoEstado Estado { get; protected set; }
        public bool Borrado { get; protected set; }
        public new MontoProducto MontoTotal =>  NotaPedidoItems.Count(x => !x.Borrado) > 0? NotaPedidoItems.Where(x => !x.Borrado).Select(x => x.MontoProducto * x.Cantidad).Aggregate((x, y) => x + y): new MontoProducto(0, 0); 

        public NotaPedido() : base()
        {
        }

        public NotaPedido(int idSucursal) : base(true)
        {
            IdSucursal = idSucursal;
            Fecha = DateTime.Now;
            FechaEdicion = DateTime.Now;
            PorcentajeFacturacion = 1;
            NotaPedidoItems = new List<NotaPedidoItem>();
        }

        public void AgregarVendedor(int idVendedor)
        {
            IdVendedor = idVendedor;
        }

        public void AgregarNumero(int numero)
        {
            Numero = numero;
        }

        public void AgregarClienteMinorista(long idClienteMinorista)
        {
            IdClienteMinorista = idClienteMinorista;
        }

        public void AgregarClienteMayorista(int idClienteMayorista)
        {
            IdClienteMayorista = idClienteMayorista;
        }

        public void AgregarTipoCliente(TipoCliente tipoCliente)
        {
            TipoCliente = tipoCliente;
        }

        public void AgregaNotaPedidoItem(Producto producto, decimal monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            NotaPedidoItem notaPedidoItem = NotaPedidoItems.FirstOrDefault(x => x.Producto.Codigo == producto.Codigo);

            if (notaPedidoItem == null)
            {
                notaPedidoItem = new NotaPedidoItem(Id, producto, monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);
                NotaPedidoItems.Add(notaPedidoItem);
            }
            else
            {
                notaPedidoItem.Actualizar(monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);
            }
        }

        public void AgregaNotaPedidoItem(Producto producto, MontoProducto monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            NotaPedidoItem notaPedidoItem = NotaPedidoItems.FirstOrDefault(x => x.Producto.Codigo == producto.Codigo && !x.Borrado);

            if (notaPedidoItem == null)
            {
                notaPedidoItem = new NotaPedidoItem(Id, producto, monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);
                NotaPedidoItems.Add(notaPedidoItem);
            }
            else
            {
                notaPedidoItem.Actualizar(monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);
            }
        }

        public void ActualizaNotaPedidoItem(string codigoProducto, decimal monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            if (porcentajeBonificacion > 1)
                porcentajeBonificacion = 1;

            if (porcentajeFacturacion > 1)
                porcentajeFacturacion = 1;

            this.PorcentajeFacturacion = porcentajeFacturacion;

            NotaPedidoItem notaPedidoItem = NotaPedidoItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto);

            notaPedidoItem.Actualizar(monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);
        }

        public void Actualizar(string comentario, string usuario)
        {
            if (TipoCliente == TipoCliente.Minorista)
                throw new NegocioException($"Las notas de pedido para los clientes minoristas no pueden ser actualizadas.");

            Comentarios += Environment.NewLine + ObtenerComentario(comentario, usuario);
            FechaEdicion = DateTime.Now;
        }

        public void Anular(string comentario, string usuario)
        {
            NotaPedidoEstado nuevoEstado = NotaPedidoEstado.Anulada;

            if (TipoCliente == TipoCliente.Minorista)
                throw new NegocioException($"Las notas de pedido para los clientes minoristas no pueden cambiar al estado {nuevoEstado}");

            if (string.IsNullOrEmpty(comentario))
                throw new NegocioException("Error al anular la nota de pedido. Debe ingresar un motivo para anular una nota de pedido.");

            Comentarios += Environment.NewLine + ObtenerComentario(comentario, usuario, Estado, nuevoEstado);
            Estado = nuevoEstado;
            FechaEdicion = DateTime.Now;
        }

        public void ArmadoFinalizado(string comentario, string usuario)
        {
            NotaPedidoEstado nuevoEstado = NotaPedidoEstado.Venta;

            if (TipoCliente == TipoCliente.Minorista)
                throw new NegocioException($"Las notas de pedido para los clientes minoristas no pueden cambiar al estado {nuevoEstado}");

            Comentarios += Environment.NewLine + ObtenerComentario(comentario, usuario, Estado, nuevoEstado);
            Estado = nuevoEstado;
            FechaEdicion = DateTime.Now;
        }

        public void VolverAIngresada(string comentario, string usuario)
        {
            NotaPedidoEstado nuevoEstado = NotaPedidoEstado.Ingresada;

            if (TipoCliente == TipoCliente.Minorista)
                throw new NegocioException($"Las notas de pedido para los clientes minoristas no pueden cambiar al estado {nuevoEstado}");

            if (string.IsNullOrEmpty(comentario))
                throw new NegocioException($"Error cambiar el estado de la nota de pedido al estado {nuevoEstado}. Debe ingresar un motivo para cambiar el estado de una nota de pedido.");

            Comentarios += Environment.NewLine + ObtenerComentario(comentario, usuario, Estado, nuevoEstado);
            Estado = nuevoEstado;
            FechaEdicion = DateTime.Now;
        }

        public void VentaFinalizada(string usuario)
        {
            NotaPedidoEstado nuevoEstado = TipoCliente == TipoCliente.Mayorista? NotaPedidoEstado.Envio : NotaPedidoEstado.Cerrada;
            Comentarios += Environment.NewLine + ObtenerComentario(usuario, Estado, nuevoEstado);
            Estado = nuevoEstado;
            FechaEdicion = DateTime.Now;
        }

        public void EnvioFinalizado(string comentario, string usuario)
        {
            NotaPedidoEstado nuevoEstado = NotaPedidoEstado.Cerrada;

            if (TipoCliente == TipoCliente.Minorista)
                throw new NegocioException($"Las notas de pedido para los clientes minoristas no pueden cambiar al estado {nuevoEstado}");

            Comentarios += Environment.NewLine + ObtenerComentario(comentario, usuario, Estado, nuevoEstado);
            Estado = nuevoEstado;
            FechaEdicion = DateTime.Now;
        }

        public int ObtenerCantidadDeUnidadesDeProducto(string codigoProducto)
        {
            NotaPedidoItem notaPedidoItems = NotaPedidoItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto && !x.Borrado);
            if (notaPedidoItems == null)
                return 0;
            else
                return notaPedidoItems.Cantidad;
        }

        public void QuitarNotaPedidoItems(string codigoProducto)
        {
            NotaPedidoItem notaPedidoItems = NotaPedidoItems.FirstOrDefault(x => x.Producto.Codigo == codigoProducto);

            if (notaPedidoItems == null)
                throw new NegocioException($"Error al quitar el pago. El producto con código {codigoProducto} no se encuentra registrados en la venta.");

            if (notaPedidoItems.Id > 0)
                notaPedidoItems.Borrar();
            else
                NotaPedidoItems.Remove(notaPedidoItems);
        }

        public void Cerrar()
        {
            Estado = NotaPedidoEstado.Cerrada;
            FechaEdicion = DateTime.Now;
        }

        public void Eliminar()
        {
            FechaEdicion = DateTime.Now;
            Borrado = true;
        }

        private string ObtenerComentario(string nuevoComentario, string usuario)
        {
            nuevoComentario = !string.IsNullOrWhiteSpace(nuevoComentario) ? $"{nuevoComentario}" : string.Empty;

            nuevoComentario = $"--{DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString()} Usuario:{usuario} Modificada{Environment.NewLine}{nuevoComentario}";
            return nuevoComentario;
        }

        private string ObtenerComentario(string usuario, NotaPedidoEstado estadoOriginal, NotaPedidoEstado estadoNuevo)
        {
            return ObtenerComentario(string.Empty, usuario, estadoOriginal, estadoNuevo);
        }

        private string ObtenerComentario(string nuevoComentario, string usuario, NotaPedidoEstado estadoOriginal, NotaPedidoEstado estadoNuevo)
        {
            nuevoComentario = !string.IsNullOrWhiteSpace(nuevoComentario) ? $"{nuevoComentario}" : string.Empty;

            nuevoComentario = $"--{DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString()} Usuario:{usuario} Cambio estado:{estadoOriginal} -> {estadoNuevo}{Environment.NewLine}{nuevoComentario}";
            return nuevoComentario;
        }
    }
}
