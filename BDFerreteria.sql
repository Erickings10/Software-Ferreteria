USE [master]
GO
/****** Object:  Database [BaseFerreteria]    Script Date: 09/07/2024 11:54:41 ******/
CREATE DATABASE [BaseFerreteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BaseFerreteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BaseFerreteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BaseFerreteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BaseFerreteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BaseFerreteria] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BaseFerreteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BaseFerreteria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BaseFerreteria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BaseFerreteria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BaseFerreteria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BaseFerreteria] SET ARITHABORT OFF 
GO
ALTER DATABASE [BaseFerreteria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BaseFerreteria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BaseFerreteria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BaseFerreteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BaseFerreteria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BaseFerreteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BaseFerreteria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BaseFerreteria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BaseFerreteria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BaseFerreteria] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BaseFerreteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BaseFerreteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BaseFerreteria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BaseFerreteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BaseFerreteria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BaseFerreteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BaseFerreteria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BaseFerreteria] SET RECOVERY FULL 
GO
ALTER DATABASE [BaseFerreteria] SET  MULTI_USER 
GO
ALTER DATABASE [BaseFerreteria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BaseFerreteria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BaseFerreteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BaseFerreteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BaseFerreteria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BaseFerreteria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BaseFerreteria', N'ON'
GO
ALTER DATABASE [BaseFerreteria] SET QUERY_STORE = ON
GO
ALTER DATABASE [BaseFerreteria] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BaseFerreteria]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[AlmacenID] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[cantidad] [int] NULL,
	[estado] [bit] NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
	[fechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[AlmacenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoriaproducto]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoriaproducto](
	[CategoriaproductoID] [int] IDENTITY(1,1) NOT NULL,
	[desCategoria] [varchar](100) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Categoriaproducto] PRIMARY KEY CLUSTERED 
