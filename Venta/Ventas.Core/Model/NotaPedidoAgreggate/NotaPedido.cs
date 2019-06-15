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
        public int? IdClienteMinorista { get; protected set; }
        public ClienteMinorista ClienteMinorista { get; internal set; }
        public NotaPedidoEstado Estado { get; protected set; }
        public bool Borrado { get; protected set; }
        public new MontoProducto MontoTotal { get { return NotaPedidoItems.Select(x => x.MontoProducto * x.Cantidad).Aggregate((x, y) => x + y); } }

        public NotaPedido() : base()
        {
        }

        public NotaPedido(bool GenerarId) : base(GenerarId)
        {
        }

        public void AgregarNumero(int numero)
        {
            Numero = numero;
        }

        public void AgregarClienteMinorista(int idClienteMinorista)
        {
            IdClienteMinorista = idClienteMinorista;
        }

        public void AgregarClienteMayorista(int idClienteMayorista)
        {
            IdClienteMayorista = idClienteMayorista;
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
