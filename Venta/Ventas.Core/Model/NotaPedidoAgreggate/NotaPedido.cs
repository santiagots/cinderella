using Common.Core.Enum;
using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Enum;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ValueObjects;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Core.Model.NotaPedidoAgreggate
{
    public class NotaPedido : Transaccion
    {
        public int Numero { get; protected set; }
        public virtual IList<NotaPedidoItem> NotaPedidoItems { get; protected set; }
        public new int? IdEncargado { get; internal set; }
        public long? IdClienteMinorista { get; protected set; }
        public ClienteMinorista ClienteMinorista { get; internal set; }
        public NotaPedidoEstado Estado { get; protected set; }
        public bool Borrado { get; protected set; }
        public new MontoProducto MontoTotal { get { return NotaPedidoItems.Select(x => x.MontoProducto * x.Cantidad).Aggregate((x, y) => x + y); } }

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

        public void AgregaNotaPedidoItem(string codigoProducto, string nombreProducto, decimal monto, int cantidad, decimal porcentajeBonificacion, decimal porcentajeFacturacion, TipoCliente tipoCliente)
        {
            NotaPedidoItem notaPedidoItem = NotaPedidoItems.FirstOrDefault(x => x.CodigoProducto == codigoProducto);

            if (notaPedidoItem == null)
            {
                notaPedidoItem = new NotaPedidoItem(Id, codigoProducto, nombreProducto, monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);
                NotaPedidoItems.Add(notaPedidoItem);
            }
            else
            {
                notaPedidoItem.ActualizarMontoProducto(monto, cantidad, porcentajeBonificacion, porcentajeFacturacion, tipoCliente);
            }
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
    }
}
