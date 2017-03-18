USE [CINDERELLA]
GO

/****** Object:  Table [dbo].[PRESUPUESTO]    Script Date: 16/03/2017 07:25:24 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PRESUPUESTO](
	[id_Presupuesto] [int] IDENTITY(1,1) NOT NULL,
	[id_Sucursal] [int] NOT NULL,
	[id_TipoPago] [int] NOT NULL,
	[id_Encargado] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[id_TipoVenta] [int] NOT NULL,
	[id_ClienteMayorista] [int] NULL,
	[id_ClienteMinorista] [int] NULL,
	[id_ListaPrecio] [int] NOT NULL,
	[Descuento] [float] NOT NULL,
	[SubTotal] [float] NOT NULL,
	[PrecioTotal] [float] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Anulado] [bit] NULL,
	[DescripcionAnulado] [varchar](255) NULL,
	[FechaAnulado] [date] NULL,
 CONSTRAINT [PK_PRESUPUESTO] PRIMARY KEY CLUSTERED 
(
	[id_Presupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


