/*
Run this script on:

        sql5030.site4now.net.DB_9B1463_cinderellaProd    -  This database will be modified

to synchronize it with:

        (local).CINDERELLA

You are recommended to back up your database before running this script

Script created by SQL Compare version 11.6.11 from Red Gate Software Ltd at 18/11/2018 10:42:56 p.m.

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
PRINT N'Altering [dbo].[SUCURSALES]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[SUCURSALES]', N'id_ListaGrupoPrecio') IS NOT NULL
ALTER TABLE [dbo].[SUCURSALES] DROP COLUMN [id_ListaGrupoPrecio]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[sp_Sucursales_Alta]'
GO
IF OBJECT_ID(N'[dbo].[sp_Sucursales_Alta]', 'P') IS NOT NULL
EXEC sp_executesql N'-- =============================================
-- Author:		Morpheus
-- Create date: 24/01/12
-- Description:	Alta de Sucursales
-- =============================================
ALTER PROCEDURE [dbo].[sp_Sucursales_Alta]
    @Nombre AS VARCHAR(255),                   
    @Direccion AS VARCHAR(255),      
    @id_Provincia AS INT,      
    @id_Departamento AS INT,      
    @id_Localidad AS INT,     
    @ComisionEncargado as float,
    @ComisionVendedor as float,                 
    @ComisionEncargadoFeriado as float,
    @ComisionVendedorFeriado as float,         
    @ComisionEncargadoMayor as float,
    @ComisionVendedorMayor as float,      
    @CodigoPostal AS INT,    
    @Telefono AS VARCHAR(255),
	@Mail AS VARCHAR(255), 
    @Habilitado AS SMALLINT, 
	@CodigoVenta as VARCHAR(10),          
    @msg AS VARCHAR(255) OUTPUT
AS

	IF EXISTS ( SELECT Nombre FROM dbo.SUCURSALES WHERE Nombre = @Nombre )
		BEGIN
			SET @msg = ''La sucursal ya se encuentra registrada.''
		END
	ELSE
	
BEGIN
Begin Tran t_Alta

    Begin Try

		BEGIN
			INSERT INTO dbo.SUCURSALES (Nombre,Comision_Vendedor,Comision_Encargado,Comision_Vendedor_Feriado,Comision_Encargado_Feriado,Comision_Vendedor_Mayor,Comision_Encargado_Mayor,Direccion,id_Provincia,id_Departamento,id_Localidad,Codigo_Postal,Telefono,Habilitado,Codigo_Venta,Mail) 
			VALUES (@Nombre,@ComisionVendedor,@ComisionEncargado,@ComisionVendedorFeriado,@ComisionEncargadoFeriado,@ComisionVendedorMayor,@ComisionEncargadoMayor,@Direccion,@id_Provincia,@id_Departamento,@id_Localidad,@CodigoPostal,@Telefono,@Habilitado,@CodigoVenta,@Mail)
			SET @msg = ''La sucursal se ha registrado correctamente.''
			COMMIT TRAN t_Alta
		END
			
    End try
    Begin Catch
		BEGIN
			SET @msg = ''Ocurrio un Error: '' + ERROR_MESSAGE() + '' en la línea '' + CONVERT(NVARCHAR(255), ERROR_LINE() ) + ''.''
			Rollback TRAN t_Alta
		END

    End Catch
END



'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[sp_Sucursales_Modificacion]'
GO
IF OBJECT_ID(N'[dbo].[sp_Sucursales_Modificacion]', 'P') IS NOT NULL
EXEC sp_executesql N'-- =============================================
-- Author:		Morpheus
-- Create date: 24/01/12
-- Description:	Modificacion de sucursales del sistema.
-- =============================================
ALTER PROCEDURE [dbo].[sp_Sucursales_Modificacion]
    @id_Sucursal AS INT,
    @Nombre AS VARCHAR(255),                  
    @Direccion AS VARCHAR(255),      
    @id_Provincia AS INT,      
    @id_Departamento AS INT, 
    @ComisionVendedor as float,
    @ComisionEncargado as float,    
    @ComisionVendedorFeriado as float,
    @ComisionEncargadoFeriado as float,       
    @ComisionVendedorMayor as float,
    @ComisionEncargadoMayor as float,  
    @id_Localidad AS INT,                      
    @CodigoPostal AS INT,    
    @Telefono AS VARCHAR(255),
	@Mail AS VARCHAR(255),   
    @Habilitado AS SMALLINT,    
	@CodigoVenta as VARCHAR(10),      
    @msg AS VARCHAR(255) OUTPUT
AS
BEGIN
Begin Tran t_Mod
    Begin Try
		UPDATE dbo.SUCURSALES set Nombre=@Nombre,Comision_Vendedor=@ComisionVendedor,Comision_Encargado=@ComisionEncargado,Comision_Vendedor_Feriado=@ComisionVendedorFeriado,Comision_Encargado_Feriado=@ComisionEncargadoFeriado,Comision_Vendedor_Mayor=@ComisionVendedorMayor,Comision_Encargado_Mayor=@ComisionEncargadoMayor,Direccion=@Direccion,id_Provincia=@id_Provincia,id_Departamento=@id_Departamento,Habilitado=@Habilitado,id_Localidad=@id_Localidad,Codigo_Postal=@CodigoPostal,Telefono=@Telefono, Codigo_Venta=@CodigoVenta, Mail = @Mail
		where id_Sucursal=@id_Sucursal
        SET @msg = ''La sucursal se ha modificado correctamente.''
        COMMIT TRAN t_Mod
    End try
    Begin Catch
        SET @msg = ''Ocurrio un Error: '' + ERROR_MESSAGE() + '' en la línea '' + CONVERT(NVARCHAR(255), ERROR_LINE() ) + ''.''
        Rollback TRAN t_Mod
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