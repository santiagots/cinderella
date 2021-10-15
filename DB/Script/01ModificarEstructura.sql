/*
Run this script on:

        SQL5090.site4now.net.DB_9B1463_cinderella    -  This database will be modified

to synchronize it with:

        (local)\SQLEXPRESS.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 7/10/2021 20:18:57

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
IF COL_LENGTH(N'[dbo].[NUEVA_VENTA_ITEMS]', N'Anulada') IS NULL
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] ADD[Anulada] [bit] NOT NULL CONSTRAINT [DF_NUEVA_VENTA_ITEMS_Anulada] DEFAULT ((0))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF (COL_LENGTH(N'[dbo].[NUEVA_VENTA_ITEMS]', N'EsFacturable') IS NOT NULL) AND (COL_LENGTH(N'[dbo].[NUEVA_VENTA_ITEMS]', N'Facturada') IS NULL)
EXEC sp_rename N'[dbo].[NUEVA_VENTA_ITEMS].[EsFacturable]', N'Facturada', N'COLUMN'
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
