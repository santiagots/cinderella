/*
Run this script on:

        sql5090.site4now.net.DB_9B1463_cinderella    -  This database will be modified

to synchronize it with:

        (local)\SQLEXPRESS.Cinderella

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 2/18/2023 5:47:29 PM

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
PRINT N'Altering [dbo].[sp_OrdenCompra_Eliminar]'
GO
IF OBJECT_ID(N'[dbo].[sp_OrdenCompra_Eliminar]', 'P') IS NOT NULL
EXEC sp_executesql N'
ALTER PROCEDURE [dbo].[sp_OrdenCompra_Eliminar]
	@idOrdenCompra AS BIGINT,
    @msg AS INT OUTPUT
AS
	
BEGIN
Begin Tran t_Eliminar
    Begin Try

		BEGIN

			UPDATE ORDEN_COMPRA
			SET Borrado = 1, FechaEdicion = GETDATE()
			where idOrdenCompra = @idOrdenCompra

			UPDATE ORDEN_COMPRA_DETALLE
			SET borrado = 1, FechaEdicion = GETDATE()
			WHERE idOrdenCompra = @idOrdenCompra
		
			SET @msg = 1
			COMMIT TRAN t_Eliminar
		END
			
    End try
    Begin Catch
		BEGIN
			SET @msg = 0
			Rollback TRAN t_Eliminar
		END

    End Catch
END

'
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