(
	[CategoriaproductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalleordencompra]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalleordencompra](
	[DetalleordencompraID] [int] IDENTITY(1,1) NOT NULL,
	[OrdencompraID] [int] NOT NULL,
	[RequerimientoID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Detalleordencompra] PRIMARY KEY CLUSTERED 
(
	[DetalleordencompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detallerequerimiento]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detallerequerimiento](
	[DetallerequerimientoID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NOT NULL,
	[RequerimientoID] [int] NOT NULL,
	[cantidad] [int] NULL,
	[prioridad] [varchar](50) NULL,
 CONSTRAINT [PK_Detallerequerimiento] PRIMARY KEY CLUSTERED 
(
	[DetallerequerimientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[DetalleVentaID] [int] IDENTITY(1,1) NOT NULL,
	[OrdenVentaID] [int] NOT NULL,
	[AlmacenID] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[PrecioVenta] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DetalleVentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcaproducto]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcaproducto](
	[MarcaproductoID] [int] IDENTITY(1,1) NOT NULL,
	[desMarca] [varchar](100) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Marcaproducto] PRIMARY KEY CLUSTERED 
(
	[MarcaproductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medidaproducto]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medidaproducto](
	[MedidaproductoID] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[prefijo] [varchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Medidaproducto] PRIMARY KEY CLUSTERED 
(
	[MedidaproductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodopago]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodopago](
	[MetodopagoID] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Metodopago] PRIMARY KEY CLUSTERED 
(
	[MetodopagoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notaentrada]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notaentrada](
	[NotaentradaID] [int] IDENTITY(1,1) NOT NULL,
	[AlmacenID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precioVenta] [decimal](10, 2) NULL,
	[descripcion] [varchar](100) NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Notaentrada] PRIMARY KEY CLUSTERED 
(
	[NotaentradaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notasalida]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notasalida](
	[NotasalidaID] [int] IDENTITY(1,1) NOT NULL,
	[AlmacenID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[cantidad] [int] NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Notasalida] PRIMARY KEY CLUSTERED 
(
	[NotasalidaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordencompra]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordencompra](
	[OrdencompraID] [int] IDENTITY(1,1) NOT NULL,
	[PagoordencompraID] [int] NOT NULL,
	[ProveedorID] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[total] [decimal](10, 2) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Ordencompra] PRIMARY KEY CLUSTERED 
(
	[OrdencompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenVenta]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenVenta](
	[OrdenVentaID] [int] IDENTITY(1,1) NOT NULL,
	[numDoc] [bigint] NOT NULL,
	[nombreCli] [varchar](70) NOT NULL,
	[medPago] [varchar](20) NOT NULL,
	[cantidad] [int] NOT NULL,
	[montoTotal] [decimal](18, 2) NOT NULL,
	[fecharegistro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrdenVentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagoordencompra]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagoordencompra](
	[MetodopagoID] [int] NOT NULL,
	[PagoordencompraID] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[monto] [decimal](10, 2) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Pagoordencompra] PRIMARY KEY CLUSTERED 
(
	[PagoordencompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaproductoID] [int] NOT NULL,
	[MarcaproductoID] [int] NOT NULL,
	[MedidaproductoID] [int] NOT NULL,
	[descripcion] [varchar](100) NULL,
	[precioCompra] [decimal](10, 2) NULL,
	[precioVenta] [decimal](10, 2) NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 09/07/2024 11:54:42 ******/
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
/****** Object:  Table [dbo].[Requerimiento]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requerimiento](
	[RequerimientoID] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Requerimiento] PRIMARY KEY CLUSTERED 
(
	[RequerimientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rubroproveedor]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rubroproveedor](
	[RubroproveedorID] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Rubroproveedor] PRIMARY KEY CLUSTERED 
(
	[RubroproveedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([AlmacenID])
REFERENCES [dbo].[Almacen] ([AlmacenID])
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([OrdenVentaID])
REFERENCES [dbo].[OrdenVenta] ([OrdenVentaID])
GO
ALTER TABLE [dbo].[Notaentrada]  WITH CHECK ADD  CONSTRAINT [FK_Notaentrada_Almacen] FOREIGN KEY([AlmacenID])
REFERENCES [dbo].[Almacen] ([AlmacenID])
GO
ALTER TABLE [dbo].[Notaentrada] CHECK CONSTRAINT [FK_Notaentrada_Almacen]
GO
ALTER TABLE [dbo].[Notaentrada]  WITH CHECK ADD  CONSTRAINT [FK_Notaentrada_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Notaentrada] CHECK CONSTRAINT [FK_Notaentrada_Producto]
GO
ALTER TABLE [dbo].[Notasalida]  WITH CHECK ADD  CONSTRAINT [FK_Notasalida_Almacen] FOREIGN KEY([AlmacenID])
REFERENCES [dbo].[Almacen] ([AlmacenID])
GO
ALTER TABLE [dbo].[Notasalida] CHECK CONSTRAINT [FK_Notasalida_Almacen]
GO
ALTER TABLE [dbo].[Notasalida]  WITH CHECK ADD  CONSTRAINT [FK_Notasalida_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Notasalida] CHECK CONSTRAINT [FK_Notasalida_Producto]
GO
ALTER TABLE [dbo].[Ordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Ordencompra_Pagoordencompra] FOREIGN KEY([PagoordencompraID])
REFERENCES [dbo].[Pagoordencompra] ([PagoordencompraID])
GO
ALTER TABLE [dbo].[Ordencompra] CHECK CONSTRAINT [FK_Ordencompra_Pagoordencompra]
GO
ALTER TABLE [dbo].[Ordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Ordencompra_Proveedor] FOREIGN KEY([ProveedorID])
REFERENCES [dbo].[Proveedor] ([ProveedorID])
GO
ALTER TABLE [dbo].[Ordencompra] CHECK CONSTRAINT [FK_Ordencompra_Proveedor]
GO
ALTER TABLE [dbo].[Pagoordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Pagoordencompra_Metodopago] FOREIGN KEY([MetodopagoID])
REFERENCES [dbo].[Metodopago] ([MetodopagoID])
GO
ALTER TABLE [dbo].[Pagoordencompra] CHECK CONSTRAINT [FK_Pagoordencompra_Metodopago]
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
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Medidaproducto] FOREIGN KEY([MedidaproductoID])
REFERENCES [dbo].[Medidaproducto] ([MedidaproductoID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Medidaproducto]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Rubroproveedor] FOREIGN KEY([RubroproveedorID])
REFERENCES [dbo].[Rubroproveedor] ([RubroproveedorID])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Rubroproveedor]
GO
/****** Object:  StoredProcedure [dbo].[spBuscarProductoPorID]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spBuscarProductoPorID]
    @ProductoID INT
AS
BEGIN
    SELECT ProductoID, CategoriaproductoID, MarcaproductoID, MedidaproductoID, 
	descripcion, precioCompra, precioVenta, fecha, estado
	from Producto
	where ProductoID = @ProductoID and estado = '1'
END;
GO
/****** Object:  StoredProcedure [dbo].[spBuscarRubro]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-------------BUSCAR RUBRO---------------*/
create proc [dbo].[spBuscarRubro](
@descripcion NVARCHAR(100)
)
as
	select RubroproveedorID,descripcion,estado
	from Rubroproveedor
	where descripcion like @descripcion + '%'
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarAlmacenes]    Script Date: 09/07/2024 11:54:42 ******/
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
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarCategoria]    Script Date: 09/07/2024 11:54:42 ******/
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
/****** Object:  StoredProcedure [dbo].[spDeshabilitarMarca]    Script Date: 09/07/2024 11:54:42 ******/
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
/****** Object:  StoredProcedure [dbo].[spDeshabilitarMedida]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spDeshabilitarMedida]
(@MedidaproductoID int
)
as
begin 
	update  Medidaproducto set 
	estado = 0
	where MedidaproductoID = @MedidaproductoID
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarProducto]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[spDeshabilitarProducto]
    @ProductoID INT
AS
BEGIN
    -- Actualiza el estado del producto a 0 (deshabilitado)
    UPDATE Producto
    SET 
        Estado = 0
    WHERE
        ProductoID = @ProductoID;
END
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarProveedor]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDeshabilitarProveedor](
@ProveedorID INT,
@estado BIT
)
as
begin
	update Proveedor set
	estado = 0
	where ProveedorID = @ProveedorID
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarRubro]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spDeshabilitarRubro](
@RubroproveedorID INT,
@estado BIT 
)
as
begin
	update Rubroproveedor set
	estado = 0
	where RubroproveedorID = @RubroproveedorID
end
GO
/****** Object:  StoredProcedure [dbo].[spEditarAlmacenes]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditarAlmacenes]
(@AlmacenID int,
@descripcion varchar(100),
@cantidad int,
@estado bit
)
as
begin 
	update  Almacen set 
	descripcion = @descripcion,
	cantidad = @cantidad,
	estado = @estado
	where AlmacenID = @AlmacenID
end
GO
/****** Object:  StoredProcedure [dbo].[spEditarCategoria]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditarCategoria]
(@CategoriaproductoID int,
@descripcion varchar(100),
@estado bit
)
as
begin 
	update  Categoriaproducto set 
	descripcion = @descripcion,
	estado = @estado
	where CategoriaproductoID = @CategoriaproductoID
end
GO
/****** Object:  StoredProcedure [dbo].[spEditarMarca]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditarMarca]
(@MarcaproductoID int,
@descripcion varchar(100),
@estado bit
)
as
begin 
	update  Marcaproducto set 
	descripcion = @descripcion,
	estado = @estado
	where MarcaproductoID = @MarcaproductoID
end
GO
/****** Object:  StoredProcedure [dbo].[spEditarMedida]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditarMedida]
(@MedidaproductoID int,
@descripcion varchar(100),
@prefijo varchar(50),
@estado bit
)
as
begin 
	update  Medidaproducto set 
	descripcion = @descripcion,
	prefijo = @prefijo,
	estado = @estado
	where MedidaproductoID = @MedidaproductoID
end
GO
/****** Object:  StoredProcedure [dbo].[spEditarProducto]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditarProducto]
    @ProductoID INT,
    @CategoriaproductoID INT,
    @MarcaproductoID INT,
    @MedidaproductoID INT,
    @Descripcion NVARCHAR(100),
    @PrecioCompra DECIMAL(10, 2),
    @PrecioVenta DECIMAL(10, 2),
    @Fecha DATETIME,
    @Estado BIT
AS
BEGIN
    -- Actualiza la información del producto en la tabla Producto
    UPDATE Producto
    SET 
        CategoriaproductoID = @CategoriaproductoID,
        MarcaproductoID = @MarcaproductoID,
        MedidaproductoID = @MedidaproductoID,
        Descripcion = @Descripcion,
        PrecioCompra = @PrecioCompra,
        PrecioVenta = @PrecioVenta,
        Fecha = @Fecha,
        Estado = @Estado
    WHERE
        ProductoID = @ProductoID;
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertarAlmacenes]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarAlmacenes]
(@descripcion varchar(100),
@cantidad int,
@estado bit
)
as
	begin
		insert into Almacen(descripcion, cantidad,estado) values
		(@descripcion, @cantidad, @estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarCategoria]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarCategoria]
(@descripcion varchar(100),
@estado bit
)
as
begin 

	insert into Categoriaproducto(descripcion,estado) values
	(@descripcion, @estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarDetalleRequerimiento]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarDetalleRequerimiento]
    @RequerimientoID int,
	@ProductoID int,
	@cantidad int,
	@prioridad varchar(50)
AS
BEGIN
    INSERT INTO Detallerequerimiento(RequerimientoID, ProductoID, cantidad, prioridad) 
    VALUES (@RequerimientoID, @ProductoID, @cantidad, @prioridad)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertarDetalleVenta]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-------------INSERTAR DETALLE VENTA---------------*/
create procedure [dbo].[spInsertarDetalleVenta]
    @OrdenVentaID int,
	@AlmacenID int,
	@cantidad int,
	@PrecioVenta decimal(18,2),
	@Total decimal(18,2)
AS
BEGIN
    INSERT INTO DetalleVenta(OrdenVentaID, AlmacenID, cantidad, PrecioVenta, Total) 
    VALUES (@OrdenVentaID, @AlmacenID, @cantidad, @PrecioVenta, @Total)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertarMarca]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarMarca]
(@descripcion varchar(100),
@estado bit
)
as
begin 

	insert into Marcaproducto(descripcion,estado) values
	(@descripcion, @estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarMedida]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarMedida]
(@descripcion varchar(100),
@prefijo varchar(50),
@estado bit
)
as
begin 
	insert into Medidaproducto(descripcion,prefijo,estado ) values
	(@descripcion, @prefijo, @estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarProductos]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spInsertarProductos]
