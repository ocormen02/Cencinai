USE [Cencinai]
GO
/****** Object:  Table [dbo].[AreasDesarrollo]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AreasDesarrollo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MotoraGruesa] [int] NULL,
	[MotoraFina] [int] NULL,
	[Cognoscitiva] [int] NULL,
	[Lenguaje] [int] NULL,
	[Socioafectiva] [int] NULL,
	[Habitos] [int] NULL,
	[NiñoId] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_AreasDesarrollo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Canton]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canton](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Canton] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Abreviatura] [varchar](10) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProvinciaId] [int] NOT NULL,
	[CantonId] [int] NOT NULL,
	[DistritoId] [int] NOT NULL,
	[DireccionExacta] [varchar](200) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distrito]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distrito](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Distrito] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IndiceMasaCorporal]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IndiceMasaCorporal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NiñoId] [int] NOT NULL,
	[Obesidad] [bit] NULL,
	[SobrePeso] [bit] NULL,
	[Normal] [bit] NULL,
	[Desnutricion] [bit] NULL,
	[DesnutricionSevera] [bit] NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_IndiceMasaCorporal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Niño]    Script Date: 8/17/2020 10:35:01 PM ******/
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
	[CategoryId] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Niño] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PesoEdad]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PesoEdad](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NiñoId] [int] NOT NULL,
	[PesoAlto] [bit] NULL,
	[Normal] [bit] NULL,
	[BajoPeso] [bit] NULL,
	[BajoPesoSevero] [bit] NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_PesoEdad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PesoTalla]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PesoTalla](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NiñoId] [int] NOT NULL,
	[Obesidad] [bit] NULL,
	[SobrePeso] [bit] NULL,
	[Normal] [bit] NULL,
	[Desnutricion] [bit] NULL,
	[DesnutricionSevera] [bit] NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_PesoTalla] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 8/17/2020 10:35:01 PM ******/
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
/****** Object:  Table [dbo].[PuntuacionAreaDesarrollo]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PuntuacionAreaDesarrollo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MotoroGruesa] [int] NULL,
	[MotoraFina] [int] NULL,
	[Lenguaje] [int] NULL,
	[Cognositiva] [int] NULL,
	[SocioAfectiva] [int] NULL,
	[NiñoId] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_PuntuacionAreaDesarrollo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Responsable]    Script Date: 8/17/2020 10:35:01 PM ******/
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
	[DireccionId] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Responsable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResponsableNiño]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResponsableNiño](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ResponsableId] [int] NOT NULL,
	[NiñoId] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_ResponsableNiño] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ResponsableId] ASC,
	[NiñoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TallaEdad]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TallaEdad](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NiñoId] [int] NOT NULL,
	[MuyAlto] [bit] NULL,
	[Alto] [bit] NULL,
	[Normal] [bit] NULL,
	[BajoTalla] [bit] NULL,
	[BajaTallaSevera] [bit] NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_TallaEdad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 8/17/2020 10:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](8) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AreasDesarrollo]  WITH CHECK ADD  CONSTRAINT [FK_AreasDesarrollo_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
GO
ALTER TABLE [dbo].[AreasDesarrollo] CHECK CONSTRAINT [FK_AreasDesarrollo_Niño]
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Canton] FOREIGN KEY([CantonId])
REFERENCES [dbo].[Canton] ([Id])
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [FK_Direccion_Canton]
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Distrito] FOREIGN KEY([DistritoId])
REFERENCES [dbo].[Distrito] ([Id])
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [FK_Direccion_Distrito]
GO
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Provincia] FOREIGN KEY([ProvinciaId])
REFERENCES [dbo].[Provincia] ([Id])
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [FK_Direccion_Provincia]
GO
ALTER TABLE [dbo].[IndiceMasaCorporal]  WITH CHECK ADD  CONSTRAINT [FK_IndiceMasaCorporal_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
GO
ALTER TABLE [dbo].[IndiceMasaCorporal] CHECK CONSTRAINT [FK_IndiceMasaCorporal_Niño]
GO
ALTER TABLE [dbo].[Niño]  WITH CHECK ADD  CONSTRAINT [FK_Niño_Categoria] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categoria] ([Id])
GO
ALTER TABLE [dbo].[Niño] CHECK CONSTRAINT [FK_Niño_Categoria]
GO
ALTER TABLE [dbo].[PesoEdad]  WITH CHECK ADD  CONSTRAINT [FK_PesoEdad_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
GO
ALTER TABLE [dbo].[PesoEdad] CHECK CONSTRAINT [FK_PesoEdad_Niño]
GO
ALTER TABLE [dbo].[PesoTalla]  WITH CHECK ADD  CONSTRAINT [FK_PesoTalla_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
GO
ALTER TABLE [dbo].[PesoTalla] CHECK CONSTRAINT [FK_PesoTalla_Niño]
GO
ALTER TABLE [dbo].[PuntuacionAreaDesarrollo]  WITH CHECK ADD  CONSTRAINT [FK_PuntuacionAreaDesarrollo_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
GO
ALTER TABLE [dbo].[PuntuacionAreaDesarrollo] CHECK CONSTRAINT [FK_PuntuacionAreaDesarrollo_Niño]
GO
ALTER TABLE [dbo].[Responsable]  WITH CHECK ADD  CONSTRAINT [FK_Responsable_Direccion] FOREIGN KEY([DireccionId])
REFERENCES [dbo].[Direccion] ([Id])
GO
ALTER TABLE [dbo].[Responsable] CHECK CONSTRAINT [FK_Responsable_Direccion]
GO
ALTER TABLE [dbo].[ResponsableNiño]  WITH CHECK ADD  CONSTRAINT [FK_ResponsableNiño_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
GO
ALTER TABLE [dbo].[ResponsableNiño] CHECK CONSTRAINT [FK_ResponsableNiño_Niño]
GO
ALTER TABLE [dbo].[ResponsableNiño]  WITH CHECK ADD  CONSTRAINT [FK_ResponsableNiño_Responsable] FOREIGN KEY([ResponsableId])
REFERENCES [dbo].[Responsable] ([Id])
GO
ALTER TABLE [dbo].[ResponsableNiño] CHECK CONSTRAINT [FK_ResponsableNiño_Responsable]
GO
ALTER TABLE [dbo].[TallaEdad]  WITH CHECK ADD  CONSTRAINT [FK_TallaEdad_Niño] FOREIGN KEY([NiñoId])
REFERENCES [dbo].[Niño] ([Id])
GO
ALTER TABLE [dbo].[TallaEdad] CHECK CONSTRAINT [FK_TallaEdad_Niño]
GO
