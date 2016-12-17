SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

ALTER TABLE [dbo].[VENTAS]
ADD [MontoSenia] [float] Not Null DEFAULT(0)
GO

ALTER TABLE [dbo].[VENTAS]
ADD [Senia] [bit] Not Null DEFAULT(0)
GO

ALTER TABLE [dbo].[VENTAS]
ADD [id_ListaPrecio] [int] Not Null DEFAULT(0)
GO


ALTER PROCEDURE [dbo].[sp_Ventas_Alta]
    @id_Cliente AS INT,
    @id_Empleado AS INT,    
    @id_Encargado AS INT,
    @id_Sucursal AS INT,      
    @id_TipoPago AS INT,      
    @id_TipoVenta AS INT,  
	@id_ListaPrecio AS INT,  	                    
    @CantidadTotal AS INT,    
    @PrecioTotal AS FLOAT,      
    @Subtotal AS FLOAT, 
	@Senia AS FLOAT,
	@MontoSenia AS BIT,
    @Descuento AS FLOAT,
    @Anulado AS SMALLINT,   
    @Habilitado AS SMALLINT,           
    @Facturado AS SMALLINT, 
	@DiferenciaPagoCheque as FLOAT,
	@Detalle dbo.VENTA_DETALLE_TYPE READONLY,
    @msg AS INT OUTPUT
AS
	
BEGIN
Begin Tran t_Alta
    Begin Try

		BEGIN

			declare @cantidadVentas AS varchar(50)
			declare @numero AS varchar(50), @codigoVenta as varchar(50)

			set @cantidadVentas = CONVERT(varchar(10),(Select count(*) from VENTAS where id_Sucursal = @id_Sucursal))
			print @cantidadVentas + '1'
			select @codigoVenta = Codigo_Venta from sucursales where id_sucursal = @id_Sucursal
			print @codigoVenta + 's'

			set @numero = @codigoVenta + CASE @Facturado when 0 then 'N' else 'S' End + rtrim(CONVERT(char(10), GetDate(),112)) + right('000000'+ @cantidadVentas, 6)

			INSERT INTO dbo.VENTAS (id_Cliente,id_Empleado,id_Encargado,id_Sucursal,id_TipoPago,id_TipoVenta,Cantidad_Total,Precio_Total,Subtotal,Descuento,Anulado,Habilitado,Facturado,Fecha,Diferencia_Pago_Cheque,Numero,Senia,MontoSenia,id_ListaPrecio) VALUES (@id_Cliente,
			@id_Empleado,@id_Encargado,@id_Sucursal,@id_TipoPago,@id_TipoVenta,@CantidadTotal,@PrecioTotal,@Subtotal,@Descuento,@Anulado,@Habilitado,@Facturado,GETDATE(),@DiferenciaPagoCheque,@numero,@Senia,@MontoSenia,@id_ListaPrecio)

			DECLARE @id_Venta AS INT 
			SET @id_Venta = (select IDENT_CURRENT('VENTAS'))

			INSERT INTO dbo.VENTAS_DETALLE (id_Venta,id_Producto,Cantidad,Precio) SELECT @id_Venta,id_Producto,Cantidad,Precio  from @Detalle

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
Go

