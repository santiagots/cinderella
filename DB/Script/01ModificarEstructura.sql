/*
Run this script on:

        (local)\SQLEXPRESS.C:\USERS\JAQUELINA\APPDATA\LOCAL\SISTEMACINDERELLADESARROLLO\CINDERELLA_LOCAL.MDF    -  This database will be modified

to synchronize it with:

        (local)\SQLEXPRESS.Cinderella

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 12/19/2025 6:07:35 PM

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
PRINT N'Dropping foreign keys from [dbo].[NUEVA_PERCEPCION_FACTURA]'
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_PERCEPCION_FACTURA_NUEVA_FACTURA]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_FACTURA]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION_FACTURA] DROP CONSTRAINT [FK_NUEVA_PERCEPCION_FACTURA_NUEVA_FACTURA]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping foreign keys from [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]'
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_PERCEPCION_NOTA_CREDITO_NOTA_CREDITO]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO] DROP CONSTRAINT [FK_NUEVA_PERCEPCION_NOTA_CREDITO_NOTA_CREDITO]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping constraints from [dbo].[NUEVA_PERCEPCION]'
GO
IF EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_PERCEPCION]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION] DROP CONSTRAINT [PK_NUEVA_PERCEPCION]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping constraints from [dbo].[NUEVA_PERCEPCION_FACTURA]'
GO
IF EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_IMPUESTO_FACTURA]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_FACTURA]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION_FACTURA] DROP CONSTRAINT [PK_NUEVA_IMPUESTO_FACTURA]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping constraints from [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]'
GO
IF EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_PERCEPCION_NOTA_CREDITO]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO] DROP CONSTRAINT [PK_NUEVA_PERCEPCION_NOTA_CREDITO]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Rebuilding [dbo].[NUEVA_PERCEPCION_FACTURA]'
GO
CREATE TABLE [dbo].[RG_Recovery_1_NUEVA_PERCEPCION_FACTURA]
(
[Id] [bigint] NOT NULL,
[IdFactura] [bigint] NOT NULL,
[Tipo] [int] NOT NULL,
[Comcepto] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Alicuota] [decimal] (18, 2) NOT NULL,
[Monto] [decimal] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
INSERT INTO [dbo].[RG_Recovery_1_NUEVA_PERCEPCION_FACTURA]([Id], [IdFactura], [Tipo], [Comcepto], [Alicuota]) SELECT [Id], [IdFactura], [Tipo], [Comcepto], [Alicuota] FROM [dbo].[NUEVA_PERCEPCION_FACTURA]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
DROP TABLE [dbo].[NUEVA_PERCEPCION_FACTURA]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF (OBJECT_ID(N'[dbo].[RG_Recovery_1_NUEVA_PERCEPCION_FACTURA]', 'U') IS NOT NULL) AND (OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_FACTURA]', 'U') IS NULL)
EXEC sp_rename N'[dbo].[RG_Recovery_1_NUEVA_PERCEPCION_FACTURA]', N'NUEVA_PERCEPCION_FACTURA', N'OBJECT'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_IMPUESTO_FACTURA] on [dbo].[NUEVA_PERCEPCION_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_IMPUESTO_FACTURA]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_FACTURA]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION_FACTURA] ADD CONSTRAINT [PK_NUEVA_IMPUESTO_FACTURA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Rebuilding [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]'
GO
CREATE TABLE [dbo].[RG_Recovery_2_NUEVA_PERCEPCION_NOTA_CREDITO]
(
[Id] [bigint] NOT NULL,
[IdNotaCredito] [bigint] NOT NULL,
[Tipo] [int] NOT NULL,
[Comcepto] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Alicuota] [decimal] (18, 2) NOT NULL,
[Monto] [decimal] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
INSERT INTO [dbo].[RG_Recovery_2_NUEVA_PERCEPCION_NOTA_CREDITO]([Id], [IdNotaCredito], [Tipo], [Comcepto], [Alicuota], [Monto]) SELECT [Id], [IdNotaCredito], [Tipo], [Comcepto], [Alicuota], [Monto] FROM [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
DROP TABLE [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF (OBJECT_ID(N'[dbo].[RG_Recovery_2_NUEVA_PERCEPCION_NOTA_CREDITO]', 'U') IS NOT NULL) AND (OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]', 'U') IS NULL)
EXEC sp_rename N'[dbo].[RG_Recovery_2_NUEVA_PERCEPCION_NOTA_CREDITO]', N'NUEVA_PERCEPCION_NOTA_CREDITO', N'OBJECT'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_PERCEPCION_NOTA_CREDITO] on [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_PERCEPCION_NOTA_CREDITO]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO] ADD CONSTRAINT [PK_NUEVA_PERCEPCION_NOTA_CREDITO] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[NUEVA_PRESUPUESTO]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[NUEVA_PRESUPUESTO]', N'CondicionPago') IS NULL
ALTER TABLE [dbo].[NUEVA_PRESUPUESTO] ADD[CondicionPago] [int] NOT NULL CONSTRAINT [DF_NUEVA_PRESUPUESTO_CondicionPago] DEFAULT ((1))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[sp_Empleados_Encargados_ListadoSucursal_Asistencia]'
GO
IF OBJECT_ID(N'[dbo].[sp_Empleados_Encargados_ListadoSucursal_Asistencia]', 'P') IS NOT NULL
EXEC sp_executesql N'ALTER PROCEDURE [dbo].[sp_Empleados_Encargados_ListadoSucursal_Asistencia] 
@id_Sucursal as int,
@fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select distinct emp.id_Empleado,emp.Apellido + '', '' + emp.Nombre as NombreCompleto
	from REL_REGISTRO_EMPLEADOS rel 
				inner join EMPLEADOS_REGISTROS reg on rel.id_Registro = reg.id_Registro
				inner join EMPLEADOS emp on rel.id_Empleado = emp.id_Empleado
	where 
		reg.Borrado = 0 and
		emp.Borrado=0 and
		reg.Fecha = @fecha and
		(emp.id_TipoEmpleado=2 or emp.id_TipoEmpleado=3) and
		reg.id_Sucursal = @id_Sucursal
END
'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Rebuilding [dbo].[NUEVA_PERCEPCION]'
GO
CREATE TABLE [dbo].[RG_Recovery_3_NUEVA_PERCEPCION]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[TipoCliente] [int] NOT NULL,
[CondicionIVA] [int] NOT NULL,
[TipoPercepcion] [int] NOT NULL,
[IdProvincia] [int] NULL,
[Comcepto] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MontoDesde] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_NUEVA_PERCEPCION_MontoDesde] DEFAULT ((0)),
[Alicuota] [decimal] (18, 2) NOT NULL,
[Habilitado] [bit] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
SET IDENTITY_INSERT [dbo].[RG_Recovery_3_NUEVA_PERCEPCION] ON
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
INSERT INTO [dbo].[RG_Recovery_3_NUEVA_PERCEPCION]([Id], [TipoCliente], [TipoPercepcion], [IdProvincia], [Comcepto], [Alicuota], [Habilitado]) SELECT [Id], [TipoCliente], [TipoPercepcion], [IdProvincia], [Comcepto], [Alicuota], [Habilitado] FROM [dbo].[NUEVA_PERCEPCION]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
SET IDENTITY_INSERT [dbo].[RG_Recovery_3_NUEVA_PERCEPCION] OFF
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
DECLARE @idVal BIGINT
SELECT @idVal = IDENT_CURRENT(N'[dbo].[NUEVA_PERCEPCION]')
IF @idVal IS NOT NULL
    DBCC CHECKIDENT(N'[dbo].[RG_Recovery_3_NUEVA_PERCEPCION]', RESEED, @idVal)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
DROP TABLE [dbo].[NUEVA_PERCEPCION]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF (OBJECT_ID(N'[dbo].[RG_Recovery_3_NUEVA_PERCEPCION]', 'U') IS NOT NULL) AND (OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION]', 'U') IS NULL)
EXEC sp_rename N'[dbo].[RG_Recovery_3_NUEVA_PERCEPCION]', N'NUEVA_PERCEPCION', N'OBJECT'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_PERCEPCION] on [dbo].[NUEVA_PERCEPCION]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_PERCEPCION]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION] ADD CONSTRAINT [PK_NUEVA_PERCEPCION] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_PERCEPCION_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_PERCEPCION_FACTURA_NUEVA_FACTURA]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_FACTURA]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION_FACTURA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_PERCEPCION_FACTURA_NUEVA_FACTURA] FOREIGN KEY ([IdFactura]) REFERENCES [dbo].[NUEVA_FACTURA] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_PERCEPCION_NOTA_CREDITO_NOTA_CREDITO]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_PERCEPCION_NOTA_CREDITO]', 'U'))
ALTER TABLE [dbo].[NUEVA_PERCEPCION_NOTA_CREDITO] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_PERCEPCION_NOTA_CREDITO_NOTA_CREDITO] FOREIGN KEY ([IdNotaCredito]) REFERENCES [dbo].[NUEVA_NOTA_CREDITO] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Enabling constraints on [dbo].[NUEVA_PRESUPUESTO]'
GO
ALTER TABLE [dbo].[NUEVA_PRESUPUESTO] CHECK CONSTRAINT [FK_NUEVA_PRESUPUESTO_CLIENTEMAYORISTA]
GO
ALTER TABLE [dbo].[NUEVA_PRESUPUESTO] CHECK CONSTRAINT [FK_NUEVA_PRESUPUESTO_CLIENTEMINORISTA]
GO
ALTER TABLE [dbo].[NUEVA_PRESUPUESTO] CHECK CONSTRAINT [FK_NUEVA_PRESUPUESTO_SUCURSALES]
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
