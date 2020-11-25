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

COMMIT TRANSACTION
GO
