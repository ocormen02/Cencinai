USE [Cencinai]
GO
/****** Object:  Table [dbo].[Canton]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canton](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProvinciaId] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Canton] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Abreviatura] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distrito]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distrito](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CantonId] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Distrito] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoNutricional]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoNutricional](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NiñoId] [int] NOT NULL,
	[IndiceMasaCorporal] [varchar](30) NULL,
	[TallaEdad] [varchar](30) NULL,
	[PesoEdad] [varchar](30) NULL,
	[PesoTalla] [varchar](30) NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK_EstadoNutricional] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Niño]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Niño](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[PrimerApellido] [varchar](20) NOT NULL,
	[SegundoApellido] [varchar](20) NULL,
	[FechaNacimiento] [date] NULL,
	[InformacionAdicional] [varchar](max) NULL,
	[Sexo] [varchar](8) NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[ResponsableId] [int] NOT NULL,
 CONSTRAINT [PK_Niño] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NivelDesarrollo]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelDesarrollo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MotoraGruesa] [varchar](15) NULL,
	[MotoraFina] [varchar](15) NULL,
	[Cognoscitiva] [varchar](15) NULL,
	[Lenguaje] [varchar](15) NULL,
	[Socioafectiva] [varchar](15) NULL,
	[Habitos] [varchar](15) NULL,
	[NiñoId] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK_AreasDesarrollo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Responsable]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Responsable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[PrimerApellido] [varchar](50) NOT NULL,
	[SegundoApellido] [varchar](50) NULL,
	[Telefono] [varchar](10) NOT NULL,
	[TelefonoAdicional] [varchar](10) NULL,
	[DistritoId] [int] NOT NULL,
	[DireccionExacta] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Responsable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/5/2020 11:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](100) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Canton]  WITH CHECK ADD  CONSTRAINT [FK_Canton_Provincia] FOREIGN KEY([ProvinciaId])
REFERENCES [dbo].[Provincia] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Canton] CHECK CONSTRAINT [FK_Canton_Provincia]
GO
ALTER TABLE [dbo].[Distrito]  WITH CHECK ADD  CONSTRAINT [FK_Distrito_Canton] FOREIGN KEY([CantonId])
REFERENCES [dbo].[Canton] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Distrito] CHECK CONSTRAINT [FK_Distrito_Canton]
GO
ALTER TABLE [dbo].[EstadoNutricional]  WITH CHECK ADD  CONSTRAINT [FK_EstadoNutricional_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
GO
ALTER TABLE [dbo].[EstadoNutricional] CHECK CONSTRAINT [FK_EstadoNutricional_Niño]
GO
ALTER TABLE [dbo].[Niño]  WITH CHECK ADD  CONSTRAINT [FK_Niño_Categoria] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Niño] CHECK CONSTRAINT [FK_Niño_Categoria]
GO
ALTER TABLE [dbo].[Niño]  WITH CHECK ADD  CONSTRAINT [FK_Niño_Responsable] FOREIGN KEY([ResponsableId])
REFERENCES [dbo].[Responsable] ([Id])
GO
ALTER TABLE [dbo].[Niño] CHECK CONSTRAINT [FK_Niño_Responsable]
GO
ALTER TABLE [dbo].[NivelDesarrollo]  WITH CHECK ADD  CONSTRAINT [FK_NivelDesarrollo_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NivelDesarrollo] CHECK CONSTRAINT [FK_NivelDesarrollo_Niño]
GO
ALTER TABLE [dbo].[Responsable]  WITH CHECK ADD  CONSTRAINT [FK_Responsable_Distrito] FOREIGN KEY([DistritoId])
REFERENCES [dbo].[Distrito] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Responsable] CHECK CONSTRAINT [FK_Responsable_Distrito]
GO
