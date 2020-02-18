/*
Run this script on:

sql5030.site4now.net.DB_9B1463_cinderella    -  This database will be modified

to synchronize it with:

ARCNU434BG8X.CINDERELLA_LOCAL

You are recommended to back up your database before running this script

Script created by SQL Data Compare version 13.7.7.10021 from Red Gate Software Ltd at 7/2/2020 10:51:43

*/
		
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

PRINT(N'Add 6 rows to [dbo].[NUEVA_IVA]')
IF NOT EXISTS (SELECT * FROM [dbo].[NUEVA_IVA] WHERE id = 3)
INSERT INTO [dbo].[NUEVA_IVA] ([Id], [Valor]) VALUES (3, 0.0000)
IF NOT EXISTS (SELECT * FROM [dbo].[NUEVA_IVA] WHERE id = 4)
INSERT INTO [dbo].[NUEVA_IVA] ([Id], [Valor]) VALUES (4, 0.1050)
IF NOT EXISTS (SELECT * FROM [dbo].[NUEVA_IVA] WHERE id = 5)
INSERT INTO [dbo].[NUEVA_IVA] ([Id], [Valor]) VALUES (5, 0.2100)
IF NOT EXISTS (SELECT * FROM [dbo].[NUEVA_IVA] WHERE id = 6)
INSERT INTO [dbo].[NUEVA_IVA] ([Id], [Valor]) VALUES (6, 0.2700)
IF NOT EXISTS (SELECT * FROM [dbo].[NUEVA_IVA] WHERE id = 8)
INSERT INTO [dbo].[NUEVA_IVA] ([Id], [Valor]) VALUES (8, 0.0500)
IF NOT EXISTS (SELECT * FROM [dbo].[NUEVA_IVA] WHERE id = 9)
INSERT INTO [dbo].[NUEVA_IVA] ([Id], [Valor]) VALUES (9, 0.0250)
COMMIT TRANSACTION
GO
