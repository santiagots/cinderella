using Ventas.Core.Model.ValueObjects;
using Ventas.Core.Model.VentaAggregate;
using Xunit;

namespace Ventas.Test
{
    public class VentaItemTest
    {
        [Theory]
        [InlineData(1, 500, 0, 0, 500, 1)]
        [InlineData(1, 500, 0, 0, 250, 0.5)]
        [InlineData(1, 400, 100, 0, 250, 0.5)]
        [InlineData(1, 400, 100, 0.4, 50, 0.5)]
        [InlineData(2, 400, 100, 0, 500, 0.5)]
        [InlineData(2, 400, 100, 0.4, 100, 0.5)]
        [InlineData(2, 400, 100, 0.4, 1000, 1)]
        public void pagar_validarPorcentajesPagos(int cantidad, decimal monto, decimal iva, decimal porcentajePago, decimal pago, decimal resultado)
        {
            VentaItem ventaItem = new VentaItem(new Producto("producto"), new CostoProducto(cantidad, new MontoProducto(monto, iva)), 0, porcentajePago);

            ventaItem.Pagar(pago);

            Assert.Equal(ventaItem.PorcentajePago, resultado);
        }

        [Theory]
        [InlineData(1, 500, 0, 0, 550, 50)]
        [InlineData(1, 500, 0, 0, 250, 0)]
        [InlineData(1, 400, 100, 0, 550, 50)]
        [InlineData(1, 400, 100, 0, 250, 0)]
        [InlineData(1, 400, 100, 0.5, 500, 250)]
        [InlineData(2, 400, 100, 0, 2000, 1000)]
        [InlineData(2, 400, 100, 0.5, 1000, 500)]
        public void pagar_validarVuelto(int cantidad, decimal monto, decimal iva, decimal porcentajePago, decimal pago, decimal resultado)
        {
            VentaItem ventaItem = new VentaItem(new Producto("producto"), new CostoProducto(cantidad, new MontoProducto(monto, iva)), 0, porcentajePago);

            decimal vuelto = ventaItem.Pagar(pago);

            Assert.Equal(vuelto, resultado);
        }
    }
}
