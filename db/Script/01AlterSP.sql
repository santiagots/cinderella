/*
Run this script on:

        (local)\SQLEXPRESS.C:\USERS\STAMBOUR\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        AR-CNU434BG8X.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 13.7.7.10021 from Red Gate Software Ltd at 2/7/2020 10:51:51

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
PRINT N'Dropping foreign keys from [dbo].[COSTOFINANCIERO]'
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_COSTOFINANCIERO_BANCOS]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[COSTOFINANCIERO]', 'U'))
ALTER TABLE [dbo].[COSTOFINANCIERO] DROP CONSTRAINT [FK_COSTOFINANCIERO_BANCOS]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[COSTOFINANCIERO]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_COSTOFINANCIERO_BANCOS]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[COSTOFINANCIERO]', 'U'))
ALTER TABLE [dbo].[COSTOFINANCIERO] WITH NOCHECK  ADD CONSTRAINT [FK_COSTOFINANCIERO_BANCOS] FOREIGN KEY ([IdTarjeta]) REFERENCES [dbo].[TARJETAS] ([TarjetaId])
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
