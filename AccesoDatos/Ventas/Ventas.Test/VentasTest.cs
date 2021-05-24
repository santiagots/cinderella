using System;
using Ventas.Core.Model.VentaAggregate;
using Ventas.Core.Model.ValueObjects;
using Common.Core.Enum;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace Ventas.Test
{
    public class VentasTest
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        public void Agregar_VentaItem(int numeroProductos, int cantidad, int cantidadTotal)
        {
            Venta venta = new Venta();
            VentaItem ventaItem = new VentaItem(new Producto("producto 1"), new CostoProducto(cantidad, new MontoProducto(3.5m, 2)), 0.5m, 0);

            for (int i = 0; i < numeroProductos; i++)
            {
                venta.AgregaVentaItem(ventaItem);
            }
            
            Assert.Equal(cantidadTotal, venta.CantidadTotal);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 1, 1)]
        [InlineData(1, 2, 0)]
        [InlineData(2, 2, 2)]
        public void Agregar_QuitarVentaItem(int numeroProductos, int cantidad, int cantidadTotal)
        {
            Venta venta = new Venta();
            VentaItem ventaItem = new VentaItem(new Producto("producto 1"), new CostoProducto(cantidad, new MontoProducto(3.5m, 2)), 0.5m, 0);
            for (int i = 0; i < numeroProductos; i++)
            {
                venta.AgregaVentaItem(ventaItem);
            }

            venta.QuitarVentaItem(ventaItem);

            Assert.Equal(cantidadTotal, venta.CantidadTotal);
        }

        [Theory]
        [InlineData(1, 1, 40, 0, 40, 0)]
        [InlineData(1, 1, 40, 10, 40, 10)]
        [InlineData(1, 2, 40, 0, 80, 0)]
        [InlineData(1, 2, 40, 10, 80, 20)]
        [InlineData(2, 2, 40, 10, 160, 40)]
        public void Obtener_PendientesPago(int numeroProductos, int cantidad, decimal productoMonto, decimal productoIva, decimal pendientePagoMonto, decimal pendeientePagoIva)
        {
            Venta venta = new Venta();
            VentaItem ventaItem = new VentaItem(new Producto("producto 1"), new CostoProducto(cantidad, new MontoProducto(productoMonto, productoIva)), 0, 0);
            for (int i = 0; i < numeroProductos; i++)
            {
                venta.AgregaVentaItem(ventaItem);
            }

            Assert.Equal(new MontoProducto(pendientePagoMonto, pendeientePagoIva), venta.ObtenerPendientePago());
        }
    }
}
