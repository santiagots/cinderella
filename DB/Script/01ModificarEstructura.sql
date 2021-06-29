/*
Run this script on:

        SQL5090.site4now.net.DB_9B1463_cinderella    -  This database will be modified

to synchronize it with:

        (local)\SQLEXPRESS.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 22/6/2021 08:19:07

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
IF COL_LENGTH(N'[dbo].[CLIENTEMAYORISTA]', N'id_Transporte') IS NULL
ALTER TABLE [dbo].[CLIENTEMAYORISTA] ADD[id_Transporte] [int] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_REMITOS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_REMITOS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_REMITOS]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[Numero] [int] NOT NULL,
[CondicionIVA] [int] NOT NULL,
[NombreYApellido] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[CUIT] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Direccion] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Localidad] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RazonSocialTransporte] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[DireccionTransporte] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[LocalidadTransporte] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[CantidadBultos] [int] NOT NULL,
[IncluyeFactura] [bit] NOT NULL,
[DespachoImportacion] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[FechaEdicion] [datetime] NOT NULL,
[Borrado] [bit] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_REMITOS] on [dbo].[NUEVA_REMITOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_REMITOS]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_REMITOS]', 'U'))
ALTER TABLE [dbo].[NUEVA_REMITOS] ADD CONSTRAINT [PK_NUEVA_REMITOS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_REMITO_ITEMS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_REMITO_ITEMS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_REMITO_ITEMS]
(
[Id] [bigint] NOT NULL,
[IdRemito] [bigint] NOT NULL,
[Codigo] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Nombre] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Cantidad] [int] NOT NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Iva] [numeric] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_REMITO_ITEMS] on [dbo].[NUEVA_REMITO_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_REMITO_ITEMS]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_REMITO_ITEMS]', 'U'))
ALTER TABLE [dbo].[NUEVA_REMITO_ITEMS] ADD CONSTRAINT [PK_NUEVA_REMITO_ITEMS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_TRANSPORTE]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_TRANSPORTE]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_TRANSPORTE]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[RazonSocial] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Cuit] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Habilitado] [bit] NOT NULL CONSTRAINT [DF_NUEVA_TRANSPORTE_Habilitado] DEFAULT ((1)),
[IdDomicilio] [int] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_TRANSPORTE] on [dbo].[NUEVA_TRANSPORTE]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_TRANSPORTE]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_TRANSPORTE]', 'U'))
ALTER TABLE [dbo].[NUEVA_TRANSPORTE] ADD CONSTRAINT [PK_NUEVA_TRANSPORTE] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_REMITO_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_REMITO_ITEMS_NUEVA_REMITOS]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_REMITO_ITEMS]', 'U'))
ALTER TABLE [dbo].[NUEVA_REMITO_ITEMS] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_REMITO_ITEMS_NUEVA_REMITOS] FOREIGN KEY ([IdRemito]) REFERENCES [dbo].[NUEVA_REMITOS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_REMITOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_REMITOS_NUEVA_VENTAS]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_REMITOS]', 'U'))
ALTER TABLE [dbo].[NUEVA_REMITOS] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_REMITOS_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_TRANSPORTE]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_TRANSPORTE_DIRECCION]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_TRANSPORTE]', 'U'))
ALTER TABLE [dbo].[NUEVA_TRANSPORTE] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_TRANSPORTE_DIRECCION] FOREIGN KEY ([IdDomicilio]) REFERENCES [dbo].[DIRECCION] ([id_Direccion])
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
