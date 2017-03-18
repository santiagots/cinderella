ALTER TABLE VENTAS
ADD PorcentajeFacturacion FLOAT 

update VENTAS
SET PorcentajeFacturacion = 0

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
ALTER TABLE dbo.VENTAS
	DROP CONSTRAINT DF_VENTAS_Diferencia_Pago_Cheque
GO
ALTER TABLE dbo.VENTAS
	DROP CONSTRAINT DF__VENTAS__Senia__37C5420D
GO
ALTER TABLE dbo.VENTAS
	DROP CONSTRAINT DF__VENTAS__id_Lista__73DA2C14
GO
ALTER TABLE dbo.VENTAS
	DROP CONSTRAINT DF__VENTAS__Senia__75C27486
GO
CREATE TABLE dbo.Tmp_VENTAS
	(
	id_Venta int NOT NULL IDENTITY (1, 1),
	id_Sucursal int NOT NULL,
	id_TipoPago int NOT NULL,
	id_Encargado int NULL,
	id_Empleado int NOT NULL,
	id_TipoVenta int NOT NULL,
	id_Cliente int NULL,
	PorcentajeFacturacion float(53) NULL,
	Cantidad_Total int NULL,
	Subtotal float(53) NULL,
	Precio_Total float(53) NULL,
	Descuento float(53) NULL,
	Fecha datetime NULL,
	Habilitado smallint NULL,
	Anulado smallint NULL,
	Facturado smallint NULL,
	DescripcionAnulado varchar(255) NULL,
	FechaAnulado date NULL,
	Diferencia_Pago_Cheque float(53) NULL,
	Numero varchar(255) NULL,
	MontoSenia float(53) NOT NULL,
	id_ListaPrecio int NOT NULL,
	Senia bit NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_VENTAS SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_VENTAS ADD CONSTRAINT
	DF_VENTAS_Diferencia_Pago_Cheque DEFAULT ((0)) FOR Diferencia_Pago_Cheque
GO
ALTER TABLE dbo.Tmp_VENTAS ADD CONSTRAINT
	DF__VENTAS__Senia__37C5420D DEFAULT ((0)) FOR MontoSenia
GO
ALTER TABLE dbo.Tmp_VENTAS ADD CONSTRAINT
	DF__VENTAS__id_Lista__73DA2C14 DEFAULT ((0)) FOR id_ListaPrecio
GO
ALTER TABLE dbo.Tmp_VENTAS ADD CONSTRAINT
	DF__VENTAS__Senia__75C27486 DEFAULT ((0)) FOR Senia
GO
SET IDENTITY_INSERT dbo.Tmp_VENTAS ON
GO
IF EXISTS(SELECT * FROM dbo.VENTAS)
	 EXEC('INSERT INTO dbo.Tmp_VENTAS (id_Venta, id_Sucursal, id_TipoPago, id_Encargado, id_Empleado, id_TipoVenta, id_Cliente, PorcentajeFacturacion, Cantidad_Total, Subtotal, Precio_Total, Descuento, Fecha, Habilitado, Anulado, Facturado, DescripcionAnulado, FechaAnulado, Diferencia_Pago_Cheque, Numero, MontoSenia, id_ListaPrecio, Senia)
		SELECT id_Venta, id_Sucursal, id_TipoPago, id_Encargado, id_Empleado, id_TipoVenta, id_Cliente, PorcentajeFacturacion, Cantidad_Total, Subtotal, Precio_Total, Descuento, Fecha, Habilitado, Anulado, Facturado, DescripcionAnulado, FechaAnulado, Diferencia_Pago_Cheque, Numero, MontoSenia, id_ListaPrecio, Senia FROM dbo.VENTAS WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_VENTAS OFF
GO
ALTER TABLE dbo.COMISIONES
	DROP CONSTRAINT FK_COMISIONES_VENTAS
GO
DROP TABLE dbo.VENTAS
GO
EXECUTE sp_rename N'dbo.Tmp_VENTAS', N'VENTAS', 'OBJECT' 
GO
ALTER TABLE dbo.VENTAS ADD CONSTRAINT
	PK_VENTAS_1 PRIMARY KEY CLUSTERED 
	(
	id_Venta
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.COMISIONES WITH NOCHECK ADD CONSTRAINT
	FK_COMISIONES_VENTAS FOREIGN KEY
	(
	id_Venta
	) REFERENCES dbo.VENTAS
	(
	id_Venta
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.COMISIONES SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
