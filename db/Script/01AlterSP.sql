/*
Run this script on:

        (local)\SQLEXPRESS.C:\USERS\STAMBOUR\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        AR-CNU434BG8X.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 13.7.7.10021 from Red Gate Software Ltd at 8/4/2020 19:10:59

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
PRINT N'Dropping constraints from [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF EXISTS (SELECT 1 FROM sys.columns WHERE name = N'PorcentajeRecargo' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_NUEVA_VENTA_PAGOS_PorcentajeRecargo]', 'D'))
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] DROP CONSTRAINT [DF_NUEVA_VENTA_PAGOS_PorcentajeRecargo]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_FACTURA]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[NUEVA_FACTURA]', N'CAE') IS NULL
ALTER TABLE [dbo].[NUEVA_FACTURA] ADD[CAE] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
IF COL_LENGTH(N'[dbo].[NUEVA_FACTURA]', N'FechaVencimientoCAE') IS NULL
ALTER TABLE [dbo].[NUEVA_FACTURA] ADD[FechaVencimientoCAE] [datetime] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_NOTA_CREDITO]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[NUEVA_NOTA_CREDITO]', N'CAE') IS NULL
ALTER TABLE [dbo].[NUEVA_NOTA_CREDITO] ADD[CAE] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
IF COL_LENGTH(N'[dbo].[NUEVA_NOTA_CREDITO]', N'FechaVencimientoCAE') IS NULL
ALTER TABLE [dbo].[NUEVA_NOTA_CREDITO] ADD[FechaVencimientoCAE] [datetime] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] ALTER COLUMN [PorcentajeRecargo] [numeric] (18, 4) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding constraints to [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE name = N'PorcentajeRecargo' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_NUEVA_VENTA_PAGOS_PorcentajeRecargo]', 'D'))
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] ADD CONSTRAINT [DF_NUEVA_VENTA_PAGOS_PorcentajeRecargo] DEFAULT ((0)) FOR [PorcentajeRecargo]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [NonClusteredIndex-20191211-223923] on [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'NonClusteredIndex-20191211-223923' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]'))
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20191211-223923] ON [dbo].[NUEVA_VENTA_PAGOS] ([IdVenta]) INCLUDE ([CFT], [Descuento], [IVA], [Monto])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_IVA]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_IVA]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_IVA]
(
[Id] [int] NOT NULL,
[Valor] [decimal] (6, 4) NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_IVA] on [dbo].[NUEVA_IVA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_IVA]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_IVA]', 'U'))
ALTER TABLE [dbo].[NUEVA_IVA] ADD CONSTRAINT [PK_NUEVA_IVA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[PRODUCTOS_SUBCATEGORIAS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[PRODUCTOS_SUBCATEGORIAS]', N'IdIVA') IS NULL
ALTER TABLE [dbo].[PRODUCTOS_SUBCATEGORIAS] ADD[IdIVA] [int] NOT NULL CONSTRAINT [DF_PRODUCTOS_SUBCATEGORIAS_IVA] DEFAULT ((5))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [NonClusteredIndex-20191211-223721] on [dbo].[NUEVA_VENTAS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'NonClusteredIndex-20191211-223721' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTAS]'))
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20191211-223721] ON [dbo].[NUEVA_VENTAS] ([Anulado], [IdSucursal]) INCLUDE ([Fecha], [Id], [TipoCliente])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [NonClusteredIndex-20191212-231147] on [dbo].[NUEVA_VENTA_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'NonClusteredIndex-20191212-231147' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_ITEMS]'))
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20191212-231147] ON [dbo].[NUEVA_VENTA_ITEMS] ([IdProducto])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[PRODUCTOS_SUBCATEGORIAS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUCTOS_SUBCATEGORIAS_NUEVA_IVA]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUCTOS_SUBCATEGORIAS]', 'U'))
ALTER TABLE [dbo].[PRODUCTOS_SUBCATEGORIAS] WITH NOCHECK  ADD CONSTRAINT [FK_PRODUCTOS_SUBCATEGORIAS_NUEVA_IVA] FOREIGN KEY ([IdIVA]) REFERENCES [dbo].[NUEVA_IVA] ([Id])
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
