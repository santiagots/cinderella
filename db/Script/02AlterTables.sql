/*
Run this script on:

        sql5040.site4now.net.DB_9B1463_cinderellaPiloto    -  This database will be modified

to synchronize it with:

        AR5CG4371FY6.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Compare version 11.6.11 from Red Gate Software Ltd at 11/04/2019 11:35:33 p.m.

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
PRINT N'Dropping foreign keys from [dbo].[REL_PRODUCTOS_AROMAS]'
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_REL_PRODUCTOS_AROMAS_PRODUCTOS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[REL_PRODUCTOS_AROMAS]', 'U'))
ALTER TABLE [dbo].[REL_PRODUCTOS_AROMAS] DROP CONSTRAINT [FK_REL_PRODUCTOS_AROMAS_PRODUCTOS]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping foreign keys from [dbo].[REL_PRODUCTOS_COLORES]'
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_REL_PRODUCTOS_COLORES_PRODUCTOS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[REL_PRODUCTOS_COLORES]', 'U'))
ALTER TABLE [dbo].[REL_PRODUCTOS_COLORES] DROP CONSTRAINT [FK_REL_PRODUCTOS_COLORES_PRODUCTOS]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping foreign keys from [dbo].[REL_PRODUCTOS_MATERIALES]'
GO
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_REL_PRODUCTOS_MATERIALES_PRODUCTOS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[REL_PRODUCTOS_MATERIALES]', 'U'))
ALTER TABLE [dbo].[REL_PRODUCTOS_MATERIALES] DROP CONSTRAINT [FK_REL_PRODUCTOS_MATERIALES_PRODUCTOS]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Dropping constraints from [dbo].[STOCK]'
GO
IF EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Modificado' AND object_id = OBJECT_ID(N'[dbo].[STOCK]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_STOCK_Modificado]', 'D'))
ALTER TABLE [dbo].[STOCK] DROP CONSTRAINT [DF_STOCK_Modificado]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[EMPLEADOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[EMPLEADOS] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[PROVINCIAS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[PROVINCIAS] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[BANCOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[BANCOS] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[PRECIOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[PRECIOS] ALTER COLUMN [Precio] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[PRECIOS] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Refreshing [dbo].[VW_PRECIOS]'
GO
IF OBJECT_ID(N'[dbo].[VW_PRECIOS]', 'V') IS NOT NULL
EXEC sp_refreshview N'[dbo].[VW_PRECIOS]'
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
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Vendedor] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Encargado] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Vendedor_Feriado] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Encargado_Feriado] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Vendedor_Mayor] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[SUCURSALES] ALTER COLUMN [Comision_Encargado_Mayor] [numeric] (18, 2) NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[STOCK]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
UPDATE [dbo].[STOCK] SET [Modificado]=((0)) WHERE [Modificado] IS NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[STOCK] ALTER COLUMN [Habilitado] [bit] NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[STOCK] ALTER COLUMN [Modificado] [bit] NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[CLIENTEMINORISTA]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[CLIENTEMINORISTA] ALTER COLUMN [Telefono] [nvarchar] (125) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
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
PRINT N'Altering [dbo].[DEPARTAMENTOS]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[DEPARTAMENTOS] ALTER COLUMN [Habilitado] [bit] NULL
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
	ORDER BY
		[PRODUCTOS].[Codigo],
		[PRODUCTOS].[Nombre]


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

	SELECT * from #productos

	DROP TABLE #productos


END




'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Altering [dbo].[LOCALIDADES]'
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
ALTER TABLE [dbo].[LOCALIDADES] ALTER COLUMN [Habilitado] [bit] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_VENTAS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_VENTAS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_VENTAS]
(
[Id] [bigint] NOT NULL,
[TipoCliente] [int] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdEncargado] [int] NOT NULL,
[IdVendedor] [int] NOT NULL,
[IdClienteMayorista] [int] NULL,
[IdClienteMinorista] [int] NULL,
[PorcentajeFacturacion] [decimal] (18, 2) NULL,
[Numero] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Fecha] [datetime] NOT NULL,
[FechaEdicion] [datetime] NULL,
[CompraCantidadTotalProductos] [int] NOT NULL,
[CompraMontoTotal] [decimal] (18, 2) NOT NULL,
[CompraIvaTotal] [decimal] (18, 2) NOT NULL,
[PagoMontoTotal] [decimal] (18, 2) NOT NULL,
[PagoDescuentoTotal] [decimal] (18, 2) NOT NULL,
[PagoCFTTotal] [decimal] (18, 2) NOT NULL,
[PagoIVATotal] [decimal] (18, 2) NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_VENTAS] on [dbo].[NUEVA_VENTAS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_VENTAS' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTAS]'))
ALTER TABLE [dbo].[NUEVA_VENTAS] ADD CONSTRAINT [PK_NUEVA_VENTAS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_COMISION]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_COMISION]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_COMISION]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[IdEmpleado] [int] NOT NULL,
[IdSucursal] [int] NOT NULL,
[PorcentajeComision] [numeric] (18, 2) NOT NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Fecha] [datetime] NOT NULL,
[Borrado] [bit] NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_COMISION] on [dbo].[NUEVA_COMISION]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_COMISION' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_COMISION]'))
ALTER TABLE [dbo].[NUEVA_COMISION] ADD CONSTRAINT [PK_NUEVA_COMISION] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_FACTURA]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_FACTURA]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_FACTURA]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[TipoFactura] [int] NOT NULL,
[CondicionIVA] [int] NOT NULL,
[NombreYApellido] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Direccion] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Localidad] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[CUIT] [nchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_FACTURA] on [dbo].[NUEVA_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_FACTURA' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_FACTURA]'))
ALTER TABLE [dbo].[NUEVA_FACTURA] ADD CONSTRAINT [PK_NUEVA_FACTURA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_NOTA_PEDIDO]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_NOTA_PEDIDO]
(
[Id] [bigint] NOT NULL,
[TipoCliente] [int] NOT NULL,
[IdSucursal] [int] NOT NULL,
[IdEncargado] [int] NOT NULL,
[IdVendedor] [int] NOT NULL,
[IdClienteMayorista] [int] NULL,
[IdClienteMinorista] [int] NULL,
[PorcentajeFacturacion] [decimal] (18, 2) NOT NULL,
[Fecha] [datetime] NOT NULL,
[FechaEdicion] [datetime] NOT NULL,
[Numero] [int] NOT NULL,
[Borrado] [bit] NOT NULL,
[Estado] [int] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_NOTA_PEDIDO] on [dbo].[NUEVA_NOTA_PEDIDO]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_NOTA_PEDIDO' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO]'))
ALTER TABLE [dbo].[NUEVA_NOTA_PEDIDO] ADD CONSTRAINT [PK_NUEVA_NOTA_PEDIDO] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_NOTA_PEDIDO_ITEMS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO_ITEMS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_NOTA_PEDIDO_ITEMS]
(
[Id] [bigint] NOT NULL,
[IdNotaPedido] [bigint] NOT NULL,
[CodigoProducto] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[NombreProducto] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Monto] [decimal] (18, 2) NOT NULL,
[Iva] [decimal] (18, 2) NOT NULL,
[Cantidad] [int] NOT NULL,
[PorcentajeBonificacion] [decimal] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_NOTA_PEDIDO_ITEMS] on [dbo].[NUEVA_NOTA_PEDIDO_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_NOTA_PEDIDO_ITEMS' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO_ITEMS]'))
ALTER TABLE [dbo].[NUEVA_NOTA_PEDIDO_ITEMS] ADD CONSTRAINT [PK_NUEVA_NOTA_PEDIDO_ITEMS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_NUMERO_FACTURA]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_NUMERO_FACTURA]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_NUMERO_FACTURA]
(
[Id] [bigint] NOT NULL,
[IdFactura] [bigint] NOT NULL,
[Numero] [int] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_NUMERO_FACTURA] on [dbo].[NUEVA_NUMERO_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_NUMERO_FACTURA' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_NUMERO_FACTURA]'))
ALTER TABLE [dbo].[NUEVA_NUMERO_FACTURA] ADD CONSTRAINT [PK_NUEVA_NUMERO_FACTURA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_RESERVA]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_RESERVA]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_RESERVA]
(
[Id] [bigint] NOT NULL,
[IdVentaReserva] [bigint] NOT NULL,
[IdVentaEntrega] [bigint] NULL,
[Nombre] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Apellido] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Telefono] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Direccion] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[MetodoEntrega] [int] NOT NULL,
[Observaciones] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Entregada] [bit] NOT NULL,
[FechaAlta] [datetime] NOT NULL,
[FechaEstimadaRetiro] [datetime] NULL,
[FechaEntrega] [datetime] NULL,
[MontoTotal] [decimal] (18, 2) NOT NULL,
[MontoReserva] [decimal] (18, 2) NOT NULL,
[Borrado] [bit] NOT NULL,
[FechaEdicion] [datetime] NULL
)
GO
ALTER TABLE [dbo].[NUEVA_RESERVA] ALTER COLUMN [Direccion] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_RESERVA] on [dbo].[NUEVA_RESERVA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_RESERVA' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_RESERVA]'))
ALTER TABLE [dbo].[NUEVA_RESERVA] ADD CONSTRAINT [PK_NUEVA_RESERVA] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_VENTA_ITEMS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_VENTA_ITEMS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_VENTA_ITEMS]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[CodigoProducto] [varchar] (25) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[NombreProducto] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Iva] [numeric] (18, 2) NOT NULL,
[Cantidad] [int] NOT NULL,
[PorcentajeBonificacion] [numeric] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_VENTA_ITEMS] on [dbo].[NUEVA_VENTA_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_VENTA_ITEMS' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_ITEMS]'))
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] ADD CONSTRAINT [PK_NUEVA_VENTA_ITEMS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]', 'U') IS NULL
CREATE TABLE [dbo].[NUEVA_VENTA_PAGOS]
(
[Id] [bigint] NOT NULL,
[IdVenta] [bigint] NOT NULL,
[Tarjeta] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[NumeroCuotas] [int] NULL,
[TipoPago] [int] NOT NULL,
[PorcentajeRecargo] [numeric] (18, 2) NULL,
[Monto] [numeric] (18, 2) NOT NULL,
[Descuento] [numeric] (18, 2) NOT NULL,
[CFT] [numeric] (18, 2) NOT NULL,
[IVA] [numeric] (18, 2) NOT NULL,
[FechaEdicion] [datetime] NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating primary key [PK_NUEVA_VENTA_PAGOS] on [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'PK_NUEVA_VENTA_PAGOS' AND object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]'))
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] ADD CONSTRAINT [PK_NUEVA_VENTA_PAGOS] PRIMARY KEY CLUSTERED  ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating [dbo].[PAGO]'
GO
IF OBJECT_ID(N'[dbo].[PAGO]', 'U') IS NULL
CREATE TABLE [dbo].[PAGO]
(
[id_Pago] [bigint] NOT NULL,
[id_Venta] [bigint] NOT NULL,
[id_FormaPago] [int] NOT NULL,
[id_Banco] [int] NULL,
[id_Cuotas] [int] NULL,
[id_Cheque] [bigint] NULL,
[Monto] [float] NOT NULL,
[Descuento] [float] NOT NULL,
[CostoFinanciero] [float] NOT NULL,
[IVA] [float] NOT NULL,
[Total] [float] NOT NULL,
[Fecha_Edicion] [datetime] NOT NULL
)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [IdProducto] on [dbo].[VENTAS_DETALLE]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IdProducto' AND object_id = OBJECT_ID(N'[dbo].[VENTAS_DETALLE]'))
CREATE NONCLUSTERED INDEX [IdProducto] ON [dbo].[VENTAS_DETALLE] ([id_Producto])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [IdVenta] on [dbo].[VENTAS_DETALLE]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IdVenta' AND object_id = OBJECT_ID(N'[dbo].[VENTAS_DETALLE]'))
CREATE NONCLUSTERED INDEX [IdVenta] ON [dbo].[VENTAS_DETALLE] ([id_Venta])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding constraints to [dbo].[STOCK]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE name = N'Modificado' AND object_id = OBJECT_ID(N'[dbo].[STOCK]', 'U') AND default_object_id = OBJECT_ID(N'[dbo].[DF_STOCK_Modificado]', 'D'))
ALTER TABLE [dbo].[STOCK] ADD CONSTRAINT [DF_STOCK_Modificado] DEFAULT ((0)) FOR [Modificado]
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_COMISION]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_COMISION_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_COMISION]', 'U'))
ALTER TABLE [dbo].[NUEVA_COMISION] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_COMISION_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_NUMERO_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_NUMERO_FACTURA_NUEVA_FACTURA]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_NUMERO_FACTURA]', 'U'))
ALTER TABLE [dbo].[NUEVA_NUMERO_FACTURA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_NUMERO_FACTURA_NUEVA_FACTURA] FOREIGN KEY ([IdFactura]) REFERENCES [dbo].[NUEVA_FACTURA] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_FACTURA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_FACTURA_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_FACTURA]', 'U'))
ALTER TABLE [dbo].[NUEVA_FACTURA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_FACTURA_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_NOTA_PEDIDO_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_NOTA_PEDIDO_ITEMS_NUEVA_NOTA_PEDIDO]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_NOTA_PEDIDO_ITEMS]', 'U'))
ALTER TABLE [dbo].[NUEVA_NOTA_PEDIDO_ITEMS] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_NOTA_PEDIDO_ITEMS_NUEVA_NOTA_PEDIDO] FOREIGN KEY ([IdNotaPedido]) REFERENCES [dbo].[NUEVA_NOTA_PEDIDO] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_RESERVA]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_RESERVA_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_RESERVA]', 'U'))
ALTER TABLE [dbo].[NUEVA_RESERVA] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_RESERVA_NUEVA_VENTAS] FOREIGN KEY ([IdVentaReserva]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_VENTA_ITEMS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_VENTA_ITEMS_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_ITEMS]', 'U'))
ALTER TABLE [dbo].[NUEVA_VENTA_ITEMS] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_VENTA_ITEMS_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[NUEVA_VENTA_PAGOS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NUEVA_VENTA_PAGOS_NUEVA_VENTAS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[NUEVA_VENTA_PAGOS]', 'U'))
ALTER TABLE [dbo].[NUEVA_VENTA_PAGOS] WITH NOCHECK  ADD CONSTRAINT [FK_NUEVA_VENTA_PAGOS_NUEVA_VENTAS] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[NUEVA_VENTAS] ([Id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[REL_PRODUCTOS_AROMAS]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_REL_PRODUCTOS_AROMAS_PRODUCTOS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[REL_PRODUCTOS_AROMAS]', 'U'))
ALTER TABLE [dbo].[REL_PRODUCTOS_AROMAS] WITH NOCHECK  ADD CONSTRAINT [FK_REL_PRODUCTOS_AROMAS_PRODUCTOS] FOREIGN KEY ([id_Producto]) REFERENCES [dbo].[PRODUCTOS] ([id_Producto])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[REL_PRODUCTOS_COLORES]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_REL_PRODUCTOS_COLORES_PRODUCTOS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[REL_PRODUCTOS_COLORES]', 'U'))
ALTER TABLE [dbo].[REL_PRODUCTOS_COLORES] WITH NOCHECK  ADD CONSTRAINT [FK_REL_PRODUCTOS_COLORES_PRODUCTOS] FOREIGN KEY ([id_Producto]) REFERENCES [dbo].[PRODUCTOS] ([id_Producto])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Adding foreign keys to [dbo].[REL_PRODUCTOS_MATERIALES]'
GO
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_REL_PRODUCTOS_MATERIALES_PRODUCTOS]', 'F') AND parent_object_id = OBJECT_ID(N'[dbo].[REL_PRODUCTOS_MATERIALES]', 'U'))
ALTER TABLE [dbo].[REL_PRODUCTOS_MATERIALES] WITH NOCHECK  ADD CONSTRAINT [FK_REL_PRODUCTOS_MATERIALES_PRODUCTOS] FOREIGN KEY ([id_Producto]) REFERENCES [dbo].[PRODUCTOS] ([id_Producto])
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