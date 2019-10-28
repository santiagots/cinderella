/*
Run this script on:

        ARCNU434BG8X\SQLEXPRESS.C:\USERS\STAMBOUR\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        ARCNU434BG8X.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 13.7.7.10021 from Red Gate Software Ltd at 27/10/2019 23:10:31

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
PRINT N'Altering [dbo].[sp_Comisiones_Listado]'
GO
-- =============================================
-- Author:		Morpheus
-- Create date: 16-04-2012
-- Description:	obtiene el listado de comisiones
-- =============================================
ALTER PROCEDURE [dbo].[sp_Comisiones_Listado] 
@id_Empleado AS INTEGER,
@id_Sucursal AS INTEGER, 
@FDesde AS DATE, 
@FHasta AS DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		NUEVA_COMISION.Monto,
		NUEVA_COMISION.PorcentajeComision as Comision,
		NUEVA_COMISION.Fecha, 
		NUEVA_VENTAS.PagoMontoTotal - NUEVA_VENTAS.PagoDescuentoTotal + NUEVA_VENTAS.PagoCFTTotal + NUEVA_VENTAS.PagoIVATotal  as Precio_Total
	from NUEVA_COMISION
	INNER JOIN NUEVA_VENTAS ON NUEVA_COMISION.IdVenta = NUEVA_VENTAS.Id
	where (NUEVA_COMISION.Borrado=0) and (NUEVA_COMISION.idEmpleado=@id_Empleado) and (NUEVA_COMISION.Fecha between @FDesde and @FHasta) and (NUEVA_COMISION.idSucursal=@id_Sucursal)

END




GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[sp_Empleado_Obtener_Estado_Cuenta]'
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_Empleado_Obtener_Estado_Cuenta]
	@id_Empleado as int,
	@id_Sucursal as int,
	@FDesde as date,
	@FHasta as date,
    
	@DiasFeriados AS int OUTPUT,
	@DiasNormales AS int OUTPUT,
	@DiasTarde AS int OUTPUT,
	@DiasAusente AS int OUTPUT,
	@Adicionales AS float OUTPUT,
	@Vacaciones AS float OUTPUT,
	@Aguinaldo AS float OUTPUT,
	@RecivoSueldo AS float OUTPUT,
	@Comisiones AS float OUTPUT,
	@Adelantos AS float OUTPUT,
	@SueldoPagado AS float OUTPUT,
	@Deuda AS float OUTPUT
 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	--OBTIENE LA CANTIDAD DE DIAS FERIADOS TRABAJADOS
	select @DiasFeriados = COUNT(EMPLEADOS_REGISTROS.id_Registro)
	from EMPLEADOS_REGISTROS INNER JOIN [REL_REGISTRO_EMPLEADOS] ON REL_REGISTRO_EMPLEADOS.id_Registro =EMPLEADOS_REGISTROS.id_Registro 
	where (EMPLEADOS_REGISTROS.Borrado = 0) and (REL_REGISTRO_EMPLEADOS.id_Empleado=@id_Empleado) and (CAST(EMPLEADOS_REGISTROS.Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
	and (EMPLEADOS_REGISTROS.Fecha in (select FechaCorta from FERIADOS) or DATEPART(DW, EMPLEADOS_REGISTROS.Fecha) = 1 or DATEPART(DW, EMPLEADOS_REGISTROS.Fecha) = 7)

	--OBTIENE LA CANTIDAD DE DIAS NORMALES TRABAJADOS
	select @DiasNormales = COUNT(EMPLEADOS_REGISTROS.id_Registro)
	from EMPLEADOS_REGISTROS INNER JOIN [REL_REGISTRO_EMPLEADOS] ON REL_REGISTRO_EMPLEADOS.id_Registro =EMPLEADOS_REGISTROS.id_Registro 
	where (EMPLEADOS_REGISTROS.Borrado = 0) and (REL_REGISTRO_EMPLEADOS.id_Empleado=@id_Empleado) and (EMPLEADOS_REGISTROS.Fecha between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
	and EMPLEADOS_REGISTROS.Fecha not in (select FechaCorta from FERIADOS) and DATEPART(DW, EMPLEADOS_REGISTROS.Fecha) != 1 and DATEPART(DW, EMPLEADOS_REGISTROS.Fecha) != 7

	--OBTIENE LA CANTIDAD DE DIAS TARDE
	select @DiasTarde = COUNT(REL_REGISTRO_EMPLEADOS_TARDE.id_Registro)
	from EMPLEADOS_REGISTROS INNER JOIN REL_REGISTRO_EMPLEADOS_TARDE ON REL_REGISTRO_EMPLEADOS_TARDE.id_Registro =EMPLEADOS_REGISTROS.id_Registro 
	where (EMPLEADOS_REGISTROS.Borrado = 0) and (REL_REGISTRO_EMPLEADOS_TARDE.id_Empleado=@id_Empleado) and (EMPLEADOS_REGISTROS.Fecha between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
	and EMPLEADOS_REGISTROS.Fecha not in (select FechaCorta from FERIADOS)

	--OBTIENE LA CANTIDAD DE DIAS AUSENTES
	select @DiasAusente = COUNT(REL_REGISTRO_EMPLEADOS_AUSENTES.id_Registro)
	from EMPLEADOS_REGISTROS INNER JOIN REL_REGISTRO_EMPLEADOS_AUSENTES ON REL_REGISTRO_EMPLEADOS_AUSENTES.id_Registro =EMPLEADOS_REGISTROS.id_Registro 
	where (EMPLEADOS_REGISTROS.Borrado = 0) and (REL_REGISTRO_EMPLEADOS_AUSENTES.id_Empleado=@id_Empleado) and (EMPLEADOS_REGISTROS.Fecha between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
	and EMPLEADOS_REGISTROS.Fecha not in (select FechaCorta from FERIADOS)

	--OBTENER ADICIONALES
	select @Adicionales = SUM(ADICIONALES.Monto)
	from ADICIONALES 
	where (ADICIONALES.id_Empleado=@id_Empleado) and (CAST(ADICIONALES.Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
	
	if @Adicionales is null
		set @Adicionales = 0

	--OBTIENE VACACIONES
	select @Vacaciones = SUM(vacaciones),@Aguinaldo = SUM(aguinaldo), @RecivoSueldo = SUM(monto)
	from EMPLEADOS_RECIBOS  
	where (id_Empleado=@id_Empleado) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)

	if @Vacaciones is null
		set @Vacaciones = 0

	if @Aguinaldo is null
		set @Aguinaldo = 0

	if @RecivoSueldo is null
		set @RecivoSueldo = 0

	--OBTIENE COMISIONES
	select @Comisiones = SUM(NUEVA_COMISION.Monto)
	from NUEVA_COMISION 
	where (NUEVA_COMISION.Borrado=0) and (NUEVA_COMISION.idEmpleado=@id_Empleado) and (CAST(NUEVA_COMISION.Fecha AS DATE) between @FDesde and @FHasta) and (IdSucursal=@id_Sucursal)

	if @Comisiones is null
		set @Comisiones = 0

	--OBTIENE ADELANTOS
	select @Adelantos = SUM(ADELANTOS.Monto)
	from ADELANTOS 
	where (Borrado = 0) and (ADELANTOS.id_Empleado=@id_Empleado) and (CAST(ADELANTOS.Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)

	if @Adelantos is null
		set @Adelantos = 0

	--OBTIENE SUELDOS PAGADOS
	SELECT @SueldoPagado = SUM(Monto)
	FROM dbo.EMPLEADOS_DEPOSITOS 
	WHERE (id_Empleado=@id_Empleado) and (id_Sucursal=@id_Sucursal) and (CAST(Fecha AS DATE) between @FDesde and @FHasta)

	if @SueldoPagado is null
		set @SueldoPagado = 0

	--OBTENER DEUDA
	SELECT @Deuda = Monto from dbo.DEUDA where id_Empleado = @id_Empleado and id_Sucursal = @id_Sucursal and datepart(month,@FDesde) = Mes and datepart(year,@FDesde) = Anio
END





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