ALTER PROCEDURE [dbo].[sp_Ventas_Detalle] 
@id_Venta as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT VENTAS.id_Sucursal,
		VENTAS.Habilitado,
		VENTAS.Anulado,
		VENTAS.id_Venta,
		CASE WHEN(FACTURACION.TipoRecibo is null) THEN -1 ELSE FACTURACION.TipoRecibo END as TipoFactura, 
		VENTAS.Fecha,
		VENTAS.FechaAnulado,
		VENTAS.DescripcionAnulado,
		VENTAS.Cantidad_Total,
		VENTAS.Precio_Total + VENTAS.Diferencia_Pago_Cheque as Precio_Total,
		VENTAS.Senia,
		VENTAS.MontoSenia,
		VENTAS.Descuento,
		VENTAS.Subtotal,
		CLIENTES.RazonSocial, 
		TIPOS_PAGO.Descripcion as "TiposPago",
		TIPOS_VENTAS.Descripcion as "TiposVenta",
		VENTAS.id_ListaPrecio,
		SUCURSALES.Nombre as "Sucursal",
		EMPLEADOS.Apellido + ' ' + EMPLEADOS.Nombre as "Empleado",
		VENTAS.id_Empleado,
		ENCARGADO.Apellido + ' ' + ENCARGADO.Nombre as "Encargado",
		VENTAS.id_Encargado
	from VENTAS 
	inner join EMPLEADOS on EMPLEADOS.id_Empleado=VENTAS.id_Empleado
	left join EMPLEADOS as ENCARGADO on ENCARGADO.id_Empleado=VENTAS.id_Encargado 
	left join CLIENTES on CLIENTES.id_Cliente=VENTAS.id_Cliente 
	inner join TIPOS_PAGO on TIPOS_PAGO.id_TipoPago = VENTAS.id_TipoPago 
	inner join TIPOS_VENTAS on TIPOS_VENTAS.id_TipoVenta = VENTAS.id_TipoVenta 
	inner join SUCURSALES on SUCURSALES.id_Sucursal = VENTAS.id_Sucursal 
	LEFT JOIN FACTURACION ON VENTAS.id_Venta = FACTURACION.id_Venta
	where VENTAS.id_Venta=@id_Venta
	
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_ListadoCliente]
 @id_Cliente as integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT VENTAS.id_Venta,VENTAS.Precio_Total as MontoTotal,VENTAS.Fecha,SUCURSALES.Nombre as "Sucursal"
	from VENTAS  
	INNER JOIN SUCURSALES ON VENTAS.id_Sucursal = SUCURSALES.id_Sucursal  
	where (VENTAS.id_Cliente=@id_Cliente and VENTAS.Senia=0 )
	order by VENTAS.Fecha DESC
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_ListadoCompleto]
 @id_Sucursal as integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT VENTAS.id_Venta,CLIENTES.RazonSocial as Cliente,EMPLEADOS.Apellido + ', ' + EMPLEADOS.Nombre as Empleado,VENTAS.Precio_Total as MontoTotal,VENTAS.Descuento,VENTAS.Fecha, CASE WHEN(Anulado=1) THEN 'SI' ELSE 'NO' END AS Anulado, CASE WHEN(Facturado=1) THEN 'SI' ELSE 'NO' END AS Facturado 
	from VENTAS  
	INNER JOIN EMPLEADOS ON VENTAS.id_Empleado = EMPLEADOS.id_Empleado 
	LEFT JOIN CLIENTES ON VENTAS.id_Cliente = CLIENTES.id_Cliente  
	INNER JOIN SUCURSALES ON VENTAS.id_Sucursal = SUCURSALES.id_Sucursal  
	where (VENTAS.id_Sucursal=@id_Sucursal) and (VENTAS.Fecha=GETDATE()) AND (VENTAS.Senia = 0)
	order by VENTAS.Fecha DESC
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_ListadoCompletoFecha]
 @id_Sucursal as integer,
 @FDesde as date,
 @FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT VENTAS.id_Venta,
		CLIENTES.RazonSocial as Cliente,
		EMPLEADOS.Apellido + ', ' + EMPLEADOS.Nombre as Empleado,
		CASE
			WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
			WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
		END as MontoTotal,
		VENTAS.Descuento,
		VENTAS.Fecha, 
		CASE WHEN(Anulado=1) THEN 'SI' ELSE 'NO' END AS Anulado, 
		CASE WHEN(FACTURACION.TipoRecibo is null) THEN -1 ELSE FACTURACION.TipoRecibo END as TipoRecibo, 
		FACTURACION.NumeroFactura,
		VENTAS.Numero as NumeroVenta
	from VENTAS  
	INNER JOIN EMPLEADOS ON VENTAS.id_Empleado = EMPLEADOS.id_Empleado 
	LEFT JOIN CLIENTES ON VENTAS.id_Cliente = CLIENTES.id_Cliente  
	INNER JOIN SUCURSALES ON VENTAS.id_Sucursal = SUCURSALES.id_Sucursal  
	LEFT JOIN FACTURACION ON VENTAS.id_Venta = FACTURACION.id_Venta
	where (VENTAS.id_Sucursal=@id_Sucursal) and (CAST(VENTAS.Fecha AS DATE) between @FDesde and @FHasta)
	group by VENTAS.id_Venta, CLIENTES.RazonSocial, EMPLEADOS.Apellido, EMPLEADOS.Nombre, VENTAS.Senia, VENTAS.Descuento, VENTAS.Fecha, Anulado, TipoRecibo, NumeroFactura, Numero
	order by VENTAS.Fecha DESC
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtener] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select sum(Ventas) as Ventas
from (select
CASE
	WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
	WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
END as Ventas
from VENTAS 
where (Habilitado=1) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
group by Senia) Monto

