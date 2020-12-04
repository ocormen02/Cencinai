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

INSERT [dbo].[Usuario] ([Id], [NombreUsuario], [Contraseña], [Nombre]) VALUES (2, N'Admin', N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
