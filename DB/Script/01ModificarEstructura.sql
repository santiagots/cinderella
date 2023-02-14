/*
Run this script on:

        (local)\SQLEXPRESS.C:\USERS\STAMBOUR\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        (local)\SQLEXPRESS.Cinderella

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 2/13/2023 5:30:29 PM

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
PRINT N'Altering [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO]', N'TipoAccion') IS NULL
ALTER TABLE [dbo].[NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO] ADD[TipoAccion] [int] NOT NULL CONSTRAINT [DF_NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_TipoAccion] DEFAULT ((0))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[sp_EliminarUsuarios]'
GO
IF OBJECT_ID(N'[dbo].[sp_EliminarUsuarios]', 'P') IS NOT NULL
EXEC sp_executesql N'-- =============================================
-- Author:		Morpheus
-- Create date: 25/08/11
-- Description:	Baja de usuario del sistema.
-- =============================================
ALTER PROCEDURE [dbo].[sp_EliminarUsuarios]
	@idusu AS INTEGER,  
    @msg AS VARCHAR(100) OUTPUT
AS
BEGIN
Begin Tran t_BajaUsuario
    Begin Try
		DELETE dbo.REL_USUARIOS_PERFILES where id_Usuario=@idusu 
		DELETE dbo.USUARIOS where id_Usuario=@idusu 
        SET @msg = ''El Usuario se ha eliminado correctamente.''
        COMMIT TRAN t_BajaUsuario
    End try
    Begin Catch
        SET @msg = ''Ocurrio un Error: '' + ERROR_MESSAGE() + '' en la línea '' + CONVERT(NVARCHAR(255), ERROR_LINE() ) + ''.''
        Rollback TRAN t_BajaUsuario
    End Catch
END




'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_DOCUMENTO_PAGO]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[NUEVA_DOCUMENTO_PAGO]', N'TipoAccion') IS NULL
ALTER TABLE [dbo].[NUEVA_DOCUMENTO_PAGO] ADD[TipoAccion] [int] NOT NULL CONSTRAINT [DF_NUEVA_DOCUMENTO_PAGO_TipoAccion] DEFAULT ((0))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Enabling constraints on [dbo].[NUEVA_VENTA_ITEMS]'
GO
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] CHECK CONSTRAINT [FK_NUEVA_VENTA_ITEMS_NUEVA_VENTAS]
GO
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] CHECK CONSTRAINT [FK_NUEVA_VENTA_ITEMS_PRODUCTOS]
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
