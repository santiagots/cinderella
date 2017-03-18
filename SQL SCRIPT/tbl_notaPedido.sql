SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOTAPEDIDO](
	[id_NotaPedido] [int] IDENTITY(1,1) NOT NULL,
	[id_Sucursal] [int] NOT NULL,
	[id_TipoPago] [int] NOT NULL,
	[id_Encargado] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[id_TipoVenta] [int] NOT NULL,
	[id_Cliente] [int] NULL,
	[PorcentajeFacturacion] [float] NULL,
	[id_ConsumidorFinal] [int] NULL,
	[Precio_Total] [float] NULL,
	[Fecha] [datetime] NULL,
	[Vendida] [smallint] NULL,
	[id_ListaPrecio] [int] NOT NULL CONSTRAINT [DF_NOTAPEDIDO_id_ListaPrecio]  DEFAULT ((0)),
 CONSTRAINT [PK_NOTAPEDIDO] PRIMARY KEY CLUSTERED 
(
	[id_NotaPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