END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtenerCheque] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select sum(VentasCheque) as VentasCheque
from (
select 
CASE
	WHEN Senia=0 THEN sum(ISNULL(VENTAS.Precio_Total,0))  
	WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
END as VentasCheque
from VENTAS 
where (Habilitado=1) and (id_TipoPago=4) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
group by Senia) Monto

END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtenerCredito] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select sum(VentasCredito) as VentasCredito
from (
select 
CASE
	WHEN Senia=0 THEN sum(ISNULL(VENTAS.Precio_Total,0))
	WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
END as VentasCredito
from VENTAS 
where (Habilitado=1) and (id_TipoPago=2) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
group by Senia) Monto

END

GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtenerDebito] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select sum(VentasDebito) as VentasDebito
from (
select
CASE
	WHEN Senia=0 THEN sum(ISNULL(VENTAS.Precio_Total,0))
	WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
END as VentasDebito
from VENTAS 
where (Habilitado=1) and (id_TipoPago=3) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
group by Senia) Monto

END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtenerEfectivo] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select( 
		ISNULL((select sum(Precio_Total)
		from VENTAS 
		where (Senia = 0) and (Habilitado=1) and (id_TipoPago=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)), 0)
			+
		ISNULL((select sum(Diferencia_Pago_Cheque)
		from VENTAS 
		where (Senia = 0) and (Habilitado=1) and (id_TipoPago=4) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)),0)
			+
		ISNULL((select sum(MontoSenia)
		from VENTAS 
		where(Senia = 1) and (Habilitado=1) and (id_TipoPago=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)),0)
	) as VentasEfectivo

END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtenerFacturado] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select sum(VentasFacturado) as VentasFacturado
from (select
CASE
	WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
	WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
END as VentasFacturado
from VENTAS 
where (Habilitado=1) and (Facturado=1)  and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
group by Senia) Monto

END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtenerMayoristas] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select sum(VentasMayoristas) as VentasMayoristas
from (select
CASE
	WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
	WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
END as VentasMayoristas
from VENTAS 
where (Habilitado=1) and (Id_TipoVenta = 2) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
group by Senia) Monto

