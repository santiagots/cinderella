/*
Run this script on:

        ARCNU434BG8X\SQLEXPRESS.C:\USERS\STAMBOUR\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        ARCNU434BG8X.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 13.7.7.10021 from Red Gate Software Ltd at 5/10/2019 11:06:07

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
PRINT N'Dropping constraints from [dbo].[CLIENTEMINORISTA]'
GO
ALTER TABLE [dbo].[CLIENTEMINORISTA] DROP CONSTRAINT [PK_ClienteMinorista]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_VENTAS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[NUEVA_VENTAS] ALTER COLUMN [IdClienteMinorista] [bigint] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_NOTA_PEDIDO]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[NUEVA_NOTA_PEDIDO] ALTER COLUMN [IdEncargado] [int] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[NUEVA_NOTA_PEDIDO] ALTER COLUMN [IdClienteMinorista] [bigint] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Rebuilding [dbo].[CLIENTEMINORISTA]'
GO
CREATE TABLE [dbo].[RG_Recovery_1_CLIENTEMINORISTA]
(
[id_ClienteMinorista] [bigint] NOT NULL,
[Apellido] [nvarchar] (125) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Nombre] [nvarchar] (125) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Telefono] [nvarchar] (125) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Email] [nvarchar] (125) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[EnviarNovedades] [bit] NULL,
[Direccion] [nvarchar] (125) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
INSERT INTO [dbo].[RG_Recovery_1_CLIENTEMINORISTA]([id_ClienteMinorista], [Apellido], [Nombre], [Telefono], [Email], [EnviarNovedades], [Direccion]) SELECT [id_ClienteMinorista], [Apellido], [Nombre], [Telefono], [Email], [EnviarNovedades], [Direccion] FROM [dbo].[CLIENTEMINORISTA]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
DROP TABLE [dbo].[CLIENTEMINORISTA]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
EXEC sp_rename N'[dbo].[RG_Recovery_1_CLIENTEMINORISTA]', N'CLIENTEMINORISTA', N'OBJECT'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_ClienteMinorista] on [dbo].[CLIENTEMINORISTA]'
GO
ALTER TABLE [dbo].[CLIENTEMINORISTA] ADD CONSTRAINT [PK_ClienteMinorista] PRIMARY KEY CLUSTERED  ([id_ClienteMinorista])
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
