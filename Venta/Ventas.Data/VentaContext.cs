﻿using Common.Core.Enum;
using Common.Core.Model;
using Common.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Ventas.Core.Model.BaseAgreggate;
using Ventas.Core.Model.ChequeAggregate;
using Ventas.Core.Model.CuentaCorrienteAggregate;
using Ventas.Core.Model.NotaPedidoAgreggate;
using Ventas.Core.Model.RemitoAgreggate;
using Ventas.Core.Model.VentaAggregate;

namespace Ventas.Data
{
    public class VentaContext: CommonContext
    {
        public VentaContext(TipoBase local = TipoBase.Local) : base(local)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cheque> Cheque { get; set; }
        public DbSet<ClienteMinorista> ClienteMinorista { get; set; }
        public DbSet<CierreCaja> CierreCaja { get; set; }
        public DbSet<CostoFinanciero> CostoFinanciero { get; set; }
        public DbSet<Comision> Comision { get; set; }
        public DbSet<DocumentoDePago> DocumentoDePago { get; set; }
        public DbSet<DocumentoDePagoPago> DocumentoDePagoPago { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Factura> Factura  { get; set; }
        public DbSet<NumeroFactura> NumeroFactura { get; set; }
        public DbSet<NumeroNotaCredito> NumeroNotaCredito { get; set; }
        public DbSet<VentaPago> VentaPago { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Tarjeta> Tarjeta { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<VentaItem> VentaItem { get; set; }
        public DbSet<NotaPedido> NotaPedido { get; set; }
        public DbSet<NotaPedidoItem> NotaPedidoItem { get; set; }
        public DbSet<NotaCredito> NotaCredito { get; set; }
        public DbSet<Movimiento> Movimiento { get; set; }
        public DbSet<Remito> Remito { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Cheque>().ToTable("NUEVA_CHEQUE");
            modelBuilder.Entity<Cheque>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Cheque>().HasRequired(v => v.BancoEmisor).WithMany().HasForeignKey(x => x.IdBancoEmisor);

            modelBuilder.Entity<ClienteMinorista>().ToTable("CLIENTEMINORISTA");
            modelBuilder.Entity<ClienteMinorista>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<ClienteMinorista>().Property(t => t.Id).HasColumnName("id_ClienteMinorista");
            modelBuilder.Entity<ClienteMinorista>().Ignore(t => t.ApellidoYNombre);

            modelBuilder.Entity<CierreCaja>().ToTable("NUEVA_CIERRE_CAJA");
            modelBuilder.Entity<CierreCaja>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<CostoFinanciero>().ToTable("COSTOFINANCIERO");
            modelBuilder.Entity<CostoFinanciero>().Property(t => t.Id).HasColumnName("CostoFinancieroId");
            modelBuilder.Entity<CostoFinanciero>().Property(t => t.IdTarjeta).HasColumnName("IdTarjeta");
            modelBuilder.Entity<CostoFinanciero>().Property(t => t.NumeroCuota).HasColumnName("NroCuota");

            modelBuilder.Entity<Comision>().ToTable("NUEVA_COMISION");
            modelBuilder.Entity<Comision>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Categoria>().ToTable("PRODUCTOS_CATEGORIAS");
            modelBuilder.Entity<Categoria>().Property(t => t.Id).HasColumnName("id_Categoria");
            modelBuilder.Entity<Categoria>().Ignore(t => t.SubCategorias);

            modelBuilder.Entity<SubCategoria>().ToTable("PRODUCTOS_SUBCATEGORIAS");
            modelBuilder.Entity<SubCategoria>().Property(t => t.Id).HasColumnName("id_Subcategoria");
            modelBuilder.Entity<SubCategoria>().Ignore(t => t.IdCategoria);
            modelBuilder.Entity<SubCategoria>().Ignore(t => t.Categoria);
            modelBuilder.Entity<SubCategoria>().HasRequired(v => v.IVA).WithMany().HasForeignKey(x => x.IdIVA);

            modelBuilder.Entity<DocumentoDePago>().ToTable("NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO");
            modelBuilder.Entity<DocumentoDePago>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<DocumentoDePago>().Property(t => t.PagoTotal.Monto).HasColumnName("PagoMontoTotal");
            modelBuilder.Entity<DocumentoDePago>().Property(t => t.PagoTotal.Descuento).HasColumnName("PagoDescuentoTotal");
            modelBuilder.Entity<DocumentoDePago>().Property(t => t.PagoTotal.CFT).HasColumnName("PagoCFTTotal");
            modelBuilder.Entity<DocumentoDePago>().Property(t => t.PagoTotal.IVA).HasColumnName("PagoIVATotal");
            modelBuilder.Entity<DocumentoDePago>().Ignore(t => t.MontoTotal);
            modelBuilder.Entity<DocumentoDePago>().Ignore(t => t.PorcentajeFacturacion);
            modelBuilder.Entity<DocumentoDePago>().HasMany(v => v.Pagos).WithRequired(t => t.DocumentoDePago).HasForeignKey(x => x.IdDocumentoDePago);
            modelBuilder.Entity<DocumentoDePago>().HasMany(v => v.Cheques).WithOptional(t => t.DocumentoDePago).HasForeignKey(x => x.IdDocumentoDePago);
            modelBuilder.Entity<DocumentoDePago>().HasRequired(v => v.ClienteMayorista).WithMany().HasForeignKey(x => x.IdClienteMayorista);
            modelBuilder.Entity<DocumentoDePago>().HasRequired(v => v.Encargado).WithMany().HasForeignKey(x => x.IdEncargado);
            modelBuilder.Entity<DocumentoDePago>().Ignore(t => t.IdVendedor);
            modelBuilder.Entity<DocumentoDePago>().Ignore(t => t.Vendedor);
            modelBuilder.Entity<DocumentoDePago>().HasRequired(v => v.Sucursal).WithMany().HasForeignKey(x => x.IdSucursal);

            modelBuilder.Entity<DocumentoDePagoPago>().ToTable("NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO");
            modelBuilder.Entity<DocumentoDePagoPago>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<DocumentoDePagoPago>().Property(t => t.MontoPago.Monto).HasColumnName("Monto");
            modelBuilder.Entity<DocumentoDePagoPago>().Property(t => t.MontoPago.Descuento).HasColumnName("Descuento");
            modelBuilder.Entity<DocumentoDePagoPago>().Property(t => t.MontoPago.CFT).HasColumnName("CFT");
            modelBuilder.Entity<DocumentoDePagoPago>().Property(t => t.MontoPago.IVA).HasColumnName("IVA");
            modelBuilder.Entity<DocumentoDePagoPago>().Property(t => t.NumeroOrdenChequesData).HasColumnName("NumeroOrdenCheques");
            modelBuilder.Entity<DocumentoDePagoPago>().Property(t => t.PorcentajeRecargo).HasPrecision((int)18, (int)4);
            modelBuilder.Entity<DocumentoDePagoPago>().HasOptional(v => v.CuentaBancaria).WithMany().HasForeignKey(x => x.IdCuentaBancaria);
            modelBuilder.Entity<DocumentoDePagoPago>().Ignore(t => t.NumeroOrdenCheques);
            modelBuilder.Entity<DocumentoDePagoPago>().Ignore(t => t.MontoRestante);
            modelBuilder.Entity<DocumentoDePagoPago>().Ignore(t => t.Habilitado);

            modelBuilder.Entity<Factura>().ToTable("NUEVA_FACTURA");
            modelBuilder.Entity<Factura>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Factura>().HasMany(v => v.NumeroFactura).WithRequired(t => t.Factura).HasForeignKey(x => x.IdFactura);

            modelBuilder.Entity<NotaCredito>().ToTable("NUEVA_NOTA_CREDITO");
            modelBuilder.Entity<NotaCredito>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<NotaCredito>().HasMany(v => v.NumeroNotaCredito).WithRequired(t => t.NotaCredito).HasForeignKey(x => x.IdNotaCredito);

            modelBuilder.Entity<NumeroFactura>().ToTable("NUEVA_NUMERO_FACTURA");
            modelBuilder.Entity<NumeroFactura>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<NumeroNotaCredito>().ToTable("NUEVA_NUMERO_NOTA_CREDITO");
            modelBuilder.Entity<NumeroNotaCredito>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Venta>().ToTable("NUEVA_VENTAS");
            modelBuilder.Entity<Venta>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Venta>().Property(t => t.CantidadTotal).HasColumnName("CompraCantidadTotalProductos");
            modelBuilder.Entity<Venta>().Property(t => t.MontoTotal.Iva).HasColumnName("CompraIvaTotal");
            modelBuilder.Entity<Venta>().Property(t => t.MontoTotal.Valor).HasColumnName("CompraMontoTotal");
            modelBuilder.Entity<Venta>().Property(t => t.PagoTotal.Monto).HasColumnName("PagoMontoTotal");
            modelBuilder.Entity<Venta>().Property(t => t.PagoTotal.Descuento).HasColumnName("PagoDescuentoTotal");
            modelBuilder.Entity<Venta>().Property(t => t.PagoTotal.CFT).HasColumnName("PagoCFTTotal");
            modelBuilder.Entity<Venta>().Property(t => t.PagoTotal.IVA).HasColumnName("PagoIVATotal");
            modelBuilder.Entity<Venta>().HasMany(v => v.Comisiones).WithRequired(t => t.Venta).HasForeignKey(x => x.IdVenta);
            modelBuilder.Entity<Venta>().HasOptional(v => v.Factura).WithRequired(f => f.Venta);
            modelBuilder.Entity<Venta>().HasOptional(v => v.NotaCredito).WithRequired(f => f.Venta);
            modelBuilder.Entity<Venta>().HasMany(v => v.Pagos).WithRequired(t => t.Venta).HasForeignKey(x => x.IdVenta);
            modelBuilder.Entity<Venta>().HasMany(v => v.VentaItems).WithRequired(t => t.Venta).HasForeignKey(x => x.IdVenta);
            modelBuilder.Entity<Venta>().HasMany(v => v.Cheques).WithOptional(t => t.Venta).HasForeignKey(x => x.IdVenta);
            modelBuilder.Entity<Venta>().HasRequired(v => v.Encargado).WithMany().HasForeignKey(x => x.IdEncargado);
            modelBuilder.Entity<Venta>().HasRequired(v => v.Vendedor).WithMany().HasForeignKey(x => x.IdVendedor);
            modelBuilder.Entity<Venta>().HasOptional(v => v.ClienteMayorista).WithMany().HasForeignKey(x => x.IdClienteMayorista);
            modelBuilder.Entity<Venta>().HasRequired(v => v.Sucursal).WithMany().HasForeignKey(x => x.IdSucursal);

            modelBuilder.Entity<VentaPago>().ToTable("NUEVA_VENTA_PAGOS");
            modelBuilder.Entity<VentaPago>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<VentaPago>().Property(t => t.MontoPago.Monto).HasColumnName("Monto");
            modelBuilder.Entity<VentaPago>().Property(t => t.MontoPago.Descuento).HasColumnName("Descuento");
            modelBuilder.Entity<VentaPago>().Property(t => t.MontoPago.CFT).HasColumnName("CFT");
            modelBuilder.Entity<VentaPago>().Property(t => t.MontoPago.IVA).HasColumnName("IVA");
            modelBuilder.Entity<VentaPago>().Property(t => t.NumeroOrdenChequesData).HasColumnName("NumeroOrdenCheques");
            modelBuilder.Entity<VentaPago>().Property(t => t.PorcentajeRecargo).HasPrecision((int)18, (int)4);
            modelBuilder.Entity<VentaPago>().HasOptional(v => v.CuentaBancaria).WithMany().HasForeignKey(x => x.IdCuentaBancaria);
            modelBuilder.Entity<VentaPago>().Ignore(t => t.NumeroOrdenCheques);
            modelBuilder.Entity<VentaPago>().Ignore(t => t.MontoRestante);
            modelBuilder.Entity<VentaPago>().Ignore(t => t.Habilitado);

            modelBuilder.Entity<Reserva>().ToTable("NUEVA_RESERVA");
            modelBuilder.Entity<Reserva>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Reserva>().HasRequired(v => v.VentaReserva).WithMany().HasForeignKey(x => x.IdVentaReserva);
            modelBuilder.Entity<Reserva>().HasRequired(v => v.VentaEntrega).WithMany().HasForeignKey(x => x.IdVentaEntrega);

            modelBuilder.Entity<VentaItem>().ToTable("NUEVA_VENTA_ITEMS");
            modelBuilder.Entity<VentaItem>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<VentaItem>().Property(t => t.Cantidad).HasColumnName("Cantidad");
            modelBuilder.Entity<VentaItem>().Property(t => t.MontoProducto.Valor).HasColumnName("Monto");
            modelBuilder.Entity<VentaItem>().Property(t => t.MontoProducto.Iva).HasColumnName("Iva");
            modelBuilder.Entity<VentaItem>().HasRequired(v => v.Producto).WithMany().HasForeignKey(x => x.IdProducto);
            modelBuilder.Entity<VentaItem>().Ignore(t => t.Total);
            modelBuilder.Entity<VentaItem>().Ignore(t => t.PorcentajePago);
            modelBuilder.Entity<VentaItem>().Ignore(t => t.Seleccionado);

            modelBuilder.Entity<NotaPedido>().ToTable("NUEVA_NOTA_PEDIDO");
            modelBuilder.Entity<NotaPedido>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<NotaPedido>().HasMany(v => v.NotaPedidoItems).WithRequired(t => t.NotaPedido).HasForeignKey(x => x.IdNotaPedido);
            modelBuilder.Entity<NotaPedido>().HasRequired(v => v.Vendedor).WithMany().HasForeignKey(x => x.IdVendedor);
            modelBuilder.Entity<NotaPedido>().HasOptional(v => v.Encargado).WithMany().HasForeignKey(x => x.IdEncargado);
            modelBuilder.Entity<NotaPedido>().HasOptional(v => v.ClienteMinorista).WithMany().HasForeignKey(x => x.IdClienteMinorista);
            modelBuilder.Entity<NotaPedido>().HasOptional(v => v.ClienteMayorista).WithMany().HasForeignKey(x => x.IdClienteMayorista);
            modelBuilder.Entity<NotaPedido>().HasRequired(v => v.Sucursal).WithMany().HasForeignKey(x => x.IdSucursal);

            modelBuilder.Entity<NotaPedidoItem>().ToTable("NUEVA_NOTA_PEDIDO_ITEMS");
            modelBuilder.Entity<NotaPedidoItem>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<NotaPedidoItem>().Property(t => t.Cantidad).HasColumnName("Cantidad");
            modelBuilder.Entity<NotaPedidoItem>().Property(t => t.MontoProducto.Valor).HasColumnName("Monto");
            modelBuilder.Entity<NotaPedidoItem>().Property(t => t.MontoProducto.Iva).HasColumnName("Iva");
            modelBuilder.Entity<NotaPedidoItem>().HasRequired(v => v.Producto).WithMany().HasForeignKey(x => x.IdProducto);

            modelBuilder.Entity<Movimiento>().ToTable("NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO");
            modelBuilder.Entity<Movimiento>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Movimiento>().HasRequired(v => v.Sucursal).WithMany().HasForeignKey(x => x.IdSucursal);

            modelBuilder.Entity<Empleado>().ToTable("EMPLEADOS");
            modelBuilder.Entity<Empleado>().Property(t => t.Id).HasColumnName("id_Empleado");
            modelBuilder.Entity<Empleado>().Property(t => t.Tipo).HasColumnName("id_TipoEmpleado");

            modelBuilder.Entity<Precio>().ToTable("PRECIOS");
            modelBuilder.Entity<Precio>().Property(t => t.Id).HasColumnName("id_Precio");
            modelBuilder.Entity<Precio>().Property(t => t.IdLista).HasColumnName("id_Lista");
            modelBuilder.Entity<Precio>().Property(t => t.IdProducto).HasColumnName("id_Producto");
            modelBuilder.Entity<Precio>().Property(t => t.Monto).HasColumnName("Precio");
            modelBuilder.Entity<Precio>().HasRequired(t => t.Producto).WithMany(t => t.Precios).HasForeignKey(t => t.IdProducto);

            modelBuilder.Entity<Producto>().ToTable("PRODUCTOS");
            modelBuilder.Entity<Producto>().Property(t => t.Id).HasColumnName("id_Producto");
            modelBuilder.Entity<Producto>().Property(t => t.IdCategoria).HasColumnName("id_Categoria");
            modelBuilder.Entity<Producto>().Property(t => t.IdSubcategoria).HasColumnName("id_Subcategoria");
            modelBuilder.Entity<Producto>().HasRequired(t => t.Categoria).WithMany().HasForeignKey(x => x.IdCategoria);
            modelBuilder.Entity<Producto>().HasRequired(t => t.SubCategoria).WithMany().HasForeignKey(x => x.IdSubcategoria);
            modelBuilder.Entity<Producto>().Ignore(t => t.Stock);

            modelBuilder.Entity<Remito>().ToTable("NUEVA_REMITOS");
            modelBuilder.Entity<Remito>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Remito>().HasRequired(v => v.Venta).WithMany().HasForeignKey(x => x.IdVenta);
            modelBuilder.Entity<Remito>().HasMany(v => v.RemitoItems).WithRequired(t => t.Remito).HasForeignKey(x => x.IdRemito);
            modelBuilder.Entity<Remito>().Ignore(t => t.MontoTotal);

            modelBuilder.Entity<RemitoItem>().ToTable("NUEVA_REMITO_ITEMS");
            modelBuilder.Entity<RemitoItem>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<RemitoItem>().Property(t => t.Cantidad).HasColumnName("Cantidad");
            modelBuilder.Entity<RemitoItem>().Property(t => t.Monto.Valor).HasColumnName("Monto");
            modelBuilder.Entity<RemitoItem>().Property(t => t.Monto.Iva).HasColumnName("Iva");
            modelBuilder.Entity<RemitoItem>().Ignore(t => t.Total);

            modelBuilder.Entity<Sucursal>().ToTable("SUCURSALES");
            modelBuilder.Entity<Sucursal>().Property(t => t.Id).HasColumnName("id_Sucursal");
            modelBuilder.Entity<Sucursal>().Property(t => t.CodigoVenta).HasColumnName("Codigo_Venta");
            modelBuilder.Entity<Sucursal>().Property(t => t.PorcentajeComisionMayoristaVendedor).HasColumnName("Comision_Vendedor_Mayor");
            modelBuilder.Entity<Sucursal>().Property(t => t.PorcentajeComisionMayoristEncargado).HasColumnName("Comision_Encargado_Mayor");
            modelBuilder.Entity<Sucursal>().Property(t => t.PorcentajeComisionMinoristaEncargado).HasColumnName("Comision_Encargado");
            modelBuilder.Entity<Sucursal>().Property(t => t.PorcentajeComisionMinoristaVendedor).HasColumnName("Comision_Vendedor");
            modelBuilder.Entity<Sucursal>().Property(t => t.PorcentajeComisionMinoristaEncargadoFeriado).HasColumnName("Comision_Encargado_Feriado");
            modelBuilder.Entity<Sucursal>().Property(t => t.PorcentajeComisionMinoristaVendedorFeriado).HasColumnName("Comision_Vendedor_Feriado");

            modelBuilder.Entity<Stock>().ToTable("STOCK");
            modelBuilder.Entity<Stock>().Property(t => t.Id).HasColumnName("id_Stock").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Stock>().Property(t => t.IdSucursal).HasColumnName("id_Sucursal");
            modelBuilder.Entity<Stock>().Property(t => t.IdProducto).HasColumnName("id_Producto");
            modelBuilder.Entity<Stock>().Property(t => t.IdUsuario).HasColumnName("id_Usuario");
            modelBuilder.Entity<Stock>().Property(t => t.Cantidad).HasColumnName("Stock_Actual");
            modelBuilder.Entity<Stock>().Property(t => t.Minimo).HasColumnName("Stock_Minimo");
            modelBuilder.Entity<Stock>().Property(t => t.Optimo).HasColumnName("Stock_Optimo");
            modelBuilder.Entity<Stock>().Property(t => t.Borrado).HasColumnName("Borrado");
            modelBuilder.Entity<Stock>().Property(t => t.Fecha).HasColumnName("Fecha");
            modelBuilder.Entity<Stock>().Property(t => t.FechaEdicion).HasColumnName("Fecha_Edicion");
            modelBuilder.Entity<Stock>().Property(t => t.FechaModificacion).HasColumnName("Fecha_Mod");
            modelBuilder.Entity<Stock>().Property(t => t.Habilitado).HasColumnName("Habilitado");
            modelBuilder.Entity<Stock>().Property(t => t.Modificado).HasColumnName("Modificado");
            modelBuilder.Entity<Stock>().Property(t => t.MotivoModificacion).HasColumnName("Motivo_Mod");
            modelBuilder.Entity<Stock>().Property(t => t.VentaMensual).HasColumnName("Venta_Mensual");
            modelBuilder.Entity<Stock>().Ignore(t => t.Reservado);

            modelBuilder.Entity<Tarjeta>().ToTable("TARJETAS")
                .Property(t => t.Id).HasColumnName("TarjetaId");

            base.OnModelCreating(modelBuilder);
        }
    }
}
