USE [CINDERELLA]
GO
SET IDENTITY_INSERT [dbo].[PATENTES] ON 


INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (617, N'Administración -> Presupuesto -> Administración -> Detalle -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (618, N'Administración -> Presupuesto -> Administración -> Detalle -> Anular', 1)
SET IDENTITY_INSERT [dbo].[PATENTES] OFF
SET IDENTITY_INSERT [dbo].[REL_PERFILES_PATENTES] ON 


INSERT [dbo].[REL_PERFILES_PATENTES] ([id_Auto], [id_Perfil], [id_Patente], [id_Sucursal]) VALUES (4172, 1, 617, NULL)
INSERT [dbo].[REL_PERFILES_PATENTES] ([id_Auto], [id_Perfil], [id_Patente], [id_Sucursal]) VALUES (4173, 1, 618, NULL)
SET IDENTITY_INSERT [dbo].[REL_PERFILES_PATENTES] OFF
