/*
   sábado, 04 de marzo de 201703:41:59 p.m.
   User: 
   Server: TAMBOURS7
   Database: CINDERELLA
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.VENTAS_DETALLE ADD
	Iva float(53) NULL,
	Monto float(53) NULL
GO
ALTER TABLE dbo.VENTAS_DETALLE SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
