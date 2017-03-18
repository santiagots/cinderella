USE [CINDERELLA]
GO

/****** Object:  Table [dbo].[PRESUPUESTO_DETALLE]    Script Date: 16/03/2017 07:26:28 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PRESUPUESTO_DETALLE](
	[id_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_Presupuesto] [int] NOT NULL,
	[id_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[Iva] [float] NOT NULL,
	[Monto] [float] NOT NULL,
 CONSTRAINT [PK_PRESUPUESTO_DETALLE] PRIMARY KEY CLUSTERED 
(
	[id_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PRESUPUESTO_DETALLE]  WITH NOCHECK ADD  CONSTRAINT [FK_PRESUPUESTO_DETALLE_PRESUPUESTO] FOREIGN KEY([id_Presupuesto])
REFERENCES [dbo].[PRESUPUESTO] ([id_Presupuesto])
GO

ALTER TABLE [dbo].[PRESUPUESTO_DETALLE] CHECK CONSTRAINT [FK_PRESUPUESTO_DETALLE_PRESUPUESTO]
GO