(@CategoriaproductoID int,
@MarcaproductoID int,
@MedidaproductoID int,
@descripcion varchar(100),
@precioCompra decimal (10,2),
@precioVenta decimal (10,2),
@fecha datetime,
@estado bit
)
as
begin 
	insert into Producto(CategoriaproductoID, MarcaproductoID,MedidaproductoID, descripcion, precioCompra,precioVenta,fecha, estado) values
	(@CategoriaproductoID, @MarcaproductoID, @MedidaproductoID, @descripcion,@precioCompra, @precioVenta, @fecha, @estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarProveedor]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spInsertarProveedor](
@ruc BIGINT,
@ubigeo BIGINT,
@RubroproveedorID INT,
@correo NVARCHAR (100),
@telefono BIGINT,
@fecha DATETIME,
@estado BIT
)
as
begin
	IF(SELECT estado FROM Rubroproveedor WHERE RubroproveedorID = @RubroproveedorID) = 0
	BEGIN
		RAISERROR('El rubro esta deshabilitado',16,1);
		RETURN;
	END

	insert into Proveedor(ruc,ubigeo,RubroproveedorID,correo,telefono,fecha,estado)
	values(@ruc,@ubigeo,@RubroproveedorID,@correo,@telefono,@fecha,@estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarRubro]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spInsertarRubro](
@descripcion VARCHAR(100),
@estado BIT 
)
as
begin
	insert into Rubroproveedor(descripcion,estado)values(@descripcion,@estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarVenta]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-------------INSERTAR VENTA---------------*/