END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtenerMinoristas] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select sum(VentasMinoristas) as VentasMinoristas
from (select
CASE
	WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
	WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
END as VentasMinoristas
from VENTAS 
where (Habilitado=1) and (Id_TipoVenta =1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
group by Senia) Monto

END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_Total] 
@id_Sucursal as int,
@Fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN    
	select sum(VentasTotales) as VentasTotales
	from (select
		CASE
		WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
		WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
		END as VentasTotales
		from VENTAS 
		where (Habilitado=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0)
		group by Senia) Monto
	END
	
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_TotalFacturado] 
@id_Sucursal as int,
@Fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN 
	select sum(VentasTotales) as VentasTotales
	from (   
		select 
		CASE
		WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
		WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
		END as VentasTotales
		from VENTAS 
		where (Habilitado=1) and (Facturado=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)
		group by Senia) Monto
	END
	
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_TotalMayorista] 
@id_Sucursal as int,
@Fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN    
	select sum(VentasTotales) as VentasTotales
		from (select 
		CASE
		WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
		WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
		END as VentasTotales
		from VENTAS 
		where (Habilitado=1) and (Id_TipoVenta = 2) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)
	group by Senia) Monto
	END
	
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_TotalMinorista] 
@id_Sucursal as int,
@Fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN    
	select sum(VentasTotales) as VentasTotales
	from (select 
		CASE
		WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
		WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
		END as VentasTotales
		from VENTAS 
		where (Habilitado=1) and (Id_TipoVenta =1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)
		group by Senia) Monto
	END
	
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_TotalVentas] 
@id_Sucursal as int,
@Fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN    
	select sum(VentasTotales) as VentasTotales
	from (select 
		CASE
		WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
		WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
		END as VentasTotales
		from VENTAS 
		where (Habilitado=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)
		group by Senia) Monto
	END
	
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_TotalVentasCheque] 
@id_Sucursal as int,
@Fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN    
	select sum(VentasTotales) as VentasTotales
	from (select 
		CASE
		WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
		WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
		END as VentasTotales
		from VENTAS 
		where (Habilitado=1) and (id_TipoPago=4) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)
		group by Senia) Monto
	END
	
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_TotalVentasEfectivo] 
@id_Sucursal as int,
@Fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN    
	select( 
		ISNULL((select sum(Precio_Total)
		from VENTAS 
		where (Senia=0) and (Habilitado=1) and (id_TipoPago=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)), 0)
			+
		ISNULL((select sum(Diferencia_Pago_Cheque)
		from VENTAS 
		where (Senia=0) and (Habilitado=1) and (id_TipoPago=4) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)),0)
			+
		ISNULL((select sum(MontoSenia)
		from VENTAS 
		where (Senia=1) and (Habilitado=1) and (id_TipoPago=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)), 0)
	) as "VentasTotales" 
	END
END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_TotalVentasTarjetas] 
@id_Sucursal as int,
@Fecha as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN    
	select sum(VentasTotales) as VentasTotales
	from (select 
		CASE
		WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0))  
		WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
		END as VentasTotales
		from VENTAS 
		where (Habilitado=1) and (id_TipoPago=2 or id_TipoPago=3) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)
		group by Senia) Monto
	END
	
END
GO

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
		COMISIONES.Monto,
		COMISIONES.Comision,
		COMISIONES.Fecha, 
	CASE
	WHEN Senia=0 THEN VENTAS.Precio_Total  
	WHEN Senia=1 THEN VENTAS.MontoSenia
	END as Precio_Total
	from COMISIONES
	INNER JOIN VENTAS ON COMISIONES.id_Venta = VENTAS.id_Venta
	where (COMISIONES.id_Empleado=@id_Empleado) and (COMISIONES.Fecha between @FDesde and @FHasta) and (COMISIONES.id_Sucursal=@id_Sucursal)

END
GO

ALTER PROCEDURE [dbo].[sp_Ventas_SucursalObtenerListado] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select Fecha,
CASE
	WHEN Senia=0 THEN sum(ISNULL(Precio_Total,0)) + sum(ISNULL(Diferencia_Pago_Cheque,0))  
	WHEN Senia=1 THEN sum(ISNULL(MontoSenia,0)) 
END
from VENTAS 
where (Habilitado=1) and (CAST(Fecha AS DATE) between @FDesde and @FHasta) and (id_Sucursal=@id_Sucursal)
group by Fecha, Senia

END
GO

