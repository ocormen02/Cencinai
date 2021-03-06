USE [Cencinai]
GO
SET IDENTITY_INSERT [dbo].[Provincia] ON 

INSERT [dbo].[Provincia] ([Id], [Nombre]) VALUES (2, N'Alajuela')
SET IDENTITY_INSERT [dbo].[Provincia] OFF
GO
SET IDENTITY_INSERT [dbo].[Canton] ON 

INSERT [dbo].[Canton] ([Id], [ProvinciaId], [Nombre]) VALUES (4, 2, N'Naranjo')
SET IDENTITY_INSERT [dbo].[Canton] OFF
GO
SET IDENTITY_INSERT [dbo].[Distrito] ON 

INSERT [dbo].[Distrito] ([Id], [CantonId], [Nombre]) VALUES (1, 4, N'Naranjo')
SET IDENTITY_INSERT [dbo].[Distrito] OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([Id], [Nombre], [Abreviatura]) VALUES (1, N'API', N'API')
INSERT [dbo].[Categoria] ([Id], [Nombre], [Abreviatura]) VALUES (2, N'CS', N'CS')
INSERT [dbo].[Categoria] ([Id], [Nombre], [Abreviatura]) VALUES (3, N'Leche', N'Leche')
INSERT [dbo].[Categoria] ([Id], [Nombre], [Abreviatura]) VALUES (4, N'DAF', N'DAF')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [NombreUsuario], [Contraseña], [Nombre]) VALUES (2, N'Admin', N'47-F2-F8-09-02-02-6F-79-A1-4C-DE-30-C2-D0-80-4D', N'Admin')
INSERT [dbo].[Usuario] ([Id], [NombreUsuario], [Contraseña], [Nombre]) VALUES (3, N'laura', N'D1-BA-95-7E-BC-49-98-83-8E-4A-88-0A-EF-31-83-D3', N'Laura Chinchilla')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
