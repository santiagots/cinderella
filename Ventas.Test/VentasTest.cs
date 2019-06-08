using System;
using Ventas.Core.Model.VentaAggregate;
using Ventas.Core.Model.ValueObjects;
using Common.Core.Enum;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using Common.Data.Repository;
using Ventas.Data;
using Ventas.Data.Repository;
using System.Diagnostics;
using Common.Service.Facturar;
using Common.Core.ValueObjects;

namespace Ventas.Test
{
    public class VentasTest
    {
        //[Theory]
        //[InlineData(1, 1, 1)]
        //[InlineData(2, 1, 2)]
        //[InlineData(1, 2, 2)]
        //[InlineData(2, 2, 4)]
        //public void Agregar_VentaItem(int numeroProductos, int cantidad, int cantidadTotal)
        //{
        //    Venta venta = new Venta();
        //    VentaItem ventaItem = new VentaItem(new Producto(), new CostoProducto(cantidad, new MontoProducto(3.5m, 2)), 0.5m, 0);

        //    for (int i = 0; i < numeroProductos; i++)
        //    {
        //        venta.AgregaVentaItem(ventaItem);
        //    }

        //    Assert.Equal(cantidadTotal, venta.CantidadTotal);
        //}

        //[Theory]
        //[InlineData(1, 1, 0)]
        //[InlineData(2, 1, 1)]
        //[InlineData(1, 2, 0)]
        //[InlineData(2, 2, 2)]
        //public void Agregar_QuitarVentaItem(int numeroProductos, int cantidad, int cantidadTotal)
        //{
        //    Venta venta = new Venta();
        //    VentaItem ventaItem = new VentaItem(new Core.Model.VentaAggregate.Producto("producto 1"), new CostoProducto(cantidad, new MontoProducto(3.5m, 2)), 0.5m, 0);
        //    for (int i = 0; i < numeroProductos; i++)
        //    {
        //        venta.AgregaVentaItem(ventaItem);
        //    }

        //    venta.QuitarVentaItem(ventaItem);

        //    Assert.Equal(cantidadTotal, venta.CantidadTotal);
        //}

        //[Theory]
        //[InlineData(1, 1, 40, 0, 40, 0)]
        //[InlineData(1, 1, 40, 10, 40, 10)]
        //[InlineData(1, 2, 40, 0, 80, 0)]
        //[InlineData(1, 2, 40, 10, 80, 20)]
        //[InlineData(2, 2, 40, 10, 160, 40)]
        //public void Obtener_PendientesPago(int numeroProductos, int cantidad, decimal productoMonto, decimal productoIva, decimal pendientePagoMonto, decimal pendeientePagoIva)
        //{
        //    Venta venta = new Venta();
        //    VentaItem ventaItem = new VentaItem(new Core.Model.VentaAggregate.Producto("producto 1"), new CostoProducto(cantidad, new MontoProducto(productoMonto, productoIva)), 0, 0);
        //    for (int i = 0; i < numeroProductos; i++)
        //    {
        //        venta.AgregaVentaItem(ventaItem);
        //    }

        //    Assert.Equal(new MontoProducto(pendientePagoMonto, pendeientePagoIva), venta.ObtenerPendientePago());
        //}

        //[Theory]
        //[InlineData(1, 1, 40, 0, 0.2, 0, 35, 0, 1)]
        //public void Obtener_PendientesPago(int numeroProductos, int cantidad, decimal productoMonto, decimal productoIva, decimal porcentajeBonificacion, decimal porcentajePago, decimal montoIngresado, decimal porcentajeRecargo, decimal porcentajeFacturacion)
        //{
        //    Venta venta = new Venta();
        //    VentaItem ventaItem = new VentaItem(1, new Producto(1,"p1","producto 1"), new CostoProducto(cantidad, new MontoProducto(productoMonto, productoIva)), porcentajeBonificacion, porcentajePago);
        //    for (int i = 0; i < numeroProductos; i++)
        //    {
        //        venta.AgregaVentaItem(ventaItem);
        //    }

        //    MontoPago montoPago = venta.ObtenerMontoPagoDesdeSubtotal(montoIngresado, porcentajeRecargo);
        //}

        //[Theory]
        //[InlineData(1, 1, 100, 0, 0.2, 0, 108.9, 0.1, 1)]
        //public void Calcular_Pago_Desde_Total(int numeroProductos, int cantidad, decimal productoMonto, decimal productoIva, decimal porcentajeBonificacion, decimal porcentajePago, decimal montoIngresado, decimal porcentajeRecargo, decimal porcentajeFacturacion)
        //{
        //    Venta venta = new Venta();
        //    VentaItem ventaItem = new VentaItem(1, new Producto(1,"p1", "producto 1"), new CostoProducto(cantidad, new MontoProducto(productoMonto, productoIva)), porcentajeBonificacion, porcentajePago);
        //    for (int i = 0; i < numeroProductos; i++)
        //    {
        //        venta.AgregaVentaItem(ventaItem);
        //    }

        //    MontoPago montoPago = venta.ObtenerMontoPagoDesdeTotal(montoIngresado, porcentajeRecargo);
        //}

        //[Fact]
        //public void Guardar()
        //{
        //    VentaItem ventaItem = new VentaItem(1 ,new Producto(8, "icds", "IMAN DE CERAMICA DECORADO SURTIDO"), new CostoProducto(1, new MontoProducto(100,21)), 0.20m, 0.10m);

        //    Venta Venta = new Venta(1, 2, 29, 29, 0, 0, new List<Pago>() { new Pago(1, TipoPago.TarjetaCredito, new Banco(1, "Banco Frances", true), new CostoFinanciero(2,1,2,0.05), new MontoPago(2,2,2,2)) } , new List<VentaItem>() { ventaItem },1, new MontoProducto(100, 21), new MontoPago(100, 123, 12, 12));
        //    using (VentaContext context = new VentaContext())
        //    {
        //        Repository<Venta> VentaItemRepository = new Repository<Venta>(context);
        //        VentaItemRepository.Insert(Venta);
        //    }

        //}

        [Fact]
        public void Guardar()
        {
            List<TicketProducto> prod = new List<TicketProducto>() { new TicketProducto("Test", 1, 1) };

            FacturarControladorFiscalStrategy notaCredito = new FacturarControladorFiscalStrategy();
            notaCredito.ObtenerNumeroFactura(TipoCliente.Minorista, CondicionIVA.Consumidor_Final, null, prod, 1, "nombre", "direccion", "localidad", "1");
        }

    }
}
