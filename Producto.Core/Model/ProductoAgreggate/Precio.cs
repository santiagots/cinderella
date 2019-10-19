using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.Core.Model.ProductoAgreggate
{
    public class Precio : Entity<int>
    {
        public int IdProducto { get; protected set; }
        public int IdLista { get; protected set; }
        public decimal Monto { get; protected set; }
        public bool Habilitado { get; protected set; }

        public Precio() : base()
        { }

        public Precio(int idLista, decimal monto)
        {
            IdLista = idLista;
            Monto = monto;
        }

        public Precio(int idPrecio, int idProducto, int idLista, decimal monto): this(idLista, monto)
        {
            Id = idPrecio;
            IdProducto = idProducto;
        }

        public void ActualizarMonto(decimal monto)
        {
            Monto = monto;
        }
    }
}
