/*
Run this script on:

        (local).CINDERELLA    -  This database will be modified

to synchronize it with:

        (local).CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 11.6.11 from Red Gate Software Ltd at 27/10/2018 01:57:13 p.m.

*/
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[sp_CajaInicial_Alta]'
GO
IF OBJECT_ID(N'[dbo].[sp_CajaInicial_Alta]', 'P') IS NOT NULL
EXEC sp_executesql N'-- =============================================
-- Author:		Morpheus
-- Create date: 23/10/12
-- Description:	Alta de Caja.
-- =============================================
ALTER PROCEDURE [dbo].[sp_CajaInicial_Alta]
	@id_Caja AS BIGINT,
	@id_Movimiento AS BIGINT,
	@id_Empleado AS INT,
    @id_Sucursal AS INT,
    @Abierta AS INT,
    @Empleado AS VARCHAR(255),
    @Fecha AS date,
    @Hora AS time,
    @Monto AS float,  
	@FechaEdicion AS datetime,        
    @msg AS INT OUTPUT
AS
	
BEGIN
Begin Tran t_Alta
    Begin Try
    
    IF EXISTS ( SELECT id_Caja FROM CAJA_INICIAL WHERE Fecha = @Fecha and id_sucursal = @id_Sucursal and Borrado = 0)
		BEGIN
			SET @msg = 3
			COMMIT TRAN t_Alta
		END
	ELSE
		BEGIN
			INSERT INTO dbo.CAJA_INICIAL(id_Caja,id_Movimiento,id_Empleado,Empleado,id_Sucursal,Hora,Monto,Fecha,Abierta,Fecha_Edicion) 
				VALUES (@id_Caja,@id_Movimiento,@id_Empleado,@Empleado,@id_Sucursal,@Hora,@Monto,@Fecha,@Abierta,@FechaEdicion)
			SET @msg = 1
			COMMIT TRAN t_Alta
		END
    End try
    Begin Catch
		BEGIN
			SET @msg = 0
			Rollback TRAN t_Alta
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
DECLARE @Success AS BIT
SET @Success = 1
SET NOEXEC OFF
IF (@Success = 1) PRINT 'The database update succeeded'
ELSE BEGIN
	IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
	PRINT 'The database update failed'
END
GO