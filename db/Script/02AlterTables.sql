/*
Run this script on:

        SQL5090.site4now.net.DB_9B1463_cinderella    -  This database will be modified

to synchronize it with:

        (local)\SQLEXPRESS.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 20/4/2021 10:44:10

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
PRINT N'Dropping constraints from [dbo].[STOCK_BITACORA]'
GO
IF EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Habilitado' AND object_id = OBJECT_ID(N'[dbo].[STOCK_BITACORA]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_STOCK_BITACORA_Habilitado]', 'D'))
ALTER TABLE [dbo].[STOCK_BITACORA] DROP CONSTRAINT [DF_STOCK_BITACORA_Habilitado]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[USUARIOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[USUARIOS] ALTER COLUMN [Habilitado] [bit] NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[STOCK_BITACORA]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[STOCK_BITACORA] ALTER COLUMN [Accion] [int] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[STOCK_BITACORA] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding constraints to [dbo].[STOCK_BITACORA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Habilitado' AND object_id = OBJECT_ID(N'[dbo].[STOCK_BITACORA]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_STOCK_BITACORA_Habilitado]', 'D'))
ALTER TABLE [dbo].[STOCK_BITACORA] ADD CONSTRAINT [DF_STOCK_BITACORA_Habilitado] DEFAULT ((1)) FOR [Habilitado]
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
