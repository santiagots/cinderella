/*
Run this script on:

        (local)\SQLEXPRESS.C:\USERS\STAMBOUR\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        AR5CG4371FY6.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 11.6.11 from Red Gate Software Ltd at 27/08/2019 10:31:24 p.m.

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
PRINT N'Dropping foreign keys from [dbo].[NUEVA_CIERRE_CAJA]'
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_CIERRE_CAJA_USUARIOS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_CIERRE_CAJA]', 'U'))
ALTER TABLE [dbo].[NUEVA_CIERRE_CAJA] DROP CONSTRAINT [FK_NUEVA_CIERRE_CAJA_USUARIOS]
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_CIERRE_CAJA_USUARIOS1]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_CIERRE_CAJA]', 'U'))
ALTER TABLE [dbo].[NUEVA_CIERRE_CAJA] DROP CONSTRAINT [FK_NUEVA_CIERRE_CAJA_USUARIOS1]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[sp_MovCajaFuerte_ObtenerPorFecha]'
GO
IF OBJECT_ID(N'[dbo].[sp_MovCajaFuerte_ObtenerPorFecha]', 'P') IS NULL
EXEC sp_executesql N'-- =============================================
-- Author:		Morpheus
-- Create date: 28/08/12
-- Description:	Obtener Movimientos.
-- =============================================
CREATE PROCEDURE [dbo].[sp_MovCajaFuerte_ObtenerPorFecha] 
@id_Sucursal AS INT,
@FDesde AS date,
@FHasta AS date,
@Tipo as int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select Fecha_Sys as Fecha, Monto
	from MOVIMIENTOS_CAJA_FUERTE  
	where (Borrado = 0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal) and id_Tipo = @Tipo	
END



'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_CIERRE_CAJA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_CIERRE_CAJA_USUARIOS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_CIERRE_CAJA]', 'U'))
ALTER TABLE [dbo].[NUEVA_CIERRE_CAJA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_CIERRE_CAJA_USUARIOS] FOREIGN KEY ([IdUsuarioCierre]) REFERENCES [dbo].[USUARIOS] ([id_Usuario])
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_CIERRE_CAJA_USUARIOS1]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_CIERRE_CAJA]', 'U'))
ALTER TABLE [dbo].[NUEVA_CIERRE_CAJA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_CIERRE_CAJA_USUARIOS1] FOREIGN KEY ([IdUsuarioAbre]) REFERENCES [dbo].[USUARIOS] ([id_Usuario])
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