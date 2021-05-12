using Common.Core.Model;
using Stock.Core.Enum;
using System;

namespace Stock.Core.Model.BaseAgreggate
{
    public class Bitacora : Entity<long>
    {
        public int IdProducto { get; private set; }
        public Producto Producto { get; private set; }
        public int IdSucursal { get; private set; }
        public long IdStock { get; private set; }
        public Stock Stock { get; private set; }
        public TipoBitacoraAccion Accion { get; private set; }
        public int StockMinimoAnterior { get; private set; }
        public int StockActualAnterior { get; private set; }
        public int StockOptimoAnterior { get; private set; }
        public int? VentaMensualAnterior { get; private set; }
        public int StockMinimo { get; private set; }
        public int StockActual { get; private set; }
        public int StockOptimo { get; private set; }
        public int? VentaMensual { get; private set; }
        public DateTime Fecha { get; private set; }
        public string Motivo { get; private set; }
        public int IdUsuario { get; private set; }
        public Usuario Usuario { get; private set; }
        public bool Habilitado { get; private set; }
        public DateTime FechaEdicion { get; private set; }
        public decimal Total => (StockActual - StockActualAnterior) * (Producto != null? Producto.Costo : 0);

        public Bitacora():base(true)
        {
        }

        public void Modificar(Stock stockNuevo, Stock stockAnterior)
        {
            IdProducto = stockNuevo.Producto.Id;
            Producto = stockNuevo.Producto;
            IdSucursal = stockNuevo.IdSucursal;
            IdStock = stockNuevo.Id;
            Stock = stockNuevo;
            Accion = TipoBitacoraAccion.Modificación;
            StockMinimoAnterior = stockAnterior.Minimo;
            StockActualAnterior = stockAnterior.Cantidad;
            StockOptimoAnterior = stockAnterior.Optimo;
            VentaMensualAnterior = stockAnterior.VentaMensual;
            StockMinimo = stockNuevo.Minimo;
            StockActual = stockNuevo.Cantidad;
            StockOptimo = stockNuevo.Optimo;
            VentaMensual = stockNuevo.VentaMensual;
            Motivo = stockNuevo.MotivoModificacion;
            IdUsuario = stockNuevo.Usuario.Id;
            Usuario = stockNuevo.Usuario;
            Habilitado = stockNuevo.Habilitado;
            Fecha = stockNuevo.FechaEdicion;
            FechaEdicion = stockNuevo.FechaEdicion;
        }

        public void Alta(Stock stock)
        {
            IdProducto = stock.Producto.Id;
            Producto = stock.Producto;
            IdSucursal = stock.IdSucursal;
            IdStock = stock.Id;
            Stock = stock;
            Accion = TipoBitacoraAccion.Alta;
            StockMinimo = stock.Minimo;
            StockActual = stock.Cantidad;
            StockOptimo = stock.Optimo;
            VentaMensual = stock.VentaMensual;
            Motivo = "Alta de stock";
            IdUsuario = stock.Usuario.Id;
            Usuario = stock.Usuario;
            Habilitado = stock.Habilitado;
            Fecha = stock.FechaEdicion;
            FechaEdicion = stock.FechaEdicion;
        }

        public void Borrar(Stock stock)
        {
            IdProducto = stock.Producto.Id;
            Producto = stock.Producto;
            IdSucursal = stock.IdSucursal;
            IdStock = stock.Id;
            Stock = stock;
            Accion = TipoBitacoraAccion.Eliminación;
            StockMinimoAnterior = stock.Minimo;
            StockActualAnterior = stock.Cantidad;
            StockOptimoAnterior = stock.Optimo;
            VentaMensualAnterior = stock.VentaMensual;
            Motivo = stock.MotivoModificacion;
            IdUsuario = stock.Usuario.Id;
            Usuario = stock.Usuario;
            Fecha = stock.FechaEdicion;
            FechaEdicion = stock.FechaEdicion;
        }
    }
}
