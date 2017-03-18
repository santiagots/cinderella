USE [CINDERELLA]
GO

DROP PROCEDURE [sp_Ventas_Alta]
DROP PROCEDURE [sp_NotaPedido_Actualizar]
DROP PROCEDURE [sp_NotaPedido_Alta]
DROP TYPE [VENTA_DETALLE_TYPE]
GO


CREATE TYPE [dbo].[VENTA_DETALLE_TYPE] AS TABLE(
	[id_Producto] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[Precio] [float] NULL,
	[Iva] [float] NULL,
	[Monto] [float] NULL
)
GO

CREATE PROCEDURE [dbo].[sp_Ventas_Alta]
    @id_Cliente AS INT,
	@PorcentajeFacturacion AS FLOAT,
    @id_Empleado AS INT,    
    @id_Encargado AS INT,
    @id_Sucursal AS INT,      
    @id_TipoPago AS INT,      
    @id_TipoVenta AS INT,  
	@id_ListaPrecio AS INT,  	                    
    @CantidadTotal AS INT,    
    @PrecioTotal AS FLOAT,      
    @Subtotal AS FLOAT, 
	@Senia AS BIT,
	@MontoSenia AS FLOAT,
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
			select @codigoVenta = Codigo_Venta from sucursales where id_sucursal = @id_Sucursal

			set @numero = @codigoVenta + CASE @Facturado when 0 then 'N' else 'S' End + rtrim(CONVERT(char(10), GetDate(),112)) + right('000000'+ @cantidadVentas, 6)

			INSERT INTO dbo.VENTAS (id_Cliente,PorcentajeFacturacion,id_Empleado,id_Encargado,id_Sucursal,id_TipoPago,id_TipoVenta,Cantidad_Total,Precio_Total,Subtotal,Descuento,Anulado,Habilitado,Facturado,Fecha,Diferencia_Pago_Cheque,Numero,Senia,MontoSenia,id_ListaPrecio) VALUES 
			(@id_Cliente,@PorcentajeFacturacion,@id_Empleado,@id_Encargado,@id_Sucursal,@id_TipoPago,@id_TipoVenta,@CantidadTotal,@PrecioTotal,@Subtotal,@Descuento,@Anulado,@Habilitado,@Facturado,GETDATE(),@DiferenciaPagoCheque,@numero,@Senia,@MontoSenia,@id_ListaPrecio)

			DECLARE @id_Venta AS INT 
			SET @id_Venta = (select IDENT_CURRENT('VENTAS'))

			INSERT INTO dbo.VENTAS_DETALLE (id_Venta,id_Producto,Cantidad,Precio,Iva,Monto) SELECT @id_Venta,id_Producto,Cantidad,Precio,Iva,Monto  from @Detalle

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
GO

CREATE PROCEDURE [dbo].[sp_NotaPedido_Actualizar]
	@id_NotaPedido AS INT,
    @id_Cliente AS INT,
	@PorcentajeFacturacion AS FLOAT,
    @id_Empleado AS INT, 
	@id_Encargado AS INT, 
    @id_Sucursal AS INT,      
    @id_TipoPago AS INT,      
    @id_TipoVenta AS INT, 
	@id_ConsumidorFinal AS INT,
	@id_ListaPrecio AS INT,
    @PrecioTotal AS FLOAT,
	@Vendida AS SMALLINT,               
	@Detalle dbo.VENTA_DETALLE_TYPE READONLY,
    @msg AS INT OUTPUT
AS
	
BEGIN
Begin Tran t_Actualizar
    Begin Try

		BEGIN
			UPDATE dbo.NOTAPEDIDO SET  id_Cliente = @id_Cliente,
									   id_Empleado = @id_Empleado,
									   PorcentajeFacturacion = @PorcentajeFacturacion,
									   id_Encargado = @id_Encargado,
									   id_Sucursal = @id_Sucursal,
									   id_TipoPago = @id_TipoPago,
									   id_TipoVenta = @id_TipoVenta,
									   id_ConsumidorFinal = @id_ConsumidorFinal,
									   Precio_Total = @PrecioTotal,
									   Vendida = @Vendida,
									   id_ListaPrecio = @id_ListaPrecio
			WHERE id_NotaPedido = @id_NotaPedido

			DELETE FROM dbo.NOTAPEDIDO_DETALLE WHERE id_NotaPedido = @id_NotaPedido

			INSERT INTO dbo.NOTAPEDIDO_DETALLE (id_NotaPedido,id_Producto,Cantidad,Precio) SELECT @id_NotaPedido,id_Producto,Cantidad,Precio  from @Detalle

			SET @msg = @id_NotaPedido
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
GO

CREATE PROCEDURE [dbo].[sp_NotaPedido_Alta]
    @id_Cliente AS INT,
	@PorcentajeFacturacion AS FLOAT,
    @id_Empleado AS INT, 
	@id_Encargado AS INT,    
    @id_Sucursal AS INT,      
    @id_TipoPago AS INT,      
    @id_TipoVenta AS INT, 
	@id_ConsumidorFinal AS INT,
	@id_ListaPrecio AS INT,
    @PrecioTotal AS FLOAT,
	@Vendida AS SMALLINT,               
	@Detalle dbo.VENTA_DETALLE_TYPE READONLY,
    @msg AS INT OUTPUT
AS
	
BEGIN
Begin Tran t_Alta
    Begin Try

		BEGIN
			INSERT INTO dbo.NOTAPEDIDO (id_Cliente,PorcentajeFacturacion,id_Empleado,id_Encargado,id_Sucursal,id_TipoPago,id_TipoVenta,id_ConsumidorFinal,Precio_Total,Fecha,Vendida,id_ListaPrecio)
			VALUES (@id_Cliente,@PorcentajeFacturacion,@id_Empleado,@id_Encargado,@id_Sucursal,@id_TipoPago,@id_TipoVenta,@id_ConsumidorFinal,@PrecioTotal,GETDATE(),@Vendida,@id_ListaPrecio)

			DECLARE @id_NotaPedido AS INT 
			SET @id_NotaPedido = (select IDENT_CURRENT('NOTAPEDIDO'))

			INSERT INTO dbo.NOTAPEDIDO_DETALLE (id_NotaPedido,id_Producto,Cantidad,Precio) SELECT @id_NotaPedido,id_Producto,Cantidad,Precio  from @Detalle

			SET @msg = @id_NotaPedido
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
GO