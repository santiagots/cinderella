/*
Run this script on:

        (local)\SQLEXPRESS.C:\USERS\SANTI\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        AR5CG4371FY6.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 11.6.11 from Red Gate Software Ltd at 17/05/2019 12:33:04 p.m.

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
PRINT N'Dropping constraints from [dbo].[CHEQUE]'
GO
IF EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK__CHEQUE__00F135B58DD99550]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[CHEQUE]', 'U'))
ALTER TABLE [dbo].[CHEQUE] DROP CONSTRAINT [PK__CHEQUE__00F135B58DD99550]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping constraints from [dbo].[CHEQUE]'
GO
IF EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Estado' AND object_id = OBJECT_ID(N'[dbo].[CHEQUE]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF__CHEQUE__Estado__239E4DCF]', 'D'))
ALTER TABLE [dbo].[CHEQUE] DROP CONSTRAINT [DF__CHEQUE__Estado__239E4DCF]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping constraints from [dbo].[CHEQUE]'
GO
IF EXISTS (SELECT 1 FROM sys.columns WHERE name = N'DestinoSalida' AND object_id = OBJECT_ID(N'[dbo].[CHEQUE]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_DestinoSalida]', 'D'))
ALTER TABLE [dbo].[CHEQUE] DROP CONSTRAINT [DF_DestinoSalida]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping constraints from [dbo].[CHEQUE]'
GO
IF EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Borrado' AND object_id = OBJECT_ID(N'[dbo].[CHEQUE]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_CHEQUE_Borrado]', 'D'))
ALTER TABLE [dbo].[CHEQUE] DROP CONSTRAINT [DF_CHEQUE_Borrado]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[NUEVA_VENTA_PAGOS]', N'PorcentajeRecargo') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] ADD[PorcentajeRecargo] [numeric] (18, 2) NULL CONSTRAINT [DF_NUEVA_VENTA_PAGOS_PorcentajeRecargo] DEFAULT ((0))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
UPDATE [dbo].[NUEVA_VENTA_PAGOS] SET [NumeroCuotas]=((0)) WHERE [NumeroCuotas] IS NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] ALTER COLUMN [NumeroCuotas] [int] NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_VENTAS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'Numero') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[Numero] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'CompraCantidadTotalProductos') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[CompraCantidadTotalProductos] [int] NOT NULL CONSTRAINT [DF_NUEVA_VENTAS_CompraCantidadTotalProductos] DEFAULT ((0))
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'CompraMontoTotal') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[CompraMontoTotal] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_VENTAS_CompraMontoTotal] DEFAULT ((0))
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'CompraIvaTotal') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[CompraIvaTotal] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_VENTAS_CompraIvaTotal] DEFAULT ((0))
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'PagoMontoTotal') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[PagoMontoTotal] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_VENTAS_PagoMontoTotal] DEFAULT ((0))
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'PagoDescuentoTotal') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[PagoDescuentoTotal] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_VENTAS_PagoDescuentoTotal] DEFAULT ((0))
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'PagoCFTTotal') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[PagoCFTTotal] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_VENTAS_PagoCFTTotal] DEFAULT ((0))
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'PagoIVATotal') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[PagoIVATotal] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_VENTAS_PagoIVATotal] DEFAULT ((0))
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'Anulado') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[Anulado] [bit] NULL CONSTRAINT [DF_NUEVA_VENTAS_Anulado] DEFAULT ((0))
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'MotivoAnulado') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[MotivoAnulado] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
IF COL_LENGTH(N'[dbo].[NUEVA_VENTAS]', N'FechaAnulado') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD[FechaAnulado] [datetime] NULL
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
[Estado] [int] NOT NULL CONSTRAINT [DF__CHEQUE__Estado__239E4DCF] DEFAULT ((0)),
[DestinoSalida] [int] NULL CONSTRAINT [DF_DestinoSalida] DEFAULT ((0)),
[Borrado] [bit] NOT NULL CONSTRAINT [DF_CHEQUE_Borrado] DEFAULT ((0)),
[FechaEdicion] [datetime] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK__CHEQUE__00F135B58DD99550] on [dbo].[NUEVA_CHEQUE]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK__CHEQUE__00F135B58DD99550' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_CHEQUE]'))
ALTER TABLE [dbo].[NUEVA_CHEQUE] ADD CONSTRAINT [PK__CHEQUE__00F135B58DD99550] PRIMARY KEY CLUSTERED  ([Id])
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
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_RESERVA] on [dbo].[NUEVA_RESERVA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_RESERVA' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_RESERVA]'))
ALTER TABLE [dbo].[NUEVA_RESERVA] ADD CONSTRAINT [PK_NUEVA_RESERVA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding constraints to [dbo].[CHEQUE]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Estado' AND object_id = OBJECT_ID(N'[dbo].[CHEQUE]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF__CHEQUE__Estado__46623E31]', 'D'))
ALTER TABLE [dbo].[CHEQUE] ADD CONSTRAINT [DF__CHEQUE__Estado__46623E31] DEFAULT ((0)) FOR [Estado]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE name = N'DestinoSalida' AND object_id = OBJECT_ID(N'[dbo].[CHEQUE]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF__CHEQUE__DestinoS__4756626A]', 'D'))
ALTER TABLE [dbo].[CHEQUE] ADD CONSTRAINT [DF__CHEQUE__DestinoS__4756626A] DEFAULT ((0)) FOR [DestinoSalida]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Borrado' AND object_id = OBJECT_ID(N'[dbo].[CHEQUE]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF__CHEQUE__Borrado__484A86A3]', 'D'))
ALTER TABLE [dbo].[CHEQUE] ADD CONSTRAINT [DF__CHEQUE__Borrado__484A86A3] DEFAULT ((0)) FOR [Borrado]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding constraints to [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE name = N'NumeroCuotas' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_NUEVA_VENTA_PAGOS_NumeroCuotas]', 'D'))
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] ADD CONSTRAINT [DF_NUEVA_VENTA_PAGOS_NumeroCuotas] DEFAULT ((0)) FOR [NumeroCuotas]
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