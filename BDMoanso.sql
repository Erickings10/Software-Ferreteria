USE [master]
GO
/****** Object:  Database [BDFerreteria]    Script Date: 29/06/2024 1:01:32 ******/
CREATE DATABASE [BDFerreteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDFerreteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BDFerreteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDFerreteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BDFerreteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BDFerreteria] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDFerreteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDFerreteria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDFerreteria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDFerreteria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDFerreteria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDFerreteria] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDFerreteria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDFerreteria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDFerreteria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDFerreteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDFerreteria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDFerreteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDFerreteria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDFerreteria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDFerreteria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDFerreteria] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDFerreteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDFerreteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDFerreteria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDFerreteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDFerreteria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDFerreteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDFerreteria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDFerreteria] SET RECOVERY FULL 
GO
ALTER DATABASE [BDFerreteria] SET  MULTI_USER 
GO
ALTER DATABASE [BDFerreteria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDFerreteria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDFerreteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDFerreteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDFerreteria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDFerreteria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDFerreteria', N'ON'
GO
ALTER DATABASE [BDFerreteria] SET QUERY_STORE = ON
GO
ALTER DATABASE [BDFerreteria] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BDFerreteria]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[AlmacenID] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](200) NULL,
	[cantidad] [bigint] NULL,
	[tipo] [varchar](100) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[AlmacenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoriaproducto]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoriaproducto](
	[categoria] [varchar](100) NULL,
	[CategoriaproductoID] [int] IDENTITY(1,1) NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Categoriaproducto] PRIMARY KEY CLUSTERED 
(
	[CategoriaproductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalleentradaproducto]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalleentradaproducto](
	[DetalleentradaproductoID] [int] IDENTITY(1,1) NOT NULL,
	[AlmacenID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[cantidad] [bigint] NULL,
	[descripcion] [varchar](200) NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Detalleentradaproducto] PRIMARY KEY CLUSTERED 
(
	[DetalleentradaproductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalleordencompra]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalleordencompra](
	[DetalleordencompraID] [int] IDENTITY(1,1) NOT NULL,
	[RequerimientoID] [int] NOT NULL,
	[OrdencompraID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[cantidad] [bigint] NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Detalleordencompra] PRIMARY KEY CLUSTERED 
(
	[DetalleordencompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detallerequerimiento]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detallerequerimiento](
	[DetallerequerimientoID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NOT NULL,
	[RequerimientoID] [int] NOT NULL,
	[cantidad] [bigint] NULL,
	[fecha] [datetime] NULL,
	[prioridad] [varchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Detallerequerimiento] PRIMARY KEY CLUSTERED 
(
	[DetallerequerimientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcaproducto]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcaproducto](
	[MarcaproductoID] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](100) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Marcaproducto] PRIMARY KEY CLUSTERED 
(
	[MarcaproductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodopago]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodopago](
	[MetodopagoID] [int] IDENTITY(1,1) NOT NULL,
	[PagofacturaID] [int] NOT NULL,
	[metodo] [varchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Metodopago] PRIMARY KEY CLUSTERED 
(
	[MetodopagoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notatransferencia]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notatransferencia](
	[NotatransferenciaID] [int] IDENTITY(1,1) NOT NULL,
	[AlmacenID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[cantidad] [bigint] NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Notatransferencia] PRIMARY KEY CLUSTERED 
(
	[NotatransferenciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordencompra]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordencompra](
	[OrdencompraID] [int] IDENTITY(1,1) NOT NULL,
	[PagofacturaID] [int] NOT NULL,
	[ProveedorID] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[direccion] [nvarchar](100) NULL,
	[telefono] [bigint] NULL,
 CONSTRAINT [PK_Ordencompra] PRIMARY KEY CLUSTERED 
(
	[OrdencompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagofactura]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagofactura](
	[PagofacturaID] [int] IDENTITY(1,1) NOT NULL,
	[monto] [bigint] NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Pagofactura] PRIMARY KEY CLUSTERED 
(
	[PagofacturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaproductoID] [int] NOT NULL,
	[MarcaproductoID] [int] NOT NULL,
	[descripcion] [varchar](100) NULL,
	[cantidad] [bigint] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ProveedorID] [int] IDENTITY(1,1) NOT NULL,
	[RubroproveedorID] [int] NOT NULL,
	[ruc] [bigint] NULL,
	[ubigeo] [bigint] NULL,
	[correo] [nvarchar](100) NULL,
	[telefono] [bigint] NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[ProveedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requerimiento]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requerimiento](
	[RequerimientoID] [int] NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Requerimiento] PRIMARY KEY CLUSTERED 
(
	[RequerimientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rubroproveedor]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rubroproveedor](
	[RubroproveedorID] [int] IDENTITY(1,1) NOT NULL,
	[rubro] [varchar](100) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Rubroproveedor] PRIMARY KEY CLUSTERED 
(
	[RubroproveedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalleentradaproducto]  WITH CHECK ADD  CONSTRAINT [FK_Detalleentradaproducto_Almacen] FOREIGN KEY([AlmacenID])
REFERENCES [dbo].[Almacen] ([AlmacenID])
GO
ALTER TABLE [dbo].[Detalleentradaproducto] CHECK CONSTRAINT [FK_Detalleentradaproducto_Almacen]
GO
ALTER TABLE [dbo].[Detalleentradaproducto]  WITH CHECK ADD  CONSTRAINT [FK_Detalleentradaproducto_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Detalleentradaproducto] CHECK CONSTRAINT [FK_Detalleentradaproducto_Producto]
GO
ALTER TABLE [dbo].[Detalleordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Detalleordencompra_Ordencompra] FOREIGN KEY([OrdencompraID])
REFERENCES [dbo].[Ordencompra] ([OrdencompraID])
GO
ALTER TABLE [dbo].[Detalleordencompra] CHECK CONSTRAINT [FK_Detalleordencompra_Ordencompra]
GO
ALTER TABLE [dbo].[Detalleordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Detalleordencompra_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Detalleordencompra] CHECK CONSTRAINT [FK_Detalleordencompra_Producto]
GO
ALTER TABLE [dbo].[Detalleordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Detalleordencompra_Requerimiento] FOREIGN KEY([RequerimientoID])
REFERENCES [dbo].[Requerimiento] ([RequerimientoID])
GO
ALTER TABLE [dbo].[Detalleordencompra] CHECK CONSTRAINT [FK_Detalleordencompra_Requerimiento]
GO
ALTER TABLE [dbo].[Detallerequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Detallerequerimiento_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Detallerequerimiento] CHECK CONSTRAINT [FK_Detallerequerimiento_Producto]
GO
ALTER TABLE [dbo].[Detallerequerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Detallerequerimiento_Requerimiento] FOREIGN KEY([RequerimientoID])
REFERENCES [dbo].[Requerimiento] ([RequerimientoID])
GO
ALTER TABLE [dbo].[Detallerequerimiento] CHECK CONSTRAINT [FK_Detallerequerimiento_Requerimiento]
GO
ALTER TABLE [dbo].[Metodopago]  WITH CHECK ADD  CONSTRAINT [FK_Metodopago_Pagofactura] FOREIGN KEY([PagofacturaID])
REFERENCES [dbo].[Pagofactura] ([PagofacturaID])
GO
ALTER TABLE [dbo].[Metodopago] CHECK CONSTRAINT [FK_Metodopago_Pagofactura]
GO
ALTER TABLE [dbo].[Notatransferencia]  WITH CHECK ADD  CONSTRAINT [FK_Notatransferencia_Almacen] FOREIGN KEY([AlmacenID])
REFERENCES [dbo].[Almacen] ([AlmacenID])
GO
ALTER TABLE [dbo].[Notatransferencia] CHECK CONSTRAINT [FK_Notatransferencia_Almacen]
GO
ALTER TABLE [dbo].[Notatransferencia]  WITH CHECK ADD  CONSTRAINT [FK_Notatransferencia_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Notatransferencia] CHECK CONSTRAINT [FK_Notatransferencia_Producto]
GO
ALTER TABLE [dbo].[Ordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Ordencompra_Pagofactura] FOREIGN KEY([PagofacturaID])
REFERENCES [dbo].[Pagofactura] ([PagofacturaID])
GO
ALTER TABLE [dbo].[Ordencompra] CHECK CONSTRAINT [FK_Ordencompra_Pagofactura]
GO
ALTER TABLE [dbo].[Ordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Ordencompra_Proveedor] FOREIGN KEY([ProveedorID])
REFERENCES [dbo].[Proveedor] ([ProveedorID])
GO
ALTER TABLE [dbo].[Ordencompra] CHECK CONSTRAINT [FK_Ordencompra_Proveedor]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoriaproducto] FOREIGN KEY([CategoriaproductoID])
REFERENCES [dbo].[Categoriaproducto] ([CategoriaproductoID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoriaproducto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Marcaproducto] FOREIGN KEY([MarcaproductoID])
REFERENCES [dbo].[Marcaproducto] ([MarcaproductoID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Marcaproducto]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Rubroproveedor] FOREIGN KEY([RubroproveedorID])
REFERENCES [dbo].[Rubroproveedor] ([RubroproveedorID])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Rubroproveedor]
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarAlmacenes]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spDeshabilitarAlmacenes]
(@AlmacenID int
)
as
begin 
	update  Almacen set 
	estado = 0
	where AlmacenID = @AlmacenID
end

-----------------------REQUERIMIENTOS-----------------
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarCategoria]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spDeshabilitarCategoria]
(@CategoriaproductoID int
)
as
begin 
	update  Categoriaproducto set 
	estado = 0
	where CategoriaproductoID = @CategoriaproductoID
end

GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarMarca]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spDeshabilitarMarca]
(@MarcaproductoID int
)
as
begin 
	update  Marcaproducto set 
	estado = 0
	where MarcaproductoID = @MarcaproductoID
