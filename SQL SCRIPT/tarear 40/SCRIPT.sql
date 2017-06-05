/****** Object:  StoredProcedure [dbo].[sp_Productos_ListadoBuscadores]    Script Date: 27/05/2017 12:18:54 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Productos_ListadoBuscadoresPorProveedor] 
@id_Proveedor AS INTEGER 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  PRODUCTOS.Nombre,PRODUCTOS.Codigo,PRODUCTOS.CodigoBarra,PRODUCTOS.id_Producto
	from PRODUCTOS 
	where Habilitado=1 and PRODUCTOS.id_Proveedor=@id_Proveedor
	order by PRODUCTOS.Nombre ASC
END


