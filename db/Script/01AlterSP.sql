SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
GO
SET DATEFORMAT YMD
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL Serializable
GO
BEGIN TRANSACTION

--Actualiza condicion IVA cliente mayorista
IF EXISTS (SELECT * FROM [NUEVA_FACTURA] WHERE [CondicionIVA] = 0) 
BEGIN
   update [NUEVA_FACTURA]
set [CondicionIVA] = [CondicionIVA] + 1
END

--Actualiza porcentajes de cliente mayorista
update CLIENTEMAYORISTA
set Comision = Comision/100, Bonificacion = Bonificacion/100, Lista = Lista/100
WHERE Comision > 1 or Bonificacion > 1 or Lista > 1

--Agregado patente para cuenta bancaria
IF NOT EXISTS (SELECT * FROM [PATENTES] WHERE [id_Patente] = 622) 
BEGIN
	SET IDENTITY_INSERT [dbo].[PATENTES] ON
	INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (622, N'Administración -> Cuenta Bancaria -> Administración', 1)
	SET IDENTITY_INSERT [dbo].[PATENTES] OFF
END

--Agregado la pantante cuenta bancaria al perfil Administracion
IF NOT EXISTS (SELECT * FROM [REL_PERFILES_PATENTES] WHERE id_Perfil = 1 and id_Patente = 622) 
BEGIN
	insert into [REL_PERFILES_PATENTES] (id_Perfil, id_Patente) values(1, 622)
END

--Cargo un valor por defecto en la nueva columna "Borrado" de la tabla [NUEVA_NOTA_PEDIDO_ITEMS]
IF EXISTS (SELECT * FROM [NUEVA_NOTA_PEDIDO_ITEMS] WHERE Borrado is null) 
BEGIN
	update [dbo].[NUEVA_NOTA_PEDIDO_ITEMS] set Borrado = 0
END

--Altualizo los valores de la tabla STOCK_BITACORA de string a su correspondiente enum
IF EXISTS (SELECT * FROM [STOCK_BITACORA] WHERE Accion = 'Alta') 
BEGIN
	update [dbo].[STOCK_BITACORA] set Accion = 0
	WHERE Accion = 'Alta'
END

IF EXISTS (SELECT * FROM [STOCK_BITACORA] WHERE Accion = 'Modificación') 
BEGIN
	update [dbo].[STOCK_BITACORA] set Accion = 1
	WHERE Accion = 'Modificación'
END

IF EXISTS (SELECT * FROM [STOCK_BITACORA] WHERE Accion = 'Eliminación') 
BEGIN
	update [dbo].[STOCK_BITACORA] set Accion = 2
	WHERE Accion = 'Eliminación'
END

COMMIT TRANSACTION
GO