ALTER function [dbo].[ObtenerIngresos]
(@id_Sucursal integer, @fecha date)
returns float as
begin
	declare @ventas float = 0, @DiferenciaPagoCheque float = 0, @Sobrante float = 0, @CajaInicial float = 0, @Ingresos float = 0, @AporteSocios float = 0, @EgresoCajaFuerte float = 0, @montoSenia float = 0

	select @ventas = ISNULL(sum(Precio_Total),0)
	from VENTAS 
	where (Senia=0) and (Habilitado=1) and (id_TipoPago=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)

	select @montoSenia = ISNULL(sum(MontoSenia),0)
	from VENTAS 
	where (Senia=1) and (Habilitado=1) and (id_TipoPago=1) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)

	select @DiferenciaPagoCheque = ISNULL(sum(Diferencia_Pago_Cheque),0)
	from VENTAS 
	where (Senia=0) and (Habilitado=1) and (id_TipoPago=4) and (id_Sucursal=@id_Sucursal) and (Anulado=0) and (CAST(Fecha AS DATE)=@Fecha)

	select @Sobrante = ISNULL(SUM(Monto),0)
	from MOVIMIENTOS_CAJA
	where (CAST(Fecha AS DATE) =@fecha) and (id_Sucursal=@id_Sucursal) and (id_Tipo=3)

	select @CajaInicial = ISNULL(Monto,0)
	from CAJA_INICIAL 
	where (CAJA_INICIAL.id_Sucursal=@id_Sucursal) and (CAST(CAJA_INICIAL.Fecha AS DATE)=DATEADD(day,-1,@fecha))

	select @Ingresos = ISNULL(SUM(Monto),0)
	from MOVIMIENTOS_EGRESOS
	where (CAST(Fecha AS DATE) = @fecha) and (id_SucursalDestino=@id_Sucursal) and (id_Sucursal != @id_Sucursal) and (Monto > 0) and (Aceptado=1)

	select @AporteSocios = ISNULL(SUM(Monto),0)
	from MOVIMIENTOS_APORTE
	where (CAST(Fecha AS DATE) between @fecha and @fecha) and id_Tipo_Pago = 1 and (id_Sucursal=@id_Sucursal)

	select @EgresoCajaFuerte = ISNULL(SUM(Monto),0) from MOVIMIENTOS_CAJA_FUERTE
	where (CAST(Fecha AS DATE) between @fecha and @fecha) and (id_Sucursal=@id_Sucursal) and (id_Tipo=1)

	return @ventas + @DiferenciaPagoCheque + @Sobrante + @CajaInicial + @Ingresos + @AporteSocios + @EgresoCajaFuerte + @montoSenia
end;
GO