end

GO
/****** Object:  StoredProcedure [dbo].[spEditarAlmacenes]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditarAlmacenes]
(@AlmacenID int,
@descripcion varchar(200),
@cantidad bigint,
@tipo varchar(100),
@estado bit
)
as
begin 
	update  Almacen set 
	descripcion = @descripcion,
	cantidad = @cantidad,
	tipo = @tipo,
	estado = @estado
	where AlmacenID = @AlmacenID
end



GO
/****** Object:  StoredProcedure [dbo].[spEditarCategoria]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditarCategoria]
(@CategoriaproductoID int,
@categoria varchar(100),
@estado bit
)
as
begin 
	update  Categoriaproducto set 
	categoria = @categoria,
	estado = @estado
	where CategoriaproductoID = @CategoriaproductoID
end

GO
/****** Object:  StoredProcedure [dbo].[spEditarMarca]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditarMarca]
(@MarcaproductoID int,
@marca varchar(100),
@estado bit
)
as
begin 
	update  Marcaproducto set 
	marca = @marca,
	estado = @estado
	where MarcaproductoID = @MarcaproductoID
end

GO
/****** Object:  StoredProcedure [dbo].[spEditarProducto]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditarProducto]
(@ProductoID int,
@CategoriaproductoID int,
@MarcaproductoID int,
@descripcion varchar(100),
@cantidad bigint,
@estado bit
)
as
begin 
	update  Producto set 
	CategoriaproductoID = @CategoriaproductoID,
	MarcaproductoID = @MarcaproductoID,
	descripcion = @descripcion,
	cantidad = @cantidad,
	estado = @estado
	where ProductoID = @ProductoID
end

GO
/****** Object:  StoredProcedure [dbo].[spInsertarAlmacenes]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarAlmacenes]
(@descripcion varchar(200),
@cantidad bigint,
@tipo varchar(100),
@estado bit
)
as
	begin
		insert into Almacen(descripcion, cantidad,tipo,estado) values
		(@descripcion, @cantidad, @tipo, @estado)
end

GO
/****** Object:  StoredProcedure [dbo].[spInsertarCategoria]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarCategoria]
(@categoria varchar(100),
@estado bit
)
as
begin 

	insert into Categoriaproducto(categoria,estado) values
	(@categoria, @estado)
end

GO
/****** Object:  StoredProcedure [dbo].[spInsertarEntradaProducto]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarEntradaProducto]
(@AlmacenID int,
@ProductoID int,
@cantidad bigint,
@descripcion varchar(200),
@fecha datetime,
@estado bit
)
as
	begin
		insert into Detalleentradaproducto(AlmacenID,ProductoID, cantidad,descripcion,fecha,estado) values
		(@AlmacenID, @ProductoID, @cantidad, @descripcion, @fecha, @estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarMarca]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarMarca]
(@marca varchar(100),
@estado bit
)
as
begin 

	insert into Marcaproducto(marca,estado) values
	(@marca, @estado)
end

GO
/****** Object:  StoredProcedure [dbo].[spInsertarProductos]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarProductos]
(@CategoriaproductoID int,
@MarcaproductoID int,
@descripcion varchar(100),
@cantidad bigint,
@estado bit
)
as
begin 
	insert into Producto(CategoriaproductoID, MarcaproductoID, descripcion, cantidad, estado) values
	(@CategoriaproductoID, @MarcaproductoID, @descripcion, @cantidad, @estado)
end



GO
/****** Object:  StoredProcedure [dbo].[spListarAlmacenes]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarAlmacenes]
as
select * from Almacen

GO
/****** Object:  StoredProcedure [dbo].[spListarCategoria]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarCategoria]
as
select * from Categoriaproducto

GO
/****** Object:  StoredProcedure [dbo].[spListarEntradaProducto]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarEntradaProducto]
as
select * from Detalleentradaproducto
GO
/****** Object:  StoredProcedure [dbo].[spListarMarca]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarMarca]
as
select * from Marcaproducto

GO
/****** Object:  StoredProcedure [dbo].[spListarProductos]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarProductos]
as
begin
select 
	p.ProductoID,
	c.categoria,
	m.marca,
	p.descripcion,
	p.cantidad,
	p.estado
from Producto p
inner join Categoriaproducto c on p.CategoriaproductoID = c.CategoriaproductoID
inner join Marcaproducto m on p.MarcaproductoID = m.MarcaproductoID
end


GO
/****** Object:  StoredProcedure [dbo].[spListarReporteCategoria]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarReporteCategoria]
as
select * from Categoriaproducto
where estado = '1'

-------------------------------------------------------------------

select * from Producto

GO
/****** Object:  StoredProcedure [dbo].[spListarReporteMarca]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarReporteMarca]
as
select * from Marcaproducto
where estado = '1'

-----------------------------------------------------------------
select * from Categoriaproducto

GO
/****** Object:  StoredProcedure [dbo].[spListarReporteProductos]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarReporteProductos]
as
begin
	select 
		p.ProductoID,
		c.categoria,
		m.marca,
		p.descripcion,
		p.cantidad,
		p.estado
	from Producto p
	inner join Categoriaproducto c on p.CategoriaproductoID = c.CategoriaproductoID
	inner join Marcaproducto m on p.MarcaproductoID = m.MarcaproductoID
	where p.estado = '1'
end
GO
/****** Object:  StoredProcedure [dbo].[spListarRequerimientos]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarRequerimientos]
as
select * from Detallerequerimiento
	where estado = '1'

select * from Requerimiento
GO
/****** Object:  StoredProcedure [dbo].[spObtenerProductoPorID]    Script Date: 29/06/2024 1:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[spObtenerProductoPorID]
    @ProductoID INT
AS
BEGIN
    SELECT 
        MarcaProductoID, 
        CategoriaProductoID
    FROM 
        Productos
    WHERE 
        ProductoID = @ProductoID;
END

GO
USE [master]
GO
ALTER DATABASE [BDFerreteria] SET  READ_WRITE 
GO
