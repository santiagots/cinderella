/*
Run this script on:

        sql5030.site4now.net.DB_9B1463_cinderella    -  This database will be modified

to synchronize it with:

        AR5CG4371FY6.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 11.6.11 from Red Gate Software Ltd at 06/03/2019 08:24:58 a.m.

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
PRINT N'Dropping constraints from [dbo].[STOCK]'
GO
IF EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Modificado' AND object_id = OBJECT_ID(N'[dbo].[STOCK]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_STOCK_Modificado]', 'D'))
ALTER TABLE [dbo].[STOCK] DROP CONSTRAINT [DF_STOCK_Modificado]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[PRECIOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[PRECIOS] ALTER COLUMN [Precio] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[PRECIOS] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Refreshing [dbo].[VW_PRECIOS]'
GO
IF OBJECT_ID(N'[dbo].[VW_PRECIOS]', 'V') IS NOT NULL
EXEC sp_refreshview N'[dbo].[VW_PRECIOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[SUCURSALES]'
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
PRINT N'Altering [dbo].[STOCK]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
UPDATE [dbo].[STOCK] SET [Modificado]=((0)) WHERE [Modificado] IS NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[STOCK] ALTER COLUMN [Habilitado] [bit] NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[STOCK] ALTER COLUMN [Modificado] [bit] NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[CLIENTEMINORISTA]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[CLIENTEMINORISTA] ALTER COLUMN [Telefono] [nvarchar] (125) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
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
[Fecha] [datetime] NOT NULL,
[FechaEdicion] [datetime] NULL
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
PRINT N'Creating [dbo].[PAGO]'
GO
IF OBJECT_ID(N'[dbo].[PAGO]', 'U') IS NULL
CREATE TABLE [dbo].[PAGO]
(
[id_Pago] [bigint] NOT NULL,
[id_Venta] [bigint] NOT NULL,
[id_FormaPago] [int] NOT NULL,
[id_Banco] [int] NULL,
[id_Cuotas] [int] NULL,
[id_Cheque] [bigint] NULL,
[Monto] [float] NOT NULL,
[Descuento] [float] NOT NULL,
[CostoFinanciero] [float] NOT NULL,
[IVA] [float] NOT NULL,
[Total] [float] NOT NULL,
[Fecha_Edicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding constraints to [dbo].[STOCK]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Modificado' AND object_id = OBJECT_ID(N'[dbo].[STOCK]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_STOCK_Modificado]', 'D'))
ALTER TABLE [dbo].[STOCK] ADD CONSTRAINT [DF_STOCK_Modificado] DEFAULT ((0)) FOR [Modificado]
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