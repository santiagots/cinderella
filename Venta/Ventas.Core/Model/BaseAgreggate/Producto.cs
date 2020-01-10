using Common.Core.Enum;
using Common.Core.Model;
using System.Collections.Generic;
using System.Linq;
using Ventas.Core.Model.ValueObjects;
using Common.Core.Constants;
using Common.Core.Exceptions;

namespace Ventas.Core.Model.BaseAgreggate
{
    public class Producto : Entity<int>
    {
        public string Codigo { get; private set; }
        public string CodigoBarra { get; private set; }
        public string Nombre {get; private set; }
        public int IdCategoria { get; private set; }
        public virtual Categoria Categoria { get; private set; }
        public int IdSubcategoria { get; private set; }
        public virtual SubCategoria SubCategoria { get; private set; }
        public virtual Stock Stock { get; set; }
        public virtual IList<Precio> Precios { get; set; }
        
        protected Producto()
        {
        }

        public Producto(int id, string codigo, string codigoBarra, string nombre, Stock stock)
        {
            Id = id;
            Codigo = codigo;
            CodigoBarra = codigoBarra;
            Nombre = nombre;
            Stock = stock;
        }

        public MontoProducto ObtenerMonto(int idPrecioLista, TipoCliente tipoCliente, decimal porcentajeFacturacion)
        {
            Precio precio = Precios.Where(x => x.IdLista == idPrecioLista && x.Habilitado).FirstOrDefault();

            if (precio == null)
                throw new NegocioException($" El producto {Nombre} no tiene un monto para la lista de precio con id {idPrecioLista}");

            if (tipoCliente == TipoCliente.Minorista)
                return new MontoProducto(precio.Monto, 0);
            else
                return new MontoProducto(precio.Monto, precio.Monto * SubCategoria.IVA * porcentajeFacturacion);
        }

        public decimal ObtenerBonificacion(int idPrecioLista, TipoCliente tipoCliente)
        {
            Precio precio = Precios.Where(x => x.IdLista == idPrecioLista + 1 && x.Habilitado).FirstOrDefault();

            if (precio == null)
                throw new NegocioException($" El producto {Nombre} no tiene una bonificacion para la lista de precio con id {idPrecioLista}");

            if (tipoCliente == TipoCliente.Minorista)
                return precio.Monto;
            else
                return 0;
        }

        public bool HayStock(int cantidad)
        {
            if (Stock == null)
                return false;

            return Stock.Cantidad > cantidad;
        }
    }
}