ALTER PROCEDURE [dbo].[sp_Movimiento_Sucursales_Ventas] 
@id_Sucursal as int,
@FDesde as date,
@FHasta as date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	BEGIN    
		declare @ColumnName varchar(8000) = ''

		SELECT @ColumnName +=  '[' + CONVERT(VARCHAR(12), DATEADD(DAY,number,@FDesde)) + '],'  
		FROM master..spt_values
		WHERE type = 'P'
		AND DATEADD(DAY,number,@FDesde) <= @FHasta

		set @ColumnName = left(@ColumnName, len(@ColumnName) - 1)

		declare @SQL varchar(8000) ='
		select * 
		from( 
			--FORMA DE PAGO--
			Select p.Descripcion,
					case
						when v.Senia = 0 then SUM(v.Precio_Total)
						when v.Senia = 1 then SUM(v.MontoSenia) 
					end as Precio_Total,
					CAST(v.Fecha AS DATE) as Fecha,
					4 Nivel
			from 
				[dbo].[VENTAS] v INNER JOIN
				[dbo].[TIPOS_PAGO] p ON v.Id_TipoPago = p.Id_TipoPago
			where v.Habilitado=1 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (v.Anulado=0) and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +''')
			group by CAST(v.Fecha AS DATE), Descripcion, Senia

				union all

				Select p.Descripcion,
				0 as Precio_Total,
				null as Fecha,
				4 Nivel
				from [dbo].[TIPOS_PAGO] p
				where p.Id_TipoPago not in(select Id_TipoPago from [dbo].[VENTAS] v where v.Habilitado=1 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (v.Anulado=0) and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +'''))

			union all

			--TIPO DE CLIENTE--
			Select t.Descripcion,
					case
						when v.Senia = 0 then SUM(v.Precio_Total)
						when v.Senia = 1 then SUM(v.MontoSenia) 
					end as Precio_Total,
					CAST(v.Fecha AS DATE) as Fecha,
					4 Nivel
			from 
				[dbo].[VENTAS] v INNER JOIN
				[dbo].[TIPOS_VENTAS] t ON v.Id_TipoVenta = t.Id_TipoVenta
			where v.Habilitado=1 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (v.Anulado=0) and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +''')
			group by CAST(v.Fecha AS DATE), Descripcion, Senia

				union all

				Select p.Descripcion,
				0 as Precio_Total,
				null as Fecha,
				4 Nivel
				from [dbo].[TIPOS_VENTAS] p
				where p.Id_TipoVenta not in(select Id_TipoVenta from [dbo].[VENTAS] v where v.Habilitado=1 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (v.Anulado=0) and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +'''))

			union all

			--FACTURACION--
			Select ''Facturado'',
					case
						when v.Senia = 0 then SUM(v.Precio_Total)
						when v.Senia = 1 then SUM(v.MontoSenia) 
					end as Precio_Total,
					CAST(v.Fecha AS DATE) as Fecha,
					4 Nivel
			from 
				[dbo].[VENTAS] v INNER JOIN
				[dbo].[TIPOS_VENTAS] t ON v.Id_TipoVenta = t.Id_TipoVenta
			where Facturado=1 and v.Habilitado=1 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (v.Anulado=0) and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +''')
			group by CAST(v.Fecha AS DATE), Descripcion, Senia

				union all

				Select ''Facturado'',
						0 as Precio_Total,
						Null as Fecha,
						4 Nivel
				where not exists(select * from [dbo].[VENTAS] v where Facturado=1 and v.Habilitado=1 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (v.Anulado=0) and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +'''))

			union all

			--DEVOLUCIONES--
			Select ''Devoluciones'',
					SUM(d.Precio_Total) as Precio_Total,
					CAST(d.Fecha AS DATE) as Fecha,
					3 Nivel
				from 
					[dbo].[DEVOLUCIONES] d
				where d.Habilitado=1 and (d.Anulado=0) and (d.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (CAST(d.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +''')
				group by CAST(d.Fecha AS DATE)

				union all

				Select ''Devoluciones'',
						0 as Precio_Total,
						Null as Fecha,
						3 Nivel
				where not exists(select * from [dbo].[DEVOLUCIONES] d where d.Habilitado=1 and (d.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (CAST(d.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +'''))

			union all

				--VENTAS TOTALES--
			Select ''Ventas totales'',
					case
						when v.Senia = 0 then SUM(v.Precio_Total)
						when v.Senia = 1 then SUM(v.MontoSenia) 
					end as Precio_Total,
					CAST(v.Fecha AS DATE) as Fecha,
					2 Nivel
				from 
					[dbo].[VENTAS] v
				where v.Habilitado=1 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +''')
				group by CAST(v.Fecha AS DATE), Senia

				union all

				Select ''Ventas totales'',
						0 as Precio_Total,
						Null as Fecha,
						2 Nivel
				where not exists(select * from [dbo].[VENTAS] v where v.Habilitado=1 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +'''))

			union all

				--VENTAS--
				Select ''Ventas'',
						case
							when v.Senia = 0 then SUM(isnull(v.Precio_Total,0))
							when v.Senia = 1 then SUM(isnull(v.MontoSenia,0)) 
						end as Precio_Total,
				CAST(v.Fecha AS DATE),
				1 Nivel
				from [dbo].[VENTAS] v
				where (v.Habilitado=1 and v.Anulado=0 and (v.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (CAST(v.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +'''))
				group by CAST(v.Fecha AS DATE),Senia

				union all

				Select ''Ventas'',
				-SUM(isnull(d.Precio_Total, 0)) as Precio_Total,
				CAST(d.Fecha AS DATE) Fecha,
				1 Nivel
				from [dbo].[DEVOLUCIONES] d
				where (d.Habilitado=1 and d.Anulado=0 and (d.id_Sucursal='+ CONVERT(VARCHAR(12), @id_Sucursal) +') and (CAST(d.Fecha AS DATE) between '''+  CONVERT(VARCHAR(12), @FDesde) +''' and '''+CONVERT(VARCHAR(12), @FHasta)  +'''))
				group by CAST(d.Fecha AS DATE)

				union all 

				Select ''Ventas'',
				0 as Precio_Total,
				null Fecha,
				1 Nivel
		
			) as data '

	declare @PIVOT varchar(8000) = ' PIVOT(
		SUM(Precio_Total)
		FOR Fecha
		IN ('+
		@ColumnName
		+')) As PivotTable
		Order by Nivel, Descripcion'

		print @SQL + @PIVOT
		EXEC (@SQL + @PIVOT)
	END
	
END
GO


---------------------------------------------------------------------

CREATE TABLE [dbo].[SENIA](
	[id_Senia] [int] IDENTITY(1,1) NOT NULL,
	[id_Sucursal] [int] NOT NULL,
	[id_ClienteMinorista] [int] NOT NULL,
	[id_ClienteMayorista] [int] NOT NULL,
	[id_Venta_Senia] [int] NOT NULL,
	[id_Venta_Retiro] [int] NOT NULL,
	[FechaAlta] [date] NULL,
	[FechaEstimadaRetiro] [date] NULL,
	[FormaEntrega] [nvarchar] (255) NOT NULL,
	[Observaciones] [nvarchar] (255),
	[Entregada] [bit] Not Null DEFAULT(0)
 CONSTRAINT [PK_Senia] PRIMARY KEY CLUSTERED 
(
	[id_Senia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

CREATE PROCEDURE [dbo].[sp_Senia_Alta]
	@id_Sucursal int,
	@id_ClienteMinorista int,
	@id_ClienteMayorista int,
	@id_Venta int,
	@FechaAlta date,
	@FechaEstimadaRetiro date,
	@FormaEntrega nvarchar (255),
	@Observaciones nvarchar (255),
	@Entregada Bit
AS
	
BEGIN
Begin Tran t_Alta
    Begin Try

		BEGIN

			INSERT INTO dbo.SENIA(id_Sucursal, id_ClienteMinorista, id_ClienteMayorista, id_Venta, FechaAlta, FechaEstimadaRetiro, FormaEntrega, Observaciones,Entregada) VALUES 
			(@id_Sucursal, @id_ClienteMinorista, @id_ClienteMayorista, @id_Venta, @FechaAlta, @FechaEstimadaRetiro, @FormaEntrega, @Observaciones,@Entregada)
			COMMIT TRAN t_Alta
		END
			
    End try
    Begin Catch
		BEGIN
			Rollback TRAN t_Alta
		END

    End Catch
END

GO

CREATE PROCEDURE [dbo].[sp_Senia_Consultar]
@idSucursal int
AS
	
BEGIN
	Select	S.id_Senia,
			S.id_Sucursal,
			S.id_ClienteMinorista,
			CMIN.Apellido + ' ' + CMIN.Nombre NombreMinorista,
			S.id_ClienteMayorista,
			CMAY.RazonSocial,
			S.id_Venta,
			S.FechaAlta,
			S.FechaEstimadaRetiro,
			S.FormaEntrega,
			S.Observaciones,
			S.Entregada,
			v.Precio_Total,
			v.MontoSenia
	 from dbo.SENIA S left join CLIENTEMINORISTA CMIN on S.id_ClienteMinorista = CMIN.id_ClienteMinorista 
			left join CLIENTES CMAY on S.id_ClienteMayorista = CMAY.id_Cliente 
			inner join VENTAS V on S.id_Venta = V.id_Venta
	where s.id_Sucursal = @idSucursal
END


GO

CREATE PROCEDURE [dbo].[sp_Senia_Eliminar]
@idSenia int
AS
	
BEGIN
	UPDATE VENTAS set DescripcionAnulado='Por eliminacion de reserva',FechaAnulado=GETDATE(),Anulado=1 WHERE id_Venta=(select id_Venta from dbo.SENIA where id_Senia = @idSenia)
	delete dbo.SENIA where id_Senia = @idSenia
END
GO

----------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[CLIENTEMINORISTA](
	[id_ClienteMinorista] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar] (125) NOT NULL,
	[Nombre] [nvarchar] (125) NOT NULL,
	[Telefono] [nvarchar] (125) NOT NULL,
	[Email] [nvarchar] (125) NULL,
	[EnviarNovedades] [bit] NULL,
	[Direccion] [nvarchar] (125)  NULL,

 CONSTRAINT [PK_ClienteMinorista] PRIMARY KEY CLUSTERED 
(
	[id_ClienteMinorista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE PROCEDURE [dbo].[sp_ClienteMinorista_Alta]
	@Apellido nvarchar (125),
	@Nombre nvarchar (125),
	@Telefono nvarchar (125),
	@Email nvarchar (125),
	@EnviarNovedades bit,
	@Direccion nvarchar (125),
	@id_ClienteMinorista int out
AS
	
BEGIN
Begin Tran t_Alta
    Begin Try

		BEGIN

			INSERT INTO dbo.CLIENTEMINORISTA(Apellido, Nombre, Telefono, Email, EnviarNovedades, Direccion) 
			OUTPUT inserted.id_ClienteMinorista
			VALUES (@Apellido, @Nombre, @Telefono, @Email, @EnviarNovedades, @Direccion)
			COMMIT TRAN t_Alta

			select @id_ClienteMinorista = IDENT_CURRENT('CLIENTEMINORISTA') 
		END
			
    End try
    Begin Catch
		BEGIN
			Rollback TRAN t_Alta
		END

    End Catch
END

GO

CREATE PROCEDURE [dbo].[sp_ClienteMinorista_Obtener]
AS
	
BEGIN
	select * from dbo.CLIENTEMINORISTA
END
Go

CREATE PROCEDURE [dbo].[sp_ClienteMinorista_Modificar]
	@Id_ClienteMinorista as Integer,
	@Apellido nvarchar (125),
	@Nombre nvarchar (125),
	@Telefono nvarchar (125),
	@Email nvarchar (125),
	@EnviarNovedades bit,
	@Direccion nvarchar (125)
AS
	
BEGIN
Begin Tran t_Alta
    Begin Try

		BEGIN
			UPDATE dbo.CLIENTEMINORISTA Set Apellido = @Apellido, Nombre = @Nombre, Telefono = @Telefono, Email = @Email, EnviarNovedades = @EnviarNovedades, Direccion = @Direccion where id_ClienteMinorista = @Id_ClienteMinorista
			COMMIT TRAN t_Alta
		END
			
    End try
    Begin Catch
		BEGIN
			Rollback TRAN t_Alta
		END

    End Catch
END
GO

CREATE PROCEDURE [dbo].[sp_ClienteMinorista_Detalle]
	@Id_ClienteMinorista as Integer
AS
	
BEGIN
	select * from dbo.CLIENTEMINORISTA where id_ClienteMinorista = @Id_ClienteMinorista
END

GO


------------------------------------------------------------
SET IDENTITY_INSERT [dbo].[PATENTES] ON
INSERT INTO [dbo].[PATENTES] ([id_Patente], [Descripcion] ,[Id_Grupo])
     VALUES(616,'Administración -> Reservas -> Administración Reservas', 1)
SET IDENTITY_INSERT [dbo].[PATENTES] OFF
GO

INSERT INTO [dbo].[REL_PERFILES_PATENTES] ([id_Perfil],[id_Patente])
     VALUES (1,616)
GO

