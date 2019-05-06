/*
Run this script on:

        sql5040.site4now.net.DB_9B1463_cinderellaPiloto    -  This database will be modified

to synchronize it with:

        AR5CG4371FY6.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 11.6.11 from Red Gate Software Ltd at 02/05/2019 10:47:56 p.m.

*/
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[PROVINCIAS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[PROVINCIAS] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[SUCURSALES]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[SUCURSALES]', N'id_ListaGrupoPrecio') IS NOT NULL
ALTER TABLE [dbo].[SUCURSALES] DROP COLUMN [id_ListaGrupoPrecio]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Vendedor] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Encargado] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Vendedor_Feriado] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Encargado_Feriado] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Vendedor_Mayor] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Encargado_Mayor] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[DEPARTAMENTOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[DEPARTAMENTOS] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[LOCALIDADES]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[LOCALIDADES] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_CHEQUE]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_CHEQUE]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_CHEQUE]
(
[Id] [bigint] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdVenta] [bigint] NULL,
[NumeroOrden] [int] NOT NULL,
[NumeroCheque] [int] NOT NULL,
[MarcaFacturado] [bit] NOT NULL,
[Monto] [decimal] (18, 2) NOT NULL,
[IdBancoEmisor] [int] NOT NULL,
[IdCliente] [int] NOT NULL,
[ClienteNombre] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[IdLibrador] [int] NULL,
[LibradorNombre] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[FechaIngreso] [date] NOT NULL,
[FechaDesposito] [date] NOT NULL,
[FechaVencimiento] [date] NOT NULL,
[FechaSalida] [date] NULL,
[DetalleSalida] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Estado] [int] NOT NULL CONSTRAINT [DF_NUEVA_CHEQUE_Estado] DEFAULT ((0)),
[DestinoSalida] [int] NULL CONSTRAINT [DF_NUEVA_CHEQUE_estinoSalida] DEFAULT ((0)),
[Borrado] [bit] NOT NULL CONSTRAINT [DF_NUEVA_CHEQUE_Borrado] DEFAULT ((0)),
[FechaEdicion] [datetime] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK__CHEQUE__00F135B58DD99550] on [dbo].[NUEVA_CHEQUE]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK__NUEVA_CHEQUE' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_CHEQUE]'))
ALTER TABLE [dbo].[NUEVA_CHEQUE] ADD CONSTRAINT [PK__NUEVA_CHEQUE] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_VENTAS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_VENTAS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_VENTAS]
(
[Id] [bigint] NOT NULL,
[TipoCliente] [int] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdEncargado] [int] NOT NULL,
[IdVendedor] [int] NOT NULL,
[IdClienteMayorista] [int] NULL,
[IdClienteMinorista] [int] NULL,
[PorcentajeFacturacion] [decimal] (18, 2) NULL,
[Numero] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Fecha] [datetime] NOT NULL,
[FechaEdicion] [datetime] NULL,
[CompraCantidadTotalProductos] [int] NOT NULL,
[CompraMontoTotal] [decimal] (18, 2) NOT NULL,
[CompraIvaTotal] [decimal] (18, 2) NOT NULL,
[PagoMontoTotal] [decimal] (18, 2) NOT NULL,
[PagoDescuentoTotal] [decimal] (18, 2) NOT NULL,
[PagoCFTTotal] [decimal] (18, 2) NOT NULL,
[PagoIVATotal] [decimal] (18, 2) NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_VENTAS] on [dbo].[NUEVA_VENTAS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_VENTAS' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTAS]'))
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD CONSTRAINT [PK_NUEVA_VENTAS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_COMISION]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_COMISION]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_COMISION]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[IdEmpleado] [int] NOT NULL,
[IdSucursal] [int] NOT NULL,
[PorcentajeComision] [numeric] (18, 2) NOT NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Fecha] [datetime] NOT NULL,
[Borrado] [bit] NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_COMISION] on [dbo].[NUEVA_COMISION]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_COMISION' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_COMISION]'))
ALTER TABLE [dbo].[NUEVA_COMISION] ADD CONSTRAINT [PK_NUEVA_COMISION] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_FACTURA]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_FACTURA]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_FACTURA]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[TipoFactura] [int] NOT NULL,
[CondicionIVA] [int] NOT NULL,
[NombreYApellido] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Direccion] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Localidad] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[CUIT] [nchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_FACTURA] on [dbo].[NUEVA_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_FACTURA' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_FACTURA]'))
ALTER TABLE [dbo].[NUEVA_FACTURA] ADD CONSTRAINT [PK_NUEVA_FACTURA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_NOTA_PEDIDO]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_NOTA_PEDIDO]
(
[Id] [bigint] NOT NULL,
[TipoCliente] [int] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdEncargado] [int] NOT NULL,
[IdVendedor] [int] NOT NULL,
[IdClienteMayorista] [int] NULL,
[IdClienteMinorista] [int] NULL,
[PorcentajeFacturacion] [decimal] (18, 2) NOT NULL,
[Fecha] [datetime] NOT NULL,
[FechaEdicion] [datetime] NOT NULL,
[Numero] [int] NOT NULL,
[Borrado] [bit] NOT NULL,
[Estado] [int] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_NOTA_PEDIDO] on [dbo].[NUEVA_NOTA_PEDIDO]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_NOTA_PEDIDO' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO]'))
ALTER TABLE [dbo].[NUEVA_NOTA_PEDIDO] ADD CONSTRAINT [PK_NUEVA_NOTA_PEDIDO] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_NOTA_PEDIDO_ITEMS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO_ITEMS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_NOTA_PEDIDO_ITEMS]
(
[Id] [bigint] NOT NULL,
[IdNotaPedido] [bigint] NOT NULL,
[CodigoProducto] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[NombreProducto] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Monto] [decimal] (18, 2) NOT NULL,
[Iva] [decimal] (18, 2) NOT NULL,
[Cantidad] [int] NOT NULL,
[PorcentajeBonificacion] [decimal] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_NOTA_PEDIDO_ITEMS] on [dbo].[NUEVA_NOTA_PEDIDO_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_NOTA_PEDIDO_ITEMS' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO_ITEMS]'))
ALTER TABLE [dbo].[NUEVA_NOTA_PEDIDO_ITEMS] ADD CONSTRAINT [PK_NUEVA_NOTA_PEDIDO_ITEMS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_NUMERO_FACTURA]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_NUMERO_FACTURA]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_NUMERO_FACTURA]
(
[Id] [bigint] NOT NULL,
[IdFactura] [bigint] NOT NULL,
[Numero] [int] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_NUMERO_FACTURA] on [dbo].[NUEVA_NUMERO_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_NUMERO_FACTURA' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_NUMERO_FACTURA]'))
ALTER TABLE [dbo].[NUEVA_NUMERO_FACTURA] ADD CONSTRAINT [PK_NUEVA_NUMERO_FACTURA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_RESERVA]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_RESERVA]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_RESERVA]
(
[Id] [bigint] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdVentaReserva] [bigint] NOT NULL,
[IdVentaEntrega] [bigint] NULL,
[Nombre] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Apellido] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Telefono] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Direccion] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[MetodoEntrega] [int] NOT NULL,
[Observaciones] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Entregada] [bit] NOT NULL,
[FechaAlta] [datetime] NOT NULL,
[FechaEstimadaRetiro] [datetime] NULL,
[FechaEntrega] [datetime] NULL,
[MontoTotal] [decimal] (18, 2) NOT NULL,
[MontoReserva] [decimal] (18, 2) NOT NULL,
[Borrado] [bit] NOT NULL,
[FechaEdicion] [datetime] NULL
)
else
begin
	EXEC ('ALTER TABLE [dbo].[NUEVA_RESERVA] ADD [IdSucursal] [int] NULL;')
	EXEC ('UPDATE [dbo].[NUEVA_RESERVA] SET [IdSucursal]  = (SELECT top 1 [id_Sucursal] from [dbo].[SUCURSALES] order by [id_Sucursal]);')
	EXEC ('ALTER TABLE [dbo].[NUEVA_RESERVA] ALTER COLUMN [IdSucursal] [int] not null;')
