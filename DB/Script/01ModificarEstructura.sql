/*
Run this script on:

        (local)\SQLEXPRESS.C:\USERS\STAMBOUR\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        sql5090.site4now.net.DB_9B1463_cinderellaProd

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 9/17/2022 6:55:37 PM

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
PRINT N'Altering [dbo].[NUEVA_VENTA_ITEMS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] ADD
[Facturada] [bit] NOT NULL CONSTRAINT [DF_NUEVA_VENTA_ITEMS_EsFacturable] DEFAULT ((1)),
[Anulada] [bit] NOT NULL CONSTRAINT [DF_NUEVA_VENTA_ITEMS_Anulada] DEFAULT ((0))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Disabling constraints on [dbo].[NUEVA_VENTA_ITEMS]'
GO
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] NOCHECK CONSTRAINT [FK_NUEVA_VENTA_ITEMS_NUEVA_VENTAS]
GO
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] NOCHECK CONSTRAINT [FK_NUEVA_VENTA_ITEMS_PRODUCTOS]
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
