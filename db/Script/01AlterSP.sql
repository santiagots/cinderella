/*
Run this script on:

        (local)\SQLEXPRESS.CINDERELLA_LOCAL_PROYECTO    -  This database will be modified

to synchronize it with:

        (local)\SQLEXPRESS.CINDERELLA

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 27/10/2020 15:03:21

*/
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL Serializable
GO
BEGIN TRANSACTION
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[CLIENTEMAYORISTA]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[CLIENTEMAYORISTA] ADD
[MontoCuentaCorriente] [numeric] (18, 2) NOT NULL CONSTRAINT [DF_CLIENTEMAYORISTA_MontoCuentaCorriente] DEFAULT ((0)),
[MontoNotasPedido] [numeric] (18, 2) NOT NULL CONSTRAINT [DF_CLIENTEMAYORISTA_MontoNotasPedido] DEFAULT ((0))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[CLIENTEMAYORISTA] ALTER COLUMN [Comision] [numeric] (18, 2) NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[CLIENTEMAYORISTA] ALTER COLUMN [Bonificacion] [numeric] (18, 2) NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[CLIENTEMAYORISTA] ALTER COLUMN [Lista] [numeric] (18, 2) NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[CLIENTEMAYORISTA] ALTER COLUMN [Habilitado] [bit] NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_CHEQUE]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[NUEVA_CHEQUE] ADD
[IdDocumentoDePago] [bigint] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO]'
GO
CREATE TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO]
(
[Id] [bigint] NOT NULL,
[TipoCliente] [int] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdEncargado] [int] NOT NULL,
[IdClienteMayorista] [int] NOT NULL,
[Numero] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Fecha] [datetime] NOT NULL,
[FechaEdicion] [datetime] NULL,
[PagoMontoTotal] [decimal] (18, 2) NOT NULL,
[PagoDescuentoTotal] [decimal] (18, 2) NOT NULL,
[PagoCFTTotal] [decimal] (18, 2) NOT NULL,
[PagoIVATotal] [decimal] (18, 2) NOT NULL,
[Anulado] [bit] NULL,
[MotivoAnulado] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[FechaAnulado] [datetime] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO] on [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO]'
GO
ALTER TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO] ADD CONSTRAINT [PK_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO]'
GO
CREATE TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO]
(
[Id] [bigint] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdClienteMayorista] [int] NOT NULL,
[Fecha] [datetime] NOT NULL,
[TipoMovimientoCuentaCorriente] [int] NOT NULL,
[TipoAccionCuentaCorriente] [int] NOT NULL,
[NumeroComprobante] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[IdComprobante] [bigint] NOT NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Saldo] [numeric] (18, 2) NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO] on [dbo].[NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO]'
GO
ALTER TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO] ADD CONSTRAINT [PK_NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO]'
GO
CREATE TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO]
(
[Id] [bigint] NOT NULL,
[IdDocumentoDePago] [bigint] NOT NULL,
[TipoPago] [int] NOT NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Descuento] [numeric] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO_Descuento] DEFAULT ((0)),
[CFT] [numeric] (18, 2) NOT NULL,
[IVA] [numeric] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO_IVA] DEFAULT ((0)),
[Tarjeta] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[NumeroCuotas] [int] NOT NULL,
[PorcentajeRecargo] [numeric] (18, 4) NULL,
[FechaEdicion] [datetime] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO] on [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO]'
GO
ALTER TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO] ADD CONSTRAINT [PK_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_DOCUMENTO_PAGO]'
GO
CREATE TABLE [dbo].[NUEVA_DOCUMENTO_PAGO]
(
[Id] [bigint] NOT NULL,
[TipoCliente] [int] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdEncargado] [int] NOT NULL,
[IdVendedor] [int] NOT NULL,
[IdClienteMayorista] [int] NOT NULL,
[Fecha] [datetime] NOT NULL,
[FechaEdicion] [datetime] NOT NULL,
[PagoMontoTotal] [decimal] (18, 2) NOT NULL,
[PagoDescuentoTotal] [decimal] (18, 2) NOT NULL,
[PagoCFTTotal] [decimal] (18, 2) NOT NULL,
[PagoIVATotal] [decimal] (18, 2) NOT NULL,
[Anulado] [bit] NULL,
[MotivoAnulado] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[FechaAnulado] [datetime] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_DOCUMENTO_PAGO] on [dbo].[NUEVA_DOCUMENTO_PAGO]'
GO
ALTER TABLE [dbo].[NUEVA_DOCUMENTO_PAGO] ADD CONSTRAINT [PK_NUEVA_DOCUMENTO_PAGO] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO]'
GO
ALTER TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_SUCURSALES] FOREIGN KEY ([IdSucursal]) REFERENCES [dbo].[SUCURSALES] ([id_Sucursal])
GO
ALTER TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_CLIENTEMAYORISTA] FOREIGN KEY ([IdClienteMayorista]) REFERENCES [dbo].[CLIENTEMAYORISTA] ([id_Cliente])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO]'
GO
ALTER TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO_CLIENTEMAYORISTA] FOREIGN KEY ([IdClienteMayorista]) REFERENCES [dbo].[CLIENTEMAYORISTA] ([id_Cliente])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
COMMIT TRANSACTION
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
-- This statement writes to the SQL Server Log so SQL Monitor can show this deployment.
IF HAS_PERMS_BY_NAME(N'sys.xp_logevent', N'OBJECT', N'EXECUTE') = 1
BEGIN
    DECLARE @databaseName AS nvarchar(2048), @eventMessage AS nvarchar(2048)
    SET @databaseName = REPLACE(REPLACE(DB_NAME(), N'\', N'\\'), N'"', N'\"')
    SET @eventMessage = N'Redgate SQL Compare: { "deployment": { "description": "Redgate SQL Compare deployed to ' + @databaseName + N'", "database": "' + @databaseName + N'" }}'
    EXECUTE sys.xp_logevent 55000, @eventMessage
END
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
