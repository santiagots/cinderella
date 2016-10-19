USE [CINDERELLA]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

ALTER TABLE [dbo].[VENTAS]
ADD [Senia] [float] Not Null DEFAULT(0)
GO

ALTER PROCEDURE [dbo].[sp_Ventas_Alta]
    @id_Cliente AS INT,
    @id_Empleado AS INT,    
    @id_Encargado AS INT,
    @id_Sucursal AS INT,      
    @id_TipoPago AS INT,      
    @id_TipoVenta AS INT,                      
    @CantidadTotal AS INT,    
    @PrecioTotal AS FLOAT,      
    @Subtotal AS FLOAT, 
	@Senia AS FLOAT,
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

			INSERT INTO dbo.VENTAS (id_Cliente,id_Empleado,id_Encargado,id_Sucursal,id_TipoPago,id_TipoVenta,Cantidad_Total,Precio_Total,Subtotal,Descuento,Anulado,Habilitado,Facturado,Fecha,Diferencia_Pago_Cheque,Numero,Senia) VALUES (@id_Cliente,
			@id_Empleado,@id_Encargado,@id_Sucursal,@id_TipoPago,@id_TipoVenta,@CantidadTotal,@PrecioTotal,@Subtotal,@Descuento,@Anulado,@Habilitado,@Facturado,GETDATE(),@DiferenciaPagoCheque,@numero,@Senia)

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


ALTER PROCEDURE [dbo].[sp_Ventas_Detalle] 
@id_Venta as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT VENTAS.id_Sucursal,
		VENTAS.id_Empleado,
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
		VENTAS.Descuento,
		VENTAS.Subtotal,
		CLIENTES.RazonSocial, TIPOS_PAGO.Descripcion as "TiposPago",
		TIPOS_VENTAS.Descripcion as "TiposVenta",
		SUCURSALES.Nombre as "Sucursal",
		EMPLEADOS.Apellido + ' ' + EMPLEADOS.Nombre as "Empleado",
		ENCARGADO.Apellido + ' ' + ENCARGADO.Nombre as "Encargado"
	from VENTAS 
	inner join EMPLEADOS on EMPLEADOS.id_Empleado=VENTAS.id_Empleado
	left join EMPLEADOS as "ENCARGADO" on EMPLEADOS.id_Empleado=VENTAS.id_Encargado 
	left join CLIENTES on CLIENTES.id_Cliente=VENTAS.id_Cliente 
	inner join TIPOS_PAGO on TIPOS_PAGO.id_TipoPago = VENTAS.id_TipoPago 
	inner join TIPOS_VENTAS on TIPOS_VENTAS.id_TipoVenta = VENTAS.id_TipoVenta 
	inner join SUCURSALES on SUCURSALES.id_Sucursal = VENTAS.id_Sucursal 
	LEFT JOIN FACTURACION ON VENTAS.id_Venta = FACTURACION.id_Venta
	where VENTAS.id_Venta=@id_Venta
	
END
