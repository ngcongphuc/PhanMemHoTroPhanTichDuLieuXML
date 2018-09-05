CREATE DATABASE [CoSoDuLieu2018_NguyenCongPhuc]
GO
USE [CoSoDuLieu2018_NguyenCongPhuc]
GO

CREATE TABLE [dbo].[DanhMucCoSoKCB](
	[MACSKCB] [nvarchar](50) NULL,
	[TENCSKCB] [nvarchar](800) NULL
) ON [PRIMARY]

GO

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

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucDieuKienDichVuNangCao](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

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

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucDieuKienThuocNangCao](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmQueryMau14a](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmQueryMau19a](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmQueryMau20a](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmQueryMau21a](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmQueryMau7980a](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmQueryNgay](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmQueryPhauThuatThuThuat](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dmQueryThuocVuotTuyen](
	[MaDieuKien] [nvarchar](50) NOT NULL,
	[TenDieuKien] [nvarchar](1000) NOT NULL,
	[DieuKien] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