end



IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_RESERVA] on [dbo].[NUEVA_RESERVA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_RESERVA' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_RESERVA]'))
ALTER TABLE [dbo].[NUEVA_RESERVA] ADD CONSTRAINT [PK_NUEVA_RESERVA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_VENTA_ITEMS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_VENTA_ITEMS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_VENTA_ITEMS]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[CodigoProducto] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[NombreProducto] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Iva] [numeric] (18, 2) NOT NULL,
[Cantidad] [int] NOT NULL,
[PorcentajeBonificacion] [numeric] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_VENTA_ITEMS] on [dbo].[NUEVA_VENTA_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_VENTA_ITEMS' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_ITEMS]'))
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] ADD CONSTRAINT [PK_NUEVA_VENTA_ITEMS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_VENTA_PAGOS]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[Tarjeta] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[NumeroCuotas] [int] NULL,
[TipoPago] [int] NOT NULL,
[PorcentajeRecargo] [numeric] (18, 2) NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Descuento] [numeric] (18, 2) NOT NULL,
[CFT] [numeric] (18, 2) NOT NULL,
[IVA] [numeric] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_VENTA_PAGOS] on [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_VENTA_PAGOS' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]'))
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] ADD CONSTRAINT [PK_NUEVA_VENTA_PAGOS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_CHEQUE]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_CHEQUE_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_CHEQUE]', 'U'))
ALTER TABLE [dbo].[NUEVA_CHEQUE] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_CHEQUE_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_COMISION]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_COMISION_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_COMISION]', 'U'))
ALTER TABLE [dbo].[NUEVA_COMISION] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_COMISION_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_NUMERO_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_NUMERO_FACTURA_NUEVA_FACTURA]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_NUMERO_FACTURA]', 'U'))
ALTER TABLE [dbo].[NUEVA_NUMERO_FACTURA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_NUMERO_FACTURA_NUEVA_FACTURA] FOREIGN KEY ([IdFactura]) REFERENCES [dbo].[NUEVA_FACTURA] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_FACTURA_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_FACTURA]', 'U'))
ALTER TABLE [dbo].[NUEVA_FACTURA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_FACTURA_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_NOTA_PEDIDO_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_NOTA_PEDIDO_ITEMS_NUEVA_NOTA_PEDIDO]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO_ITEMS]', 'U'))
ALTER TABLE [dbo].[NUEVA_NOTA_PEDIDO_ITEMS] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_NOTA_PEDIDO_ITEMS_NUEVA_NOTA_PEDIDO] FOREIGN KEY ([IdNotaPedido]) REFERENCES [dbo].[NUEVA_NOTA_PEDIDO] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_RESERVA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_RESERVA_NUEVA_RESERVA]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_RESERVA]', 'U'))
ALTER TABLE [dbo].[NUEVA_RESERVA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_RESERVA_NUEVA_RESERVA] FOREIGN KEY ([Id]) REFERENCES [dbo].[NUEVA_RESERVA] ([Id])
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_RESERVA_SUCURSALES]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_RESERVA]', 'U'))
ALTER TABLE [dbo].[NUEVA_RESERVA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_RESERVA_SUCURSALES] FOREIGN KEY ([IdSucursal]) REFERENCES [dbo].[SUCURSALES] ([id_Sucursal])
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_RESERVA_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_RESERVA]', 'U'))
ALTER TABLE [dbo].[NUEVA_RESERVA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_RESERVA_NUEVA_VENTAS] FOREIGN KEY ([IdVentaReserva]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_VENTA_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_VENTA_ITEMS_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_ITEMS]', 'U'))
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_VENTA_ITEMS_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_VENTA_PAGOS_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]', 'U'))
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_VENTA_PAGOS_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
COMMIT TRANSACTION
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
DECLARE @Success AS BIT
SET @Success = 1
SET NOEXEC OFF
IF (@Success = 1) PRINT 'The database update succeeded'
ELSE BEGIN
	IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
	PRINT 'The database update failed'
END
GO