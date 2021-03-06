USE [master]
GO
/****** Object:  Database [BDConsu]    Script Date: 06/04/2015 16:41:50 ******/
CREATE DATABASE [BDConsu] ON  PRIMARY 
( NAME = N'BDConsu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BDConsu.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDConsu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BDConsu_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDConsu] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDConsu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDConsu] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BDConsu] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BDConsu] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BDConsu] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BDConsu] SET ARITHABORT OFF
GO
ALTER DATABASE [BDConsu] SET AUTO_CLOSE ON
GO
ALTER DATABASE [BDConsu] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BDConsu] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BDConsu] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BDConsu] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BDConsu] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BDConsu] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BDConsu] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BDConsu] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BDConsu] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BDConsu] SET  ENABLE_BROKER
GO
ALTER DATABASE [BDConsu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BDConsu] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BDConsu] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BDConsu] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BDConsu] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BDConsu] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BDConsu] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [BDConsu] SET  READ_WRITE
GO
ALTER DATABASE [BDConsu] SET RECOVERY SIMPLE
GO
ALTER DATABASE [BDConsu] SET  MULTI_USER
GO
ALTER DATABASE [BDConsu] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BDConsu] SET DB_CHAINING OFF
GO
USE [BDConsu]
GO
/****** Object:  Table [dbo].[Estado_Turnos]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado_Turnos](
	[id_Estado_Turno] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Estado_Turnos] PRIMARY KEY CLUSTERED 
(
	[id_Estado_Turno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Especialidad](
	[id_Especialidad] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[id_Especialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paciente](
	[nro_Paciente] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Domicilio] [varchar](100) NOT NULL,
	[Telefono] [varchar](20) NULL,
	[Celular] [varchar](20) NULL,
	[Correo] [varchar](50) NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[nro_Paciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Jornada]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Jornada](
	[id_Jornada] [int] IDENTITY(1,1) NOT NULL,
	[tipo_Jornada] [varchar](50) NULL,
	[HoraDesde] [time](7) NULL,
	[HoraHasta] [time](7) NULL,
 CONSTRAINT [PK_Jornada] PRIMARY KEY CLUSTERED 
(
	[id_Jornada] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Terapeuta]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Terapeuta](
	[id_terapeuta] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](150) NULL,
	[Nombre] [varchar](150) NULL,
	[usuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
	[id_Jornada] [int] NULL,
	[id_Especialidad] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_terapeuta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Historia]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Historia](
	[id_Historial] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Observacion] [varchar](800) NULL,
	[nro_Paciente] [int] NULL,
 CONSTRAINT [PK_Historia] PRIMARY KEY CLUSTERED 
(
	[id_Historial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dias_NoLaborales]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dias_NoLaborales](
	[id_Dia_NoLaborales] [int] IDENTITY(1,1) NOT NULL,
	[dia_NoLaboral] [date] NULL,
	[id_Terapeuta] [int] NOT NULL,
 CONSTRAINT [PK_Dias_NoLaborales] PRIMARY KEY CLUSTERED 
(
	[id_Dia_NoLaborales] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Agenda]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agenda](
	[id_Agenda] [int] IDENTITY(1,1) NOT NULL,
	[Lunes] [bit] NULL,
	[Martes] [bit] NULL,
	[Miercoles] [bit] NULL,
	[Jueves] [bit] NULL,
	[Viernes] [bit] NULL,
	[Sabado] [bit] NULL,
	[Domingo] [bit] NULL,
	[id_Terapeuta] [int] NULL,
 CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
	[id_Agenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[costo] [money] NULL,
	[cantidad] [int] NULL,
	[id_Terapeuta] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo_Tratamiento]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo_Tratamiento](
	[id_Tipo_Tratamiento] [int] IDENTITY(1,1) NOT NULL,
	[tipo_Tratamiento] [varchar](70) NULL,
	[id_Producto] [int] NULL,
	[Costo] [money] NULL,
 CONSTRAINT [PK_Tipo_Tratamiento] PRIMARY KEY CLUSTERED 
(
	[id_Tipo_Tratamiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 06/04/2015 16:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Turno](
	[id_Turno] [int] IDENTITY(1,1) NOT NULL,
	[id_Paciente] [int] NULL,
	[id_TipoTratamiento] [int] NULL,
	[Fecha] [datetime] NULL,
	[hora] [time](7) NULL,
	[id_Terapeuta] [int] NULL,
	[id_Estado] [int] NULL,
	[Motivo] [varchar](180) NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[id_Turno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Terapeuta_Especialidad]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Terapeuta]  WITH CHECK ADD  CONSTRAINT [FK_Terapeuta_Especialidad] FOREIGN KEY([id_Especialidad])
REFERENCES [dbo].[Especialidad] ([id_Especialidad])
GO
ALTER TABLE [dbo].[Terapeuta] CHECK CONSTRAINT [FK_Terapeuta_Especialidad]
GO
/****** Object:  ForeignKey [FK_Terapeuta_Jornada]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Terapeuta]  WITH CHECK ADD  CONSTRAINT [FK_Terapeuta_Jornada] FOREIGN KEY([id_Jornada])
REFERENCES [dbo].[Jornada] ([id_Jornada])
GO
ALTER TABLE [dbo].[Terapeuta] CHECK CONSTRAINT [FK_Terapeuta_Jornada]
GO
/****** Object:  ForeignKey [FK_Historia_Paciente]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Historia]  WITH CHECK ADD  CONSTRAINT [FK_Historia_Paciente] FOREIGN KEY([nro_Paciente])
REFERENCES [dbo].[Paciente] ([nro_Paciente])
GO
ALTER TABLE [dbo].[Historia] CHECK CONSTRAINT [FK_Historia_Paciente]
GO
/****** Object:  ForeignKey [FK_Dias_NoLaborales_Terapeuta]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Dias_NoLaborales]  WITH CHECK ADD  CONSTRAINT [FK_Dias_NoLaborales_Terapeuta] FOREIGN KEY([id_Terapeuta])
REFERENCES [dbo].[Terapeuta] ([id_terapeuta])
GO
ALTER TABLE [dbo].[Dias_NoLaborales] CHECK CONSTRAINT [FK_Dias_NoLaborales_Terapeuta]
GO
/****** Object:  ForeignKey [FK_Agenda_Terapeuta]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Terapeuta] FOREIGN KEY([id_Terapeuta])
REFERENCES [dbo].[Terapeuta] ([id_terapeuta])
GO
ALTER TABLE [dbo].[Agenda] CHECK CONSTRAINT [FK_Agenda_Terapeuta]
GO
/****** Object:  ForeignKey [FK_Productos_Terapeuta]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Terapeuta] FOREIGN KEY([id_Terapeuta])
REFERENCES [dbo].[Terapeuta] ([id_terapeuta])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Terapeuta]
GO
/****** Object:  ForeignKey [FK_Tipo_Tratamiento_Productos]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Tipo_Tratamiento]  WITH CHECK ADD  CONSTRAINT [FK_Tipo_Tratamiento_Productos] FOREIGN KEY([id_Producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Tipo_Tratamiento] CHECK CONSTRAINT [FK_Tipo_Tratamiento_Productos]
GO
/****** Object:  ForeignKey [FK_Turno_Estado_Turnos]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Estado_Turnos] FOREIGN KEY([id_Estado])
REFERENCES [dbo].[Estado_Turnos] ([id_Estado_Turno])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Estado_Turnos]
GO
/****** Object:  ForeignKey [FK_Turno_Paciente]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Paciente] FOREIGN KEY([id_Paciente])
REFERENCES [dbo].[Paciente] ([nro_Paciente])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Paciente]
GO
/****** Object:  ForeignKey [FK_Turno_Terapeuta]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Terapeuta] FOREIGN KEY([id_Terapeuta])
REFERENCES [dbo].[Terapeuta] ([id_terapeuta])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Terapeuta]
GO
/****** Object:  ForeignKey [FK_Turno_Tipo_Tratamiento]    Script Date: 06/04/2015 16:41:51 ******/
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Tipo_Tratamiento] FOREIGN KEY([id_TipoTratamiento])
REFERENCES [dbo].[Tipo_Tratamiento] ([id_Tipo_Tratamiento])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Tipo_Tratamiento]
GO
