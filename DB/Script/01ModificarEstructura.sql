/*
Run this script on:

        sql5090.site4now.net.DB_9B1463_cinderellaProd    -  This database will be modified

to synchronize it with:

        (local)\SQLEXPRESS.Cinderella

You are recommended to back up your database before running this script

Script created by SQL Compare version 14.2.9.15508 from Red Gate Software Ltd at 1/4/2024 10:40:13 PM

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
PRINT N'Dropping foreign keys from [dbo].[REL_PRODUCTOS_COLORES]'
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_REL_PRODUCTOS_COLORES_COLORES]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[REL_PRODUCTOS_COLORES]', 'U'))
ALTER TABLE [dbo].[REL_PRODUCTOS_COLORES] DROP CONSTRAINT [FK_REL_PRODUCTOS_COLORES_COLORES]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping constraints from [dbo].[COLORES]'
GO
IF EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_COLORES]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[COLORES]', 'U'))
ALTER TABLE [dbo].[COLORES] DROP CONSTRAINT [PK_COLORES]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[PRODUCTOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'UCBM') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[UCBM] [int] NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'DoG') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[DoG] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'FOBUSD') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[FOBUSD] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'FOBRMB') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[FOBRMB] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'Packing') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[Packing] [int] NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'InPacking') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[InPacking] [int] NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'UGW') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[UGW] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'UNW') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[UNW] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'BoxSize_X') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[BoxSize_X] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'BoxSize_Y') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[BoxSize_Y] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'BoxSize_Z') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[BoxSize_Z] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'ProductSize_X') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[ProductSize_X] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'ProductSize_Y') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[ProductSize_Y] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'ProductSize_Z') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[ProductSize_Z] [decimal] (18, 2) NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'NCM') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[NCM] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'Modelo') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[Modelo] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'SupplierProductCode') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[SupplierProductCode] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'id_Supplier') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[id_Supplier] [int] NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'id_Color') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[id_Color] [int] NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'id_ProductType') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[id_ProductType] [int] NULL
IF COL_LENGTH(N'[dbo].[PRODUCTOS]', N'QtyOfLights') IS NULL
ALTER TABLE [dbo].[PRODUCTOS] ADD[QtyOfLights] [int] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[COLORES]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF COL_LENGTH(N'[dbo].[COLORES]', N'Borrado') IS NULL
ALTER TABLE [dbo].[COLORES] ADD[Borrado] [bit] NOT NULL CONSTRAINT [DF_COLORES_Borrado] DEFAULT ((0))
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF (COL_LENGTH(N'[dbo].[COLORES]', N'id_Color') IS NOT NULL) AND (COL_LENGTH(N'[dbo].[COLORES]', N'Id') IS NULL)
EXEC sp_rename N'[dbo].[COLORES].[id_Color]', N'Id', N'COLUMN'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
IF (COL_LENGTH(N'[dbo].[COLORES]', N'Descripcion') IS NOT NULL) AND (COL_LENGTH(N'[dbo].[COLORES]', N'Nombre') IS NULL)
EXEC sp_rename N'[dbo].[COLORES].[Descripcion]', N'Nombre', N'COLUMN'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[COLORES] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_COLORES] on [dbo].[COLORES]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_COLORES]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[COLORES]', 'U'))
ALTER TABLE [dbo].[COLORES] ADD CONSTRAINT [PK_COLORES] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[sp_Colores_Listado]'
GO
IF OBJECT_ID(N'[dbo].[sp_Colores_Listado]', 'P') IS NOT NULL
EXEC sp_executesql N'ALTER PROCEDURE [dbo].[sp_Colores_Listado] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  id,Nombre from COLORES where Habilitado=1 and Borrado!=1  order by Nombre ASC
END;'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_SUPPLIER]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_SUPPLIER]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_SUPPLIER]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[Nombre] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[POL] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[DeliveryTime] [int] NOT NULL CONSTRAINT [DF_NUEVA_SUPPIER_DeliveryTime] DEFAULT ((0)),
[Habilitado] [bit] NOT NULL,
[Borrado] [bit] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_SUPPIER] on [dbo].[NUEVA_SUPPLIER]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_NUEVA_SUPPIER]', 'PK') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_SUPPLIER]', 'U'))
ALTER TABLE [dbo].[NUEVA_SUPPLIER] ADD CONSTRAINT [PK_NUEVA_SUPPIER] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[sp_Suppliers_Listado]'
GO
IF OBJECT_ID(N'[dbo].[sp_Suppliers_Listado]', 'P') IS NULL
EXEC sp_executesql N'CREATE PROCEDURE [dbo].[sp_Suppliers_Listado] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  id,Nombre from NUEVA_SUPPLIER where Habilitado=1 and Borrado!=1  order by Nombre ASC
END;'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[TIPO_PRODUCTO]'
GO
IF OBJECT_ID(N'[dbo].[TIPO_PRODUCTO]', 'U') IS NULL
CREATE TABLE [dbo].[TIPO_PRODUCTO]
(
[Id] [int] NOT NULL,
[Nombre] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Habilitado] [bit] NOT NULL,
[Borrado] [bit] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[sp_TiposProductos_Listado]'
GO
IF OBJECT_ID(N'[dbo].[sp_TiposProductos_Listado]', 'P') IS NULL
EXEC sp_executesql N'CREATE PROCEDURE [dbo].[sp_TiposProductos_Listado] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  id,Nombre from TIPO_PRODUCTO where Habilitado=1 and Borrado!=1  order by Nombre ASC
END'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[sp_Productos_ListadoExcel]'
GO
IF OBJECT_ID(N'[dbo].[sp_Productos_ListadoExcel]', 'P') IS NOT NULL
EXEC sp_executesql N'ALTER PROCEDURE [dbo].[sp_Productos_ListadoExcel] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	CREATE TABLE #PRODUCTOS
	 (
		id_producto int,
		Codigo varchar(255),
		Nombre varchar(255),
		Categoria varchar(255),
		SubCategoria varchar(255),
		Proveedor varchar(255),
		Origen varchar(255),
		Tamaño varchar(255),
		Costo float,
		CodigoBarra varchar(13),
		Efectivo_Tigre float,
		Desc_Tigre float,
		Efectivo_Capital float,
		Desc_Capital float,
		Mayorista float,
		Alternativa float,
		Descripcion text,
		Habilitado varchar(2)
	 )
	 
	 INSERT INTO #productos
	 
	 SELECT 
		[PRODUCTOS].id_producto,
		[PRODUCTOS].[Codigo],
		[PRODUCTOS].[Nombre],
		[PRODUCTOS_CATEGORIAS].Descripcion as Categoria,
		[PRODUCTOS_SUBCATEGORIAS].Descripcion as SubCategoria,
		[PROVEEDORES].[RazonSocial] as Proveedor,
		[PRODUCTOS].Origen,
		[PRODUCTOS].Tamano as Tamaño,
		[PRODUCTOS].Costo,
		[PRODUCTOS].[CodigoBarra],
		0,
		0,
		0,
		0,
		0,
		0,
		[PRODUCTOS].[Descripcion],
		case when(PRODUCTOS.Habilitado=0) then ''No'' else ''Si'' end AS Habilitado
	FROM [PRODUCTOS] 
		INNER JOIN [PRODUCTOS_CATEGORIAS] ON  [PRODUCTOS_CATEGORIAS].[id_Categoria] = [PRODUCTOS].[id_Categoria] 
		INNER JOIN [PRODUCTOS_SUBCATEGORIAS] ON [PRODUCTOS_SUBCATEGORIAS].[id_Subcategoria] = [PRODUCTOS].[id_Subcategoria]
		INNER JOIN [PROVEEDORES] ON [PROVEEDORES].[id_Proveedor] = [PRODUCTOS].[id_Proveedor]

	UPDATE PROD
	SET
		PROD.Efectivo_Tigre = PRE.Precio
	FROM
		#PRODUCTOS AS PROD INNER JOIN PRECIOS AS PRE ON PRE.id_Producto = PROD.id_Producto
	WHERE
		PRE.id_Lista = 1


	UPDATE PROD
	SET
		PROD.Desc_Tigre = PRE.Precio
	FROM
		#PRODUCTOS AS PROD INNER JOIN PRECIOS AS PRE ON PRE.id_Producto = PROD.id_Producto
	WHERE
		PRE.id_Lista = 2

	UPDATE PROD
	SET
		PROD.Efectivo_Capital = PRE.Precio
	FROM
		#PRODUCTOS AS PROD INNER JOIN PRECIOS AS PRE ON PRE.id_Producto = PROD.id_Producto
	WHERE
		PRE.id_Lista = 3

	UPDATE PROD
	SET
		PROD.Desc_Capital = PRE.Precio
	FROM
		#PRODUCTOS AS PROD INNER JOIN PRECIOS AS PRE ON PRE.id_Producto = PROD.id_Producto
	WHERE
		PRE.id_Lista = 4

	UPDATE PROD
	SET
		PROD.Mayorista = PRE.Precio
	FROM
		#PRODUCTOS AS PROD INNER JOIN PRECIOS AS PRE ON PRE.id_Producto = PROD.id_Producto
	WHERE
		PRE.id_Lista = 5

	UPDATE PROD
	SET
		PROD.Alternativa = PRE.Precio
	FROM
		#PRODUCTOS AS PROD INNER JOIN PRECIOS AS PRE ON PRE.id_Producto = PROD.id_Producto
	WHERE
		PRE.id_Lista = 6

	SELECT * from #productos ORDER BY Codigo, Nombre

	DROP TABLE #productos


END




'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[REL_PRODUCTOS_COLORES]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_REL_PRODUCTOS_COLORES_COLORES]','F') AND parent_object_id = OBJECT_ID(N'[dbo].[REL_PRODUCTOS_COLORES]', 'U'))
ALTER TABLE [dbo].[REL_PRODUCTOS_COLORES] WITH NOCHECK  ADD CONSTRAINT [FK_REL_PRODUCTOS_COLORES_COLORES] FOREIGN KEY ([id_Color]) REFERENCES [dbo].[COLORES] ([Id])
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