Create procedure [dbo].[spInsertarVenta]
    @medPago varchar(20),	
	@numDoc bigint,
	@nombreCli varchar(70),
	@cantidad int,
	@montoTotal decimal(18,2),
	@fecharegistro datetime,
	@OrdenVentaID int output
AS
BEGIN
    INSERT INTO OrdenVenta(medPago,numDoc, nombreCli, cantidad, montoTotal, fecharegistro) 
    VALUES (@medPago,@numDoc, @nombreCli, @cantidad, @montoTotal, @fecharegistro)

	SET @OrdenVentaID = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[spListarAlmacenes]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarAlmacenes]
as
select * from Almacen
GO
/****** Object:  StoredProcedure [dbo].[spListarCategoria]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarCategoria]
as
select * from Categoriaproducto
GO
/****** Object:  StoredProcedure [dbo].[spListarMarca]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarMarca]
as
select * from Marcaproducto
GO
/****** Object:  StoredProcedure [dbo].[spListarMedida]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarMedida]
as
select * from Medidaproducto
GO
/****** Object:  StoredProcedure [dbo].[spListarProductos]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spListarProductos]
as
begin
select 
	p.ProductoID,
	c.desCategoria,
	m.desMarca,
	md.prefijo,
	p.descripcion,
	p.precioCompra,
	p.precioVenta,
	p.fecha,
	p.estado
from Producto p
inner join Categoriaproducto c on p.CategoriaproductoID = c.CategoriaproductoID
inner join Marcaproducto m on p.MarcaproductoID = m.MarcaproductoID
inner join Medidaproducto md on p.MedidaproductoID = md.MedidaproductoID
end
GO
/****** Object:  StoredProcedure [dbo].[spListarProveedor]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spListarProveedor]
as
begin
	select p.ProveedorID,p.ruc,p.ubigeo,r.RubroproveedorID,p.correo,p.telefono,p.fecha,p.estado
	from Proveedor p
	inner join Rubroproveedor r on p.RubroproveedorID = r.RubroproveedorID
end
GO
/****** Object:  StoredProcedure [dbo].[spListarReporteCategoria]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarReporteCategoria]
as
select * from Categoriaproducto
where estado = '1'
GO
/****** Object:  StoredProcedure [dbo].[spListarReporteMarca]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarReporteMarca]
as
select * from Marcaproducto
where estado = '1'
GO
/****** Object:  StoredProcedure [dbo].[spListarReporteMedida]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarReporteMedida]
as
select * from Medidaproducto
where estado = '1'
GO
/****** Object:  StoredProcedure [dbo].[spListarRequerimiento]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarRequerimiento]
as
select * from Requerimiento
order by RequerimientoID
GO
/****** Object:  StoredProcedure [dbo].[spListarRubro]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spListarRubro]
as
begin
	select * from Rubroproveedor
end
GO
/****** Object:  StoredProcedure [dbo].[spModificarProveedor]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spModificarProveedor](
@ProveedorID INT,
@ruc BIGINT,
@ubigeo BIGINT,
@RubroproveedorID INT,
@correo NVARCHAR (100),
@telefono BIGINT,
@fecha DATE,
@estado BIT
)
as
begin
	IF(SELECT estado FROM Rubroproveedor WHERE RubroproveedorID = @RubroproveedorID) = 0
	BEGIN
		RAISERROR('El rubro esta deshabilitado',16,1);
		RETURN;
	END

	update Proveedor set
	ruc = @ruc,
	ubigeo = @ubigeo,
	RubroproveedorID = @RubroproveedorID,
	correo = @correo,
	telefono = @telefono,
	fecha = @fecha,
	estado = @estado
	where ProveedorID = @ProveedorID
end
GO
/****** Object:  StoredProcedure [dbo].[spModificarRubro]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spModificarRubro](
@RubroproveedorID INT,
@descripcion VARCHAR(100),
@estado BIT 
)
as
begin
	update Rubroproveedor set
	descripcion = @descripcion,
	estado = @estado
	where RubroproveedorID = @RubroproveedorID
end
GO
/****** Object:  StoredProcedure [dbo].[spRestarStock]    Script Date: 09/07/2024 11:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-------------RESTAR STOCK---------------*/
Create procedure [dbo].[spRestarStock]
@idAlm int,
@cant int

as
begin
	update Almacen
	set cantidad = cantidad - @cant
	where AlmacenID = @idAlm
end
GO
USE [master]
GO
ALTER DATABASE [BaseFerreteria] SET  READ_WRITE 
GO
