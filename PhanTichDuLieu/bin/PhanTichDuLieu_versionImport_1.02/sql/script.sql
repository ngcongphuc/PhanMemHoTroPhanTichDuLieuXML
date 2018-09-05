USE [master]
GO
/****** Object:  Database [DB2018]    Script Date: 09/07/2018 4:23:54 PM ******/
CREATE DATABASE [DB2018]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB2018', FILENAME = N'D:\DataSQL\DB2018.mdf' , SIZE = 375040KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB2018_log', FILENAME = N'D:\DataSQL\DM2018_log.ldf' , SIZE = 32448KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB2018] ADD FILEGROUP [Second]
GO
ALTER DATABASE [DB2018] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB2018].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB2018] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB2018] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB2018] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB2018] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB2018] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB2018] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB2018] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB2018] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB2018] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB2018] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB2018] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB2018] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB2018] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB2018] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB2018] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB2018] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB2018] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB2018] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB2018] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB2018] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB2018] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB2018] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB2018] SET RECOVERY FULL 
GO
ALTER DATABASE [DB2018] SET  MULTI_USER 
GO
ALTER DATABASE [DB2018] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB2018] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB2018] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB2018] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB2018] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DB2018]
GO
/****** Object:  UserDefinedTableType [dbo].[tenType]    Script Date: 09/07/2018 4:23:54 PM ******/
CREATE TYPE [dbo].[tenType] AS TABLE(
	[ID] [numeric](18, 0) NULL,
	[XML1_ID] [numeric](18, 0) NULL,
	[Ky_QT] [numeric](10, 0) NULL,
	[CoSoKCB_ID] [numeric](18, 0) NULL,
	[Ma_CSKCB] [nvarchar](10) NULL,
	[Ma_LK] [nvarchar](100) NULL,
	[MA_BN] [nvarchar](100) NULL,
	[Ho_Ten] [nvarchar](100) NULL,
	[Ngay_Sinh] [nvarchar](15) NULL,
	[Gioi_Tinh] [nvarchar](2) NULL,
	[Ma_The] [nvarchar](20) NULL,
	[Ma_DKBD] [nvarchar](10) NULL,
	[Ngay_Vao] [nvarchar](25) NULL,
	[Ngay_Ra] [nvarchar](25) NULL,
	[So_Ngay_DTri] [numeric](10, 0) NULL,
	[Ma_LyDo_VVien] [nvarchar](2) NULL,
	[Ma_Benh] [nvarchar](100) NULL,
	[Ma_BenhKhac] [nvarchar](1000) NULL,
	[T_TongChi] [numeric](18, 0) NULL,
	[T_BNTT] [numeric](18, 0) NULL,
	[T_BHTT] [numeric](18, 0) NULL,
	[T_XN] [numeric](18, 0) NULL,
	[T_CDHA] [numeric](18, 0) NULL,
	[T_Thuoc] [numeric](18, 0) NULL,
	[T_Mau] [numeric](18, 0) NULL,
	[T_TTPT] [numeric](18, 0) NULL,
	[T_VTYT] [numeric](18, 0) NULL,
	[T_DVKT_TyLe] [numeric](18, 0) NULL,
	[T_Thuoc_TyLe] [numeric](18, 0) NULL,
	[T_VTYT_TyLe] [numeric](18, 0) NULL,
	[T_Kham] [numeric](18, 0) NULL,
	[T_Giuong] [numeric](18, 0) NULL,
	[T_VChuyen] [numeric](18, 0) NULL,
	[T_NgoaiDS] [numeric](18, 0) NULL,
	[T_NguonKhac] [numeric](18, 0) NULL,
	[Ma_Loai_KCB] [nvarchar](2) NULL,
	[ID_CP] [numeric](18, 0) NULL,
	[Loai_CP] [nvarchar](10) NULL,
	[Ma_CP] [nvarchar](40) NULL,
	[Ma_Vat_Tu] [nvarchar](40) NULL,
	[Ma_Nhom] [nvarchar](3) NULL,
	[Ten_CP] [nvarchar](100) NULL,
	[DVT] [nvarchar](100) NULL,
	[So_Dang_Ky] [nvarchar](100) NULL,
	[Ham_Luong] [nvarchar](100) NULL,
	[Duong_Dung] [nvarchar](100) NULL,
	[So_Luong] [numeric](18, 2) NULL,
	[So_Luong_BV] [numeric](18, 2) NULL,
	[Don_Gia] [numeric](18, 2) NULL,
	[Don_Gia_BV] [numeric](18, 2) NULL,
	[Thanh_Tien] [numeric](18, 2) NULL,
	[TyLe_TT] [numeric](18, 2) NULL,
	[Ngay_YL] [nvarchar](25) NULL,
	[Ten_Khoa] [nvarchar](100) NULL,
	[Ma_Khoa] [nvarchar](20) NULL,
	[Ma_Khoa_XML1] [nvarchar](20) NULL,
	[Ten_Khoa_XML1] [nvarchar](100) NULL,
	[Ten_Benh] [nvarchar](100) NULL,
	[Ma_Bac_Si] [nvarchar](20) NULL,
	[Ma_Tinh] [nvarchar](5) NULL,
	[Ma_Tinh_The] [nvarchar](5) NULL,
	[GT_The_Tu] [nvarchar](25) NULL,
	[GT_The_Den] [nvarchar](25) NULL,
	[Mien_Cung_CT] [numeric](18, 0) NULL,
	[Muc_Huong_XML1] [numeric](10, 0) NULL,
	[T_BNCCT] [numeric](18, 2) NULL,
	[Ngay_KQ] [nvarchar](25) NULL,
	[T_NguonKhac_DTL] [numeric](18, 2) NULL,
	[T_BNTT_DTL] [numeric](18, 2) NULL,
	[T_BHTT_DTL] [numeric](18, 2) NULL,
	[T_BNCCT_DTL] [numeric](18, 2) NULL,
	[T_NgoaiDS_DTL] [numeric](18, 2) NULL,
	[Muc_Huong_DTL] [numeric](18, 2) NULL,
	[TT_Thau] [nvarchar](100) NULL,
	[Pham_Vi] [nvarchar](100) NULL,
	[Ma_Giuong] [nvarchar](50) NULL,
	[T_TranTT] [numeric](18, 2) NULL,
	[Goi_VTYT] [nvarchar](100) NULL,
	[Ten_Vat_Tu] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[udt_xml123_67021]    Script Date: 09/07/2018 4:23:54 PM ******/
CREATE TYPE [dbo].[udt_xml123_67021] AS TABLE(
	[ID] [nvarchar](max) NULL,
	[XML1_ID] [nvarchar](max) NULL,
	[Ky_QT] [nvarchar](max) NULL,
	[CoSoKCB_ID] [nvarchar](max) NULL,
	[Ma_CSKCB] [nvarchar](max) NULL,
	[Ma_LK] [nvarchar](max) NULL,
	[MA_BN] [nvarchar](max) NULL,
	[Ho_Ten] [nvarchar](max) NULL,
	[Ngay_Sinh] [nvarchar](max) NULL,
	[Gioi_Tinh] [nvarchar](max) NULL,
	[Ma_The] [nvarchar](max) NULL,
	[Ma_DKBD] [nvarchar](max) NULL,
	[GT_The_Tu] [nvarchar](max) NULL,
	[GT_The_Den] [nvarchar](max) NULL,
	[Mien_Cung_CT] [nvarchar](max) NULL,
	[Ngay_Vao] [nvarchar](max) NULL,
	[Ngay_Ra] [nvarchar](max) NULL,
	[So_Ngay_DTri] [nvarchar](max) NULL,
	[Ma_LyDo_VVien] [nvarchar](max) NULL,
	[Ma_Benh] [nvarchar](max) NULL,
	[Ma_BenhKhac] [nvarchar](max) NULL,
	[Muc_Huong_XML1] [nvarchar](max) NULL,
	[T_TongChi] [nvarchar](max) NULL,
	[T_BNTT] [nvarchar](max) NULL,
	[T_BHTT] [nvarchar](max) NULL,
	[T_BNCCT] [nvarchar](max) NULL,
	[T_XN] [nvarchar](max) NULL,
	[T_CDHA] [nvarchar](max) NULL,
	[T_Thuoc] [nvarchar](max) NULL,
	[T_Mau] [nvarchar](max) NULL,
	[T_TTPT] [nvarchar](max) NULL,
	[T_VTYT] [nvarchar](max) NULL,
	[T_DVKT_TyLe] [nvarchar](max) NULL,
	[T_Thuoc_TyLe] [nvarchar](max) NULL,
	[T_VTYT_TyLe] [nvarchar](max) NULL,
	[T_Kham] [nvarchar](max) NULL,
	[T_Giuong] [nvarchar](max) NULL,
	[T_VChuyen] [nvarchar](max) NULL,
	[T_NgoaiDS] [nvarchar](max) NULL,
	[T_NguonKhac] [nvarchar](max) NULL,
	[Ma_Loai_KCB] [nvarchar](max) NULL,
	[ID_CP] [nvarchar](max) NULL,
	[Loai_CP] [nvarchar](max) NULL,
	[Ma_CP] [nvarchar](max) NULL,
	[Ma_Vat_Tu] [nvarchar](max) NULL,
	[Ma_Nhom] [nvarchar](max) NULL,
	[Ten_CP] [nvarchar](max) NULL,
	[DVT] [nvarchar](max) NULL,
	[So_Dang_Ky] [nvarchar](max) NULL,
	[Ham_Luong] [nvarchar](max) NULL,
	[Duong_Dung] [nvarchar](max) NULL,
	[So_Luong] [nvarchar](max) NULL,
	[So_Luong_BV] [nvarchar](max) NULL,
	[Don_Gia] [nvarchar](max) NULL,
	[Don_Gia_BV] [nvarchar](max) NULL,
	[Thanh_Tien] [nvarchar](max) NULL,
	[TyLe_TT] [nvarchar](max) NULL,
	[Ngay_YL] [nvarchar](max) NULL,
	[Ngay_KQ] [nvarchar](max) NULL,
	[T_NguonKhac_DTL] [nvarchar](max) NULL,
	[T_BNTT_DTL] [nvarchar](max) NULL,
	[T_BHTT_DTL] [nvarchar](max) NULL,
	[T_BNCCT_DTL] [nvarchar](max) NULL,
	[T_NgoaiDS_DTL] [nvarchar](max) NULL,
	[Muc_Huong_DTL] [nvarchar](max) NULL,
	[TT_Thau] [nvarchar](max) NULL,
	[Pham_Vi] [nvarchar](max) NULL,
	[Ma_Giuong] [nvarchar](max) NULL,
	[T_TranTT] [nvarchar](max) NULL,
	[Goi_VTYT] [nvarchar](max) NULL,
	[Ten_Vat_Tu] [nvarchar](max) NULL,
	[Ten_Khoa] [nvarchar](max) NULL,
	[Ma_Khoa] [nvarchar](max) NULL,
	[Ma_Khoa_XML1] [nvarchar](max) NULL,
	[Ten_Khoa_XML1] [nvarchar](max) NULL,
	[Ten_Benh] [nvarchar](max) NULL,
	[Ma_Bac_Si] [nvarchar](max) NULL,
	[Ma_Tinh] [nvarchar](max) NULL,
	[Ma_Tinh_The] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[udt_xml123_67024]    Script Date: 09/07/2018 4:23:54 PM ******/
CREATE TYPE [dbo].[udt_xml123_67024] AS TABLE(
	[ID] [nvarchar](max) NULL,
	[XML1_ID] [nvarchar](max) NULL,
	[Ky_QT] [nvarchar](max) NULL,
	[CoSoKCB_ID] [nvarchar](max) NULL,
	[Ma_CSKCB] [nvarchar](max) NULL,
	[Ma_LK] [nvarchar](max) NULL,
	[MA_BN] [nvarchar](max) NULL,
	[Ho_Ten] [nvarchar](max) NULL,
	[Ngay_Sinh] [nvarchar](max) NULL,
	[Gioi_Tinh] [nvarchar](max) NULL,
	[Ma_The] [nvarchar](max) NULL,
	[Ma_DKBD] [nvarchar](max) NULL,
	[GT_The_Tu] [nvarchar](max) NULL,
	[GT_The_Den] [nvarchar](max) NULL,
	[Mien_Cung_CT] [nvarchar](max) NULL,
	[Ngay_Vao] [nvarchar](max) NULL,
	[Ngay_Ra] [nvarchar](max) NULL,
	[So_Ngay_DTri] [nvarchar](max) NULL,
	[Ma_LyDo_VVien] [nvarchar](max) NULL,
	[Ma_Benh] [nvarchar](max) NULL,
	[Ma_BenhKhac] [nvarchar](max) NULL,
	[Muc_Huong_XML1] [nvarchar](max) NULL,
	[T_TongChi] [nvarchar](max) NULL,
	[T_BNTT] [nvarchar](max) NULL,
	[T_BHTT] [nvarchar](max) NULL,
	[T_BNCCT] [nvarchar](max) NULL,
	[T_XN] [nvarchar](max) NULL,
	[T_CDHA] [nvarchar](max) NULL,
	[T_Thuoc] [nvarchar](max) NULL,
	[T_Mau] [nvarchar](max) NULL,
	[T_TTPT] [nvarchar](max) NULL,
	[T_VTYT] [nvarchar](max) NULL,
	[T_DVKT_TyLe] [nvarchar](max) NULL,
	[T_Thuoc_TyLe] [nvarchar](max) NULL,
	[T_VTYT_TyLe] [nvarchar](max) NULL,
	[T_Kham] [nvarchar](max) NULL,
	[T_Giuong] [nvarchar](max) NULL,
	[T_VChuyen] [nvarchar](max) NULL,
	[T_NgoaiDS] [nvarchar](max) NULL,
	[T_NguonKhac] [nvarchar](max) NULL,
	[Ma_Loai_KCB] [nvarchar](max) NULL,
	[ID_CP] [nvarchar](max) NULL,
	[Loai_CP] [nvarchar](max) NULL,
	[Ma_CP] [nvarchar](max) NULL,
	[Ma_Vat_Tu] [nvarchar](max) NULL,
	[Ma_Nhom] [nvarchar](max) NULL,
	[Ten_CP] [nvarchar](max) NULL,
	[DVT] [nvarchar](max) NULL,
	[So_Dang_Ky] [nvarchar](max) NULL,
	[Ham_Luong] [nvarchar](max) NULL,
	[Duong_Dung] [nvarchar](max) NULL,
	[So_Luong] [nvarchar](max) NULL,
	[So_Luong_BV] [nvarchar](max) NULL,
	[Don_Gia] [nvarchar](max) NULL,
	[Don_Gia_BV] [nvarchar](max) NULL,
	[Thanh_Tien] [nvarchar](max) NULL,
	[TyLe_TT] [nvarchar](max) NULL,
	[Ngay_YL] [nvarchar](max) NULL,
	[Ngay_KQ] [nvarchar](max) NULL,
	[T_NguonKhac_DTL] [nvarchar](max) NULL,
	[T_BNTT_DTL] [nvarchar](max) NULL,
	[T_BHTT_DTL] [nvarchar](max) NULL,
	[T_BNCCT_DTL] [nvarchar](max) NULL,
	[T_NgoaiDS_DTL] [nvarchar](max) NULL,
	[Muc_Huong_DTL] [nvarchar](max) NULL,
	[TT_Thau] [nvarchar](max) NULL,
	[Pham_Vi] [nvarchar](max) NULL,
	[Ma_Giuong] [nvarchar](max) NULL,
	[T_TranTT] [nvarchar](max) NULL,
	[Goi_VTYT] [nvarchar](max) NULL,
	[Ten_Vat_Tu] [nvarchar](max) NULL,
	[Ten_Khoa] [nvarchar](max) NULL,
	[Ma_Khoa] [nvarchar](max) NULL,
	[Ma_Khoa_XML1] [nvarchar](max) NULL,
	[Ten_Khoa_XML1] [nvarchar](max) NULL,
	[Ten_Benh] [nvarchar](max) NULL,
	[Ma_Bac_Si] [nvarchar](max) NULL,
	[Ma_Tinh] [nvarchar](max) NULL,
	[Ma_Tinh_The] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[udt_xml123_67025]    Script Date: 09/07/2018 4:23:54 PM ******/
CREATE TYPE [dbo].[udt_xml123_67025] AS TABLE(
	[ID] [nvarchar](max) NULL,
	[XML1_ID] [nvarchar](max) NULL,
	[Ky_QT] [nvarchar](max) NULL,
	[CoSoKCB_ID] [nvarchar](max) NULL,
	[Ma_CSKCB] [nvarchar](max) NULL,
	[Ma_LK] [nvarchar](max) NULL,
	[MA_BN] [nvarchar](max) NULL,
	[Ho_Ten] [nvarchar](max) NULL,
	[Ngay_Sinh] [nvarchar](max) NULL,
	[Gioi_Tinh] [nvarchar](max) NULL,
	[Ma_The] [nvarchar](max) NULL,
	[Ma_DKBD] [nvarchar](max) NULL,
	[GT_The_Tu] [nvarchar](max) NULL,
	[GT_The_Den] [nvarchar](max) NULL,
	[Mien_Cung_CT] [nvarchar](max) NULL,
	[Ngay_Vao] [nvarchar](max) NULL,
	[Ngay_Ra] [nvarchar](max) NULL,
	[So_Ngay_DTri] [nvarchar](max) NULL,
	[Ma_LyDo_VVien] [nvarchar](max) NULL,
	[Ma_Benh] [nvarchar](max) NULL,
	[Ma_BenhKhac] [nvarchar](max) NULL,
	[Muc_Huong_XML1] [nvarchar](max) NULL,
	[T_TongChi] [nvarchar](max) NULL,
	[T_BNTT] [nvarchar](max) NULL,
	[T_BHTT] [nvarchar](max) NULL,
	[T_BNCCT] [nvarchar](max) NULL,
	[T_XN] [nvarchar](max) NULL,
	[T_CDHA] [nvarchar](max) NULL,
	[T_Thuoc] [nvarchar](max) NULL,
	[T_Mau] [nvarchar](max) NULL,
	[T_TTPT] [nvarchar](max) NULL,
	[T_VTYT] [nvarchar](max) NULL,
	[T_DVKT_TyLe] [nvarchar](max) NULL,
	[T_Thuoc_TyLe] [nvarchar](max) NULL,
	[T_VTYT_TyLe] [nvarchar](max) NULL,
	[T_Kham] [nvarchar](max) NULL,
	[T_Giuong] [nvarchar](max) NULL,
	[T_VChuyen] [nvarchar](max) NULL,
	[T_NgoaiDS] [nvarchar](max) NULL,
	[T_NguonKhac] [nvarchar](max) NULL,
	[Ma_Loai_KCB] [nvarchar](max) NULL,
	[ID_CP] [nvarchar](max) NULL,
	[Loai_CP] [nvarchar](max) NULL,
	[Ma_CP] [nvarchar](max) NULL,
	[Ma_Vat_Tu] [nvarchar](max) NULL,
	[Ma_Nhom] [nvarchar](max) NULL,
	[Ten_CP] [nvarchar](max) NULL,
	[DVT] [nvarchar](max) NULL,
	[So_Dang_Ky] [nvarchar](max) NULL,
	[Ham_Luong] [nvarchar](max) NULL,
	[Duong_Dung] [nvarchar](max) NULL,
	[So_Luong] [nvarchar](max) NULL,
	[So_Luong_BV] [nvarchar](max) NULL,
	[Don_Gia] [nvarchar](max) NULL,
	[Don_Gia_BV] [nvarchar](max) NULL,
	[Thanh_Tien] [nvarchar](max) NULL,
	[TyLe_TT] [nvarchar](max) NULL,
	[Ngay_YL] [nvarchar](max) NULL,
	[Ngay_KQ] [nvarchar](max) NULL,
	[T_NguonKhac_DTL] [nvarchar](max) NULL,
	[T_BNTT_DTL] [nvarchar](max) NULL,
	[T_BHTT_DTL] [nvarchar](max) NULL,
	[T_BNCCT_DTL] [nvarchar](max) NULL,
	[T_NgoaiDS_DTL] [nvarchar](max) NULL,
	[Muc_Huong_DTL] [nvarchar](max) NULL,
	[TT_Thau] [nvarchar](max) NULL,
	[Pham_Vi] [nvarchar](max) NULL,
	[Ma_Giuong] [nvarchar](max) NULL,
	[T_TranTT] [nvarchar](max) NULL,
	[Goi_VTYT] [nvarchar](max) NULL,
	[Ten_Vat_Tu] [nvarchar](max) NULL,
	[Ten_Khoa] [nvarchar](max) NULL,
	[Ma_Khoa] [nvarchar](max) NULL,
	[Ma_Khoa_XML1] [nvarchar](max) NULL,
	[Ten_Khoa_XML1] [nvarchar](max) NULL,
	[Ten_Benh] [nvarchar](max) NULL,
	[Ma_Bac_Si] [nvarchar](max) NULL,
	[Ma_Tinh] [nvarchar](max) NULL,
	[Ma_Tinh_The] [nvarchar](max) NULL
)
GO
/****** Object:  Table [dbo].[DanhMucCoSoKCB]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucCoSoKCB](
	[MaCSKCB] [nvarchar](50) NULL,
	[TenCSKCB] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucDieuKienDichVu]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucDieuKienDichVu](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL,
 CONSTRAINT [PK_DMDVCoDK] PRIMARY KEY CLUSTERED 
(
	[MaDieuKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMucDieuKienThuoc]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucDieuKienThuoc](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL,
 CONSTRAINT [PK_DanhMucDieuKienThuoc] PRIMARY KEY CLUSTERED 
(
	[MaDieuKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dmmau19]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmmau19](
	[MaCSKCB] [nvarchar](50) NULL,
	[TenCSKCB] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dmmau20]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmmau20](
	[MaCSKCB] [nvarchar](50) NULL,
	[TenCSKCB] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dmmau21]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmmau21](
	[MaCSKCB] [nvarchar](50) NULL,
	[TenCSKCB] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dmmau7980]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmmau7980](
	[MaCSKCB] [nvarchar](50) NULL,
	[TenCSKCB] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[DanhMucCoSoKCB] ([MaCSKCB], [TenCSKCB]) VALUES (N'67012', N'Bệnh Viện Đa kHoa Đăk MIl rsd ỷ ỷ')
INSERT [dbo].[DanhMucCoSoKCB] ([MaCSKCB], [TenCSKCB]) VALUES (N'67013', N'Bệnh Viện Đa kHoa Cư juit')
INSERT [dbo].[DanhMucCoSoKCB] ([MaCSKCB], [TenCSKCB]) VALUES (N'67021', N'BV test 1')
INSERT [dbo].[DanhMucCoSoKCB] ([MaCSKCB], [TenCSKCB]) VALUES (N'67024', N'BV test2 43 6e5r 67tfu fyi')
INSERT [dbo].[DanhMucCoSoKCB] ([MaCSKCB], [TenCSKCB]) VALUES (N'67025', N'BV Đa Khoa Tuy ĐỨc')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N' CA 15-3 (TT35)', N'ĐỊNH LƯỢNG CA 15-3 không phải Ung thư vú (TT35)', N'ma_cp in (''23.0034.1469'') and substring (ma_benh,1,3) not like ''%D05%'' and substring (ma_benhkhac,1,3) not like ''%D05%'' and substring (ma_benh,1,3) not like ''%C50%'' and substring (ma_benhkhac,1,3) not like ''%C50%''')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N' CA 19 - 9 (TT35)', N'Định lượng CA 19-9:  không phải chẩn đoán ung thư Tụy, đường mật (TT35)', N' ma_cp in (''23.0033.1470'') and substring(ma_benh,1,3) not like (''%C25%'') and substring(ma_benhkhac,1,3) not like (''%C25%'') and substring(ma_benh,1,3) not like (''%C24%'') and substring(ma_benhkhac,1,3) not like (''%C24%'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N' CA 72-4 (TT35)', N'ĐỊNH LƯỢNG CA 72-4 không phải Ung thư dạ dày (TT35)', N'ma_cp in (''23.0035.1471'') and substring (ma_benh,1,3) not like ''%D00%'' and substring (ma_benhkhac,1,3) not like ''%D00%'' and substring (ma_benh,1,3) not like ''%C16%'' and ma_cp in (''23.0035.1471'') and substring (ma_benh,1,3) not like ''%D00%'' and substring (ma_benhkhac,1,3) not like ''%D00%'' and ma_benh not like ''%C16%'' and ma_benhkhac not like ''%C16%''')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'< 4h', N'Danh sách BN điều trị nội trú nằm viện < 4h không thanh toán tiền giường', N'cast((cast(NGAY_RA as datetime) - cast(NGAY_vao as datetime)) as numeric(18,3))*24 <4 and t_giuong >0 and LOAI_CP = ''xml3'' and ma_nhom in (''14'',''15'') and cast(SUBSTRING(ngay_ra,12,2) as integer) - cast(SUBSTRING(ngay_vao,12,2) as integer) < 4')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'> 4h', N'Danh sách BN điều trị nội trú cấp cứu nằm viện > 4h không thanh toán tiền khám', N'cast(cast(ngay_ra as DATETime)- cast(ngay_vao as DATETime) as numeric(18,2))*24  between 4 and 20 and T_Giuong > 0 and ma_nhom = 13 AND MA_LYDO_VVIEN =''2''')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'BNP', N'Định lượng BNP không phải mã bệnh I12, I13, I15, N17, N19, N18', N'Ma_CP IN(''23.0028.1466'') AND (MA_BENH NOT LIKE ''%I12%'' AND MA_BENHKHAC NOT LIKE ''%I12%'' AND MA_BENH NOT LIKE ''%I13%'' AND MA_BENHKHAC NOT LIKE ''%I13%'' AND MA_BENH NOT LIKE ''%I15%'' AND MA_BENHKHAC NOT LIKE ''%I15%'' AND MA_BENH NOT LIKE ''%I17%'' AND MA_BENHKHAC NOT LIKE ''%I17%'' AND MA_BENH NOT LIKE ''%I18%'' AND MA_BENHKHAC NOT LIKE ''%I18%'' AND MA_BENH NOT LIKE ''%I19%'' AND MA_BENHKHAC NOT LIKE ''%I19%'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CA 125 (TT35)', N'ĐỊNH LƯỢNG CA 125 không phải Ung thư buồng trứng (TT35)', N'ma_cp in (''23.0032.1468'') and ma_benh not like (''%C56%'') and ma_benhkhac not like(''%C56%'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CATTU', N'Phẫu thuật mở bụng cắt u buồng trứng hoặc cắt phần phụ cùng Phẫu thuật mở bụng cắt tử cung hoàn toàn', N'Ma_CP IN(''13.0068.0681'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CRP Hs', N'Định lượng CRP hs: Bệnh mạch vành hoặc nhồi máu cơ tim (tt35)', N'ma_cp in(''23.0050.1484'',''23.0130.1483'',''23.9000.1483'') and ma_benh not in(''I24.0'',''I25.0'',''I25.4'',''A52.06'',''Q24.5'',''T82.2'',''Z95.5'',''Y52.3'',''R93.1'',''T46.3'',''Z03.4'',''I21'',''I21.0'',''I21.1'',''I21.3'',''I21.4'',''I21.9'',''I22'',''I22.0'',''I22.1'',''I22.8'',''I22.9'',''I25.2'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.03', N'Cắt nang răng đường kính dưới 2 cm chỉ thanh toán 429.000', N'Ma_CP IN(''12.0070.1039'',''03.2537.1047'') AND Don_Gia_BV > 429000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.04', N'Cắt túi thừa tá tràng chỉ thanh toán 2.460.000', N'Ma_CP IN(''03.3290.0456'',''10.0476.0459'') AND Don_Gia_BV > 2460000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.05', N'Cắt u kết mạc, giác mạc có ghép kết mạc, màng ối hoặc giác mạc chỉ thanh toán 804.000', N'Ma_CP IN(''14.0089.0736'',''12.0108.0824'') AND Don_Gia_BV > 804000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.06', N'Cắt u mỡ, u bã đậu vùng hàm mặt đường kính dưới  5 cm chỉ thanh toán 1.314.000', N'Ma_CP IN(''12.0092.0909'',''03.2535.1049'') AND Don_Gia_BV > 1314000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.07', N'Cắt u mỡ, u bã đậu vùng hàm mặt đường kính trên 5 cm chỉ thanh toán 1.314.000', N'Ma_CP IN(''12.0091.0909'',''03.2532.1049'') AND Don_Gia_BV > 1314000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.08', N'Cắt u tuyến nước bọt dưới hàm chỉ thanh toán 3.043.000', N'Ma_CP IN(''12.0086.0944'',''12.0086.1060'') AND Don_Gia_BV > 3043000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.09', N'Cắt u tuyến nước bọt dưới lưỡi chỉ thanh toán 3.043.000', N'Ma_CP IN(''12.0087.0944'',''12.0087.1060'') AND Don_Gia_BV > 3043000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.10', N'Cắt u tuyến nước bọt phụ chỉ thanh toán 3.043.000', N'Ma_CP IN(''12.0088.0944'',''12.0088.1060'') AND Don_Gia_BV > 3043000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.11', N'Cắt, nạo vét hạch cổ tiệt căn chỉ thanh toán 3.629.000', N'Ma_CP IN(''12.0154.0915'',''12.0154.0488'',''03.2581.0915'') AND Don_Gia_BV > 3629000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.12', N'Chọc hút dịch khí phế quản qua màng nhẫn giáp chỉ thanh toán 136.000', N'Ma_CP IN(''03.0098.0079'',''01.0091.0071'') AND Don_Gia_BV > 136000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.13', N'Chọc hút dịch, khí trung thất chỉ thanh toán 136.000', N'Ma_CP IN(''01.0098.0079'',''03.0061.0297'') AND Don_Gia_BV > 136000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.14', N'Chuyển ngón có cuống mạch nuôi chỉ thanh toán 4.675.000', N'Ma_CP IN(''03.3709.0578'',''28.0350.0552'') AND Don_Gia_BV > 4675000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.15', N'Đặt catheter động mạch chỉ thanh toán 533.000', N'Ma_CP IN(''01.0009.0098'',''03.0033.0097'') AND Don_Gia_BV > 533000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.16', N'Đo tỷ trọng dịch chọc dò chỉ thanh toán 4.700', N'Ma_CP IN(''23.0222.1596'',''23.0222.1597'') AND Don_Gia_BV > 4700')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.17', N'Ghi điện tim cấp cứu tại giường chỉ thanh toán 45.900', N'Ma_CP IN(''01.0002.1778'',''03.0044.0300'') AND Don_Gia_BV > 45900')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.18', N'Khâu củng mạc chỉ thanh toán 800.000', N'Ma_CP IN(''14.0177.0767'',''03.1668.0766'',''14.0177.0765'') AND Don_Gia_BV > 800000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.19', N'Làm lại thành âm đạo, tầng sinh môn chỉ thanh toán 1.373.000', N'Ma_CP IN(''13.0150.0724'',''03.2264.0669'') AND Don_Gia_BV > 1373000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.20', N'Laser điều trị bệnh lý võng mạc sơ sinh (ROP) chỉ thanh toán 393.000', N'Ma_CP IN(''13.0182.0749'',''13.0182.0749'',''13.0182.0814'') AND Don_Gia_BV > 393000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.21', N'Lấy sỏi bàng quang lần 2, đóng lỗ rò bàng quang chỉ thanh toán 2.619.000 ', N'Ma_CP IN(''03.3517.0421'',''10.0342.0582'') AND Don_Gia_BV > 2619000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.22', N'Nạo vét hạch cổ chọn lọc chỉ thanh toán 3.629.000', N'Ma_CP IN(''15.0280.0488'',''15.0280.0915'') AND Don_Gia_BV > 3629000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.23', N'Nối niệu quản - đài thận chỉ thanh toán 2.950.000', N'Ma_CP IN(''03.3490.0422'',''10.0323.0423'') AND Don_Gia_BV > 2950000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.24', N'Nội soi bàng quang chỉ thanh toán 506.000', N'Ma_CP IN(''02.0221.0150'',''03.1078.0148'') AND Don_Gia_BV > 506000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.25', N'Phẫu thuật cắt u cơ hoành 2.619.000', N'Ma_CP IN(''10.0695.0492'',''10.0695.0582'') AND Don_Gia_BV > 2619000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.26', N'Phẫu thuật điều trị thực quản đôi chỉ thanh toán 5.209.000', N'Ma_CP IN(''03.3266.0442'',''10.0442.0441'') AND Don_Gia_BV > 5209000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.27', N'Phẫu thuật dò niệu đạo - âm đạo bẩm sinh chỉ thanh toán 2.950.000', N'Ma_CP IN(''03.3537.0434'',''10.0362.0423'') AND Don_Gia_BV > 2950000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.28', N'Phẫu thuật dò niệu đạo - âm đạo-trực tràng bẩm sinh chỉ thanh toán 2.950.000', N'Ma_CP IN(''03.3538.0434'',''10.0363.0423'') AND Don_Gia_BV > 2950000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.29', N'Phẫu thuật dò niệu đạo - trực tràng bẩm sinh chỉ thanh toán 2.950.000', N'Ma_CP IN(''03.3536.0434'',''10.0361.0423'') AND Don_Gia_BV > 2950000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.30', N'Phẫu thuật lấy dị vật vùng hàm mặt chỉ thanh toán 2.303.000', N'Ma_CP IN(''28.0176.1076'',''03.2064.1079'') AND Don_Gia_BV > 2303000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.31', N'Phẫu thuật nội soi cắt u khí quản ống cứng gây tê/gây mê chỉ thanh toán 1.884.000', N'Ma_CP IN(''15.0176.0965'',''15.0176.1000'') AND Don_Gia_BV > 1884000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.32', N'Phẫu thuật nội soi cắt u khí quản ống mềm gây tê/gây mê chỉ thanh toán 1.323.000', N'Ma_CP IN(''15.0177.0965'',''15.0177.1001'') AND Don_Gia_BV > 1323000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.33', N'Phẫu thuật nội soi cắt u phế quản ống cứng gây tê/gây mê chỉ thanh toán 1.884.000', N'Ma_CP IN(''15.0178.0965'',''15.0178.1000'') AND Don_Gia_BV > 1884000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.34', N'Phẫu thuật nội soi cắt u phế quản ống mềm gây tê/gây mê  chỉ thanh toán 1.323.000', N'Ma_CP IN(''15.0179.0965'',''15.0179.1001'') AND Don_Gia_BV > 1323000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.35', N'Phẫu thuật tái tạo các tổn khuyết bằng vạt vi phẫu  chỉ thanh toán 3.167.000', N'Ma_CP IN(''26.0060.0578'',''26.0036.0573'') AND Don_Gia_BV > 3167000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.36', N'Rút nẹp vít và các dụng cụ khác sau phẫu thuật  chỉ thanh toán 1.681.000', N'Ma_CP IN(''03.3900.0563'',''28.0352.1091'') AND Don_Gia_BV > 1681000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.37', N'Siêu âm tử cung buồng trứng qua đường âm đạo  chỉ thanh toán 176.000', N'Ma_CP IN(''18.0031.0003'',''18.0031.0004'') AND Don_Gia_BV > 176000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.38', N'Sốc điện ngoài lồng ngực cấp cứu  chỉ thanh toán 430.000', N'Ma_CP IN(''03.0029.0192'',''01.0032.0299'') AND Don_Gia_BV > 430000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'CV201_PL2.39', N'Vét hạch cổ bảo tồn chỉ thanh toán 3.629.000', N'Ma_CP IN(''12.0093.0915'',''03.2504.0488'') AND Don_Gia_BV > 3629000')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Điện châm (QD3109)', N'Điện châm không điều trị bệnh thoái hóa khớp (QĐ 3109/BYT)', N'ma_cp in (''08.0005.0230'') AND (ma_benhkhac  like (''%M16%'') OR ma_benhkhac like (''%M15%'') OR ma_benhkhac like (''%M17%'') OR ma_benhkhac like (''%M18%'') OR ma_benhkhac like (''%M19%'') OR ma_benh  like (''%M16%'') OR ma_benh like (''%M15%'') OR ma_benh like (''%M17%'') OR ma_benh like (''%M18%'') OR ma_benh like (''%M19%'')  OR ma_benh  like (''%M16%'') OR ma_benh like (''%M15%'') OR ma_benh like (''%M17%'') OR ma_benh like (''%M18%'') OR ma_benh like (''%M19%''))')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Định lượng CEA (TT35)', N' Định lượng CEA không phải chần đoán ung thư biểu mô.', N' ma_cp in (''23.0039.1476'') and substring(ma_benh,1,2) not like (''%D0%'') and substring(ma_benhkhac,1,2) not like (''%D0%'') and ma_benh not like (''C22.7'') and ma_benhkhac not like (''C22.7'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'ĐL CRP', N'Định lượng CRP không phù hợp với chẩn đoán (TT35)', N'ma_cp in(''23.0130.1483'',''23.9000.1483'') and ma_benh not in(''I24.0'',''I25.0'',''I25.4'',''A52.06'',''Q24.5'',''T82.2'',''Z95.5'',''Y52.3'',''R93.1'',''T46.3'',''Z03.4'',''I21'',''I21.0'',''I21.1'',''I21.3'',''I21.4'',''I21.9'',''I22'',''I22.0'',''I22.1'',''I22.8'',''I22.9'',''I25.2'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'HbA1C', N'HbA1c chỉ định không phù hợp', N'MA_CP IN(''23.0083.1523'') AND Ma_Benh NOT LIKE ''E10%'' AND Ma_Benh NOT LIKE ''E11%'' AND Ma_Benh NOT LIKE ''E12%'' AND Ma_Benh NOT LIKE ''E13%'' AND Ma_Benh NOT LIKE ''E14%'' AND Ma_Benh NOT LIKE ''H28.0%'' AND Ma_Benh NOT LIKE ''H36.0%'' AND Ma_Benh NOT LIKE ''G59.0%'' AND Ma_Benh NOT LIKE ''N08.3%'' AND Ma_Benh NOT LIKE ''O24%'' AND Ma_Benh NOT LIKE ''P70.2%'' AND Ma_Benh NOT LIKE ''M14.2%'' AND Ma_BenhKhac NOT LIKE ''%E10%'' AND Ma_BenhKhac NOT LIKE ''%E11%'' AND Ma_BenhKhac NOT LIKE ''%E12%'' AND Ma_BenhKhac NOT LIKE ''%E13%'' AND Ma_BenhKhac NOT LIKE ''%E14%'' AND Ma_BenhKhac NOT LIKE ''%H28.0%'' AND Ma_BenhKhac NOT LIKE ''%H36.0%'' AND Ma_BenhKhac NOT LIKE ''%G59.0%'' AND Ma_BenhKhac NOT LIKE ''%N08.3%'' AND Ma_BenhKhac NOT LIKE ''%O24%'' AND Ma_BenhKhac NOT LIKE ''%P70.2%'' AND Ma_BenhKhac NOT LIKE ''%M14.2%''')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'HongNgoai', N'Bệnh thoái hóa khớp gối  không điều trị hồng ngoại ( QĐ 3109/QĐ-BYT) ', N'Ma_CP IN(''17.0011.0237'') and (Ma_Benh like ''%M17%'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'NCP', N'NCP', N'1=1')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Nội soi có sinh thiết', N'Nội soi có sinh thiết nhưng không làm xét nghiệm mô bệnh học', N'Ma_CP IN(''20.0079.0134'',''20.0073.0136'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Rh(D) Kg PT TM', N'Định nhóm máu hệ Rh(D)/ABO không phẩu thuật, không truyền máu', N'MA_CP IN(''22.0290.1275'',''22.0291.1280'',''22.0292.1280'',''22.0293.1274'',''22.0289.1275'',''22.0294.1273'',''22.0295.1279'',''22.0296.1279'',''22.0226.1377'',''22.0228.1379'',''22.0229.1378'',''22.0231.1376'',''22.0232.1381'',''22.0234.1383'',''22.0235.1382'',''22.0237.1384'',''22.0279.1269'',''22.0280.1269'',''22.0281.1281'',''22.0282.1281'',''22.0283.1269'',''22.0284.1270'',''22.0286.1268'',''22.0287.1272'',''22.0288.1271'',''22.0289.1275'',''22.0290.1275'',''22.0293.1274'',''22.0294.1273'',''22.0285.1267'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'ssssss', N'ssssss', N'ma_cp in ("23.0034.1469") and substring (ma_benh,1,3) not like "%D05%" and substring (ma_benhkhac,1,3) not like "%D05%" and substring (ma_benh,1,3) not like "%C50%" and substring (ma_benhkhac,1,3) not like "%C50%" 
')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Test Hp', N'Test Hp (Helicobacter pylori Ag test nhanh) không chỉ định viêm dạ dày', N'ma_cp in (''24.0073.1658'') and not (ma_benh  like ''%K29%'' or ma_benhkhac  like ''%K29%'') and not (ma_benh  like ''%K31%'' or ma_benhkhac like ''%K31%'') and not (ma_benh like ''%K52%'' or ma_benhkhac  like ''%K52%'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'ThongBQ', N'Thông bàng quang làm cùng rửa bàng quang', N'Ma_CP IN(''01.0164.0210'')')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'TuyRang', N'Điều trị tủy răng không có chụp xquang răng', N'Substring(Ma_CP,9,4) IN (''1012'', ''1013'',''1014'', ''1015'') ')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Tuyrang1', N'Điều trị tủy răng nhưng không chụp Xquang cận chóp đưa về giá răng hàn răng sau ngà (giá 234.000) ', N'Substring(Ma_CP,9,4) IN (''1012'', ''1013'',''1014'', ''1015'') ')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'XBBH (QĐ 3109)', N' Xoa bóp bấm huyệt không điều trị bệnh thoái hóa khớp (QĐ 3109/BYT)', N'LOAI_CP =''xml3'' and MA_NHOM = ''8'' and SUBSTRING(ma_cp,9,4) = ''0280'' and (ma_benhkhac  like (''%M16%'') or ma_benhkhac like (''%M15%'') or ma_benhkhac like (''%M17%'') or ma_benhkhac like (''%M18%'') or ma_benhkhac like (''%M19%'') or ma_benh  like (''%M16%'') or ma_benh like (''%M15%'') or ma_benh like (''%M17%'') or ma_benh like (''%M18%'') or ma_benh like (''%M19%'')  or ma_benh  like (''%M16%'') or ma_benh like (''%M15%'') or ma_benh like (''%M17%'') or ma_benh like (''%M18%'') or ma_benh like (''%M19%''))')
INSERT [dbo].[DanhMucDieuKienDichVu] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'XN Nuoc Tieu kg lq benh than', N'Tổng phân tích nước tiểu BN không có nguyên lý về thận', N'Ma_CP IN(''23.0206.1596'') AND  (MA_BENH not like ''%N18%'' AND MA_BENH not like ''Y84.1'' AND MA_BENH not like ''K76.7'' AND MA_BENH not like ''%N17%'' AND MA_BENH not like''N10'' AND MA_BENH not like''%N11%'' AND MA_BENH not like ''N12'' AND MA_BENH not like ''%N13%'' AND MA_BENH not like''%N14%'' AND MA_BENH not like''%N15%'' AND MA_BENH not like''%N16%'' AND MA_BENH not like''%N20%'' AND MA_BENH not like''%N25%'' AND MA_BENH not like''%N28%'' AND MA_BENH not like ''%N29%'' AND MA_BENH not like ''Y84.1'' AND MA_BENHKHAC not like ''%N18%'' AND MA_BENHKHAC not like ''%Y84.1%'' AND MA_BENHKHAC not like ''%K76.7%'' AND MA_BENHKHAC not like ''%N17%'' AND MA_BENHKHAC not like''%N10%'' AND MA_BENHKHAC not like''%N11%'' AND MA_BENHKHAC not like ''%N12%'' AND MA_BENHKHAC not like ''%N13%'' AND MA_BENHKHAC not like''%N14%'' AND MA_BENHKHAC not like''%N15%'' AND MA_BENHKHAC not like''%N16%'' AND MA_BENHKHAC not like''%N20%'' AND MA_BENHKHAC not like''%N25%'' AND MA_BENHKHAC not like''%N28%'' AND MA_BENHKHAC not like ''%N29%'' AND MA_BENHKHAC not like ''Y84.1'' and ma_benh not like ''%N04%'' and ma_benhkhac not like ''%N04%'' and ma_benh not like ''%O80%'' and ma_benhkhac not like ''%O80%'' and ma_benh not like ''%E11%'' and ma_benhkhac not like ''%E11%'')')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'05C.103', N'Phong liễu Tràng vị khang chỉ TT điều trị viêm đại tràng mạn tính', N'Ma_CP IN(''05C.103'') AND not (MA_BENH  LIKE ''%K50%'' or MA_BENHkhac LIKE ''%K50%'') and not (MA_BENH  LIKE ''%K51%'' or MA_BENHkhac LIKE ''%K51%'')and not (MA_BENH  LIKE ''%K52%'' or MA_BENHkhac LIKE ''%K52%'')')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Abis', N'Sử dụng Thuốc Albis cho BN kg đau dạ dày', N'Ma_CP IN(''40.577+565+579'') AND (Ma_Benh NOT like ''%K25%'' AND Ma_BenhKhac NOT like ''%K25%'' AND Ma_Benh NOT like ''%K26%'' AND Ma_BenhKhac NOT like ''%K26%'' AND Ma_Benh NOT like ''%K27%'' AND Ma_BenhKhac NOT like ''%K27%'' AND Ma_Benh NOT like ''%K28%'' AND Ma_BenhKhac NOT like ''%K28%'' AND Ma_Benh NOT like ''%K29%'' AND Ma_BenhKhac NOT like ''%K29%'' AND Ma_Benh NOT like ''%K21%'' AND Ma_BenhKhac NOT like ''%K21%'' AND Ma_Benh NOT like ''%K21.0%'' AND Ma_BenhKhac NOT like ''%K21.0%'' AND Ma_Benh NOT like ''%K21.9%'' AND Ma_BenhKhac NOT like ''%K21.9%'')')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Glucosomin', N'Thuốc Glucosomin không chỉ định thoái hóa khớp gối(TT40)', N'ma_cp = ''40.64'' and not (ma_benh  like (''%M17%'') or ma_benhkhac  like (''%M17%'')) and not (ma_benh  = ''U62.261'' or ma_benhkhac = ''U62.261'')')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Omicap_D', N'Thuốc  Omicap_D rút số đăng ký và đình chỉ lưu hành (QĐ 149/QĐ-QLD)', N'so_dang_ky in (''VN-11209-10'') and loai_cp = ''xml2''')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Stomedon', N'Thuốc Stomedon rút số đăng ký và đình chỉ lưu hành (QĐ 149/QĐ-QLD)', N'so_dang_ky in (''VD-16099-11'') and loai_cp = ''xml2''')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuốc 40.481', N'Thuốc Trimetazidin được thanh toán BN đau thắt ngực ổn định (TT04) ', N'ma_cp in (''40.481'') and not (ma_benh like (''%I20%'') or ma_benhkhac  like (''%I20%''))')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuốc 40.63', N'Thuốc Diacererin chống chỉ định BN trên 65 tuổi (CV 5543/QLD-DK)', N'ma_cp = ''40.63'' and SUBSTRing(ngay_sinh,1,4) <= ''1952''')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuốc 40.63 (1)', N'Thuốc Diacererin  chỉ định thoái hóa khớp gối và hông (CV 5543/QLD-DK)', N'ma_cp = ''40.63'' and not (ma_benh  like (''%M17%'') or ma_benhkhac  like (''%M17%''))
and not (ma_benh  = ''U62.261'' or ma_benhkhac = ''U62.261'') and SUBSTRing(ngay_sinh,1,4) > ''1952''')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuốc 40.666', N'Thuốc Faditac Inj không chỉ định K29 ,K31', N'ma_cp in (''40.666'') and ma_benh not like (''%K29%'') and ma_benhkhac not like (''%K29%'')and ma_benh not like (''%K31%'') and ma_benhkhac not like (''%K31%'')')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'thuốc 40.67', N'thuốc chứa hoat chất Alphachymotrysin theo CV 22098/QLD-ĐK', N' ma_Cp =''40.67''and not(substring(ma_benh,1,1)  like (''%S%'') or substring(MA_BENHkhac,1,1)  like (''%S%'')) and not (substring(ma_benh,1,1)  like (''%T%'') and substring(MA_BENHkhac,1,1)  like (''%T%''))')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuốc 40.736', N'Thuốc chứa hoạt chất Diosmin + hesperidin chỉ định bệnh trĩ (I84) và dãn tĩnh mạch chi dưới (I83) (CV 61/GDN_NVGD)', N'ma_cp = ''40.736'' and not (ma_benh  like (''%I84%'') or ma_benhkhac  like (''%I84%'')) and not (ma_benh  like (''%I83%'') or ma_benhkhac  like (''%I83%''))')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuoc citicolin', N'Thuốc Citicolin chỉ thanh tóa trong giai đoạn cấp của chấn thương sọ não(18583/QLD-ĐK) ', N'ma_cp in (''40.563'') and not( ma_benh  like (''% I62%'') or ma_benhkhac  like (''%I62%''))')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuốc Hitlankit', N'Thuốc Hitlankit không phải điều trị viêm dạ dày', N'ma_cp in (''40.575+188+183'')')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuốc siro', N'Thuốc siro cho 30 tháng tuổi', N'ma_cp in (''05C.79'') and DATEADD(month,30,NGAY_SINH) > Ngay_Vao')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuoc tranh thai', N'Thuoc tranh thai', N'ma_cp=''40.63'' and not (gioi_tinh=2)')
INSERT [dbo].[DanhMucDieuKienThuoc] ([MaDieuKien], [TenDieuKien], [DieuKien]) VALUES (N'Thuoc747', N'Thuốc L-Ornithin - L- aspartat không Định lượng Amoniac/Xét nghiệm định lượng cấp NH3 trong máu', N'MA_CP IN(''40.747'')')
/****** Object:  StoredProcedure [dbo].[Insert_xml123_67021]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_xml123_67021] @xml123 udt_xml123_67021 READONLY AS BEGIN INSERT INTO xml123_67021 (ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The) SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM @xml123 END
GO
/****** Object:  StoredProcedure [dbo].[Insert_xml123_67024]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_xml123_67024] @xml123 udt_xml123_67024 READONLY AS BEGIN INSERT INTO xml123_67024 (ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The) SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM @xml123 END
GO
/****** Object:  StoredProcedure [dbo].[Insert_xml123_67025]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_xml123_67025] @xml123 udt_xml123_67025 READONLY AS BEGIN INSERT INTO xml123_67025 (ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The) SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM @xml123 END
GO
/****** Object:  StoredProcedure [dbo].[tenProcedure]    Script Date: 09/07/2018 4:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tenProcedure]
@xml123 tenType READONLY
AS 
BEGIN 
	INSERT INTO XML45011 
	(ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, Ngay_Vao, Ngay_Ra, So_Ngay_DTri , Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, T_TongChi, T_BNTT, T_BHTT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe , T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP , Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV , Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL , Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The, GT_The_Tu, GT_The_Den , Mien_Cung_CT, Muc_Huong_XML1, T_BNCCT, Ngay_KQ, T_NguonKhac_DTL , T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL , Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu) 
	SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, Ngay_Vao, Ngay_Ra, So_Ngay_DTri , Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, T_TongChi, T_BNTT, T_BHTT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe , T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP , Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV , Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL , Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The, GT_The_Tu, GT_The_Den , Mien_Cung_CT, Muc_Huong_XML1, T_BNCCT, Ngay_KQ, T_NguonKhac_DTL , T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL , Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu
	FROM @xml123

END

GO
USE [master]
GO
ALTER DATABASE [DB2018] SET  READ_WRITE 
GO
