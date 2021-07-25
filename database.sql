USE [SE13_NEW]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id_Category] [int] NOT NULL,
	[Name_Category] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id_Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONDATNGUYENLIEU]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONDATNGUYENLIEU](
	[IdDonDatNguyenLieu] [nvarchar](50) NOT NULL,
	[idManager] [int] NOT NULL,
	[IdNhaCungCap] [nvarchar](50) NOT NULL,
	[IdNguyenLieu] [nvarchar](50) NOT NULL,
	[SoLuong] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
	[NgayDatHang] [datetime] NULL,
	[ThoiHan] [int] NULL,
 CONSTRAINT [PK_DONDATNGUYENLIEU] PRIMARY KEY CLUSTERED 
(
	[IdDonDatNguyenLieu] ASC,
	[idManager] ASC,
	[IdNhaCungCap] ASC,
	[IdNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink](
	[id_Drink] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [float] NULL,
	[id_Category] [int] NOT NULL,
 CONSTRAINT [PK_Drink] PRIMARY KEY CLUSTERED 
(
	[id_Drink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Local_Store]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Local_Store](
	[id_Local_Store] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Dia_Chi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_Local_Store] PRIMARY KEY CLUSTERED 
(
	[id_Local_Store] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Managers]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Managers](
	[idManager] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[CMND] [nvarchar](50) NULL,
	[Dia_Chi] [nvarchar](50) NULL,
	[Ngay_Vo_Lam] [date] NULL,
	[Ngay_Sinh] [date] NULL,
	[Gioi_Tinh] [bit] NULL,
	[id_Local_Store] [int] NOT NULL,
	[idTaiKhoan] [int] NOT NULL,
 CONSTRAINT [PK_Managers] PRIMARY KEY CLUSTERED 
(
	[idManager] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[IdNguyenLieu] [nvarchar](50) NOT NULL,
	[TenNguyenLieu] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_NGUYENLIEU] PRIMARY KEY CLUSTERED 
(
	[IdNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[IdNhaCungCap] [nvarchar](50) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[IdNguyenLieu] [nvarchar](50) NOT NULL,
	[Gia] [float] NULL,
	[NgayDangKy] [datetime] NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[IdNhaCungCap] ASC,
	[IdNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id_Order] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SDT_Nhan] [nvarchar](50) NULL,
	[Dia_Chi] [nvarchar](50) NULL,
	[Ngay_Dat] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[FeedBach] [nvarchar](50) NULL,
	[id_Local_Store] [int] NOT NULL,
	[id_Name_User] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id_Order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_detail]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Name_SP] [int] NULL,
	[So_Luong] [int] NULL,
	[id_Order] [int] NOT NULL,
 CONSTRAINT [PK_Order_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[idTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NULL,
	[pass] [nvarchar](50) NULL,
	[LoaiTK] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[idTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhTien]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhTien](
	[id_ThanhTien] [int] IDENTITY(1,1) NOT NULL,
	[Total] [float] NULL,
	[id_Order_Detail] [int] NULL,
 CONSTRAINT [PK_ThanhTien] PRIMARY KEY CLUSTERED 
(
	[id_ThanhTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/25/2021 11:36:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id_Name_User] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Dia_Chi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Ngay_Sinh] [date] NULL,
	[Gioi_Tinh] [bit] NULL,
	[idTaiKhoan] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id_Name_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([id_Category], [Name_Category]) VALUES (1, N'Cafe')
INSERT [dbo].[Category] ([id_Category], [Name_Category]) VALUES (2, N'Nước ngọt')
INSERT [dbo].[Category] ([id_Category], [Name_Category]) VALUES (3, N'Trà Sữa')
INSERT [dbo].[Category] ([id_Category], [Name_Category]) VALUES (4, N'Trà')
GO
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (1, N'cafe đen', 12000, 1)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (2, N'trà sữa Socola', 20000, 3)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (3, N'Trà sữa thạch', 30000, 3)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (4, N'Trà sữa bạc hà', 30000, 3)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (5, N'Trà ngũ vị', 10000, 4)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (6, N'Trà hoa nhài', 20000, 4)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (7, N'Trà bạc hà', 20000, 4)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (8, N'soda', 20000, 2)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (9, N'pepsi', 20000, 2)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (10, N'cafesua ', 30000, 1)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (11, N'cafe sài gòn ', 30000, 1)
INSERT [dbo].[Drink] ([id_Drink], [name], [price], [id_Category]) VALUES (12, N'bạc xỉu', 20000, 1)
GO
SET IDENTITY_INSERT [dbo].[Local_Store] ON 

INSERT [dbo].[Local_Store] ([id_Local_Store], [Name], [Dia_Chi], [SDT]) VALUES (1, N'Tocotoco', N'Đà Nẵng', N'0936342672')
INSERT [dbo].[Local_Store] ([id_Local_Store], [Name], [Dia_Chi], [SDT]) VALUES (2, N'House', N'Đà Nẵng ', N'0707235150')
SET IDENTITY_INSERT [dbo].[Local_Store] OFF
GO
SET IDENTITY_INSERT [dbo].[Managers] ON 

INSERT [dbo].[Managers] ([idManager], [Name], [SDT], [CMND], [Dia_Chi], [Ngay_Vo_Lam], [Ngay_Sinh], [Gioi_Tinh], [id_Local_Store], [idTaiKhoan]) VALUES (1, N'Hai Ha', N'0965424701', N'201784832', N'Xuân Thiều ', CAST(N'2019-12-12' AS Date), CAST(N'2000-11-10' AS Date), 0, 1, 10)
SET IDENTITY_INSERT [dbo].[Managers] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([id_Order], [Name], [SDT_Nhan], [Dia_Chi], [Ngay_Dat], [Status], [FeedBach], [id_Local_Store], [id_Name_User]) VALUES (3, N'Việt Phú', N'0707236150', N'Xuân Thiều 6 , Quận Liên Chiểu tp Đà Nẵng', CAST(N'2021-07-24T14:42:29.513' AS DateTime), N'Yes', N'Thêm đường', 1, 7)
INSERT [dbo].[Order] ([id_Order], [Name], [SDT_Nhan], [Dia_Chi], [Ngay_Dat], [Status], [FeedBach], [id_Local_Store], [id_Name_User]) VALUES (4, N'Viet Phu', N'0707236150', N'Xuân Thiều 6, quận Liên Chiểu', CAST(N'2021-07-24T15:38:37.250' AS DateTime), N'Null', N'Thêm sữa', 1, 7)
INSERT [dbo].[Order] ([id_Order], [Name], [SDT_Nhan], [Dia_Chi], [Ngay_Dat], [Status], [FeedBach], [id_Local_Store], [id_Name_User]) VALUES (5, N'Việt Phú', N'0707236150', N'Xuân Thiều 6', CAST(N'2021-07-24T20:45:39.940' AS DateTime), N'No', N'thêm sữa', 1, 7)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Order_detail] ON 

INSERT [dbo].[Order_detail] ([id], [id_Name_SP], [So_Luong], [id_Order]) VALUES (2, 1, 3, 3)
INSERT [dbo].[Order_detail] ([id], [id_Name_SP], [So_Luong], [id_Order]) VALUES (3, 1, 2, 4)
INSERT [dbo].[Order_detail] ([id], [id_Name_SP], [So_Luong], [id_Order]) VALUES (4, 1, 4, 5)
SET IDENTITY_INSERT [dbo].[Order_detail] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [TenTaiKhoan], [pass], [LoaiTK]) VALUES (7, N'Admin', N'22717523707117612889208250218162440193229', N'Admin')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [TenTaiKhoan], [pass], [LoaiTK]) VALUES (10, N'Manager1', N'2469813175416313686163243107215186153229195', N'Manager')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [TenTaiKhoan], [pass], [LoaiTK]) VALUES (12, N'Vietphu0123', N'127762091402378248912291636117317496895', N'User')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [TenTaiKhoan], [pass], [LoaiTK]) VALUES (13, N'Vietphu0123456', N'35253244482272228200143823126109238168116', N'User')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[ThanhTien] ON 

INSERT [dbo].[ThanhTien] ([id_ThanhTien], [Total], [id_Order_Detail]) VALUES (1, 36000, 2)
INSERT [dbo].[ThanhTien] ([id_ThanhTien], [Total], [id_Order_Detail]) VALUES (2, 36000, 2)
INSERT [dbo].[ThanhTien] ([id_ThanhTien], [Total], [id_Order_Detail]) VALUES (3, 24000, 3)
INSERT [dbo].[ThanhTien] ([id_ThanhTien], [Total], [id_Order_Detail]) VALUES (4, 36000, 2)
INSERT [dbo].[ThanhTien] ([id_ThanhTien], [Total], [id_Order_Detail]) VALUES (5, 24000, 3)
INSERT [dbo].[ThanhTien] ([id_ThanhTien], [Total], [id_Order_Detail]) VALUES (6, 48000, 4)
SET IDENTITY_INSERT [dbo].[ThanhTien] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id_Name_User], [Name], [SDT], [Dia_Chi], [Email], [Ngay_Sinh], [Gioi_Tinh], [idTaiKhoan]) VALUES (7, N'Vietphu', N'0707236150', N'Xuan Thieu 6', N'Vietphu0123@gmail.com', CAST(N'2000-10-10' AS Date), 1, 12)
INSERT [dbo].[Users] ([id_Name_User], [Name], [SDT], [Dia_Chi], [Email], [Ngay_Sinh], [Gioi_Tinh], [idTaiKhoan]) VALUES (8, N'Vietphu0123456', NULL, NULL, N'Vietphu0123456@gmail.com', NULL, NULL, 13)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[DONDATNGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [FK_DONDATNGUYENLIEU_Managers] FOREIGN KEY([idManager])
REFERENCES [dbo].[Managers] ([idManager])
GO
ALTER TABLE [dbo].[DONDATNGUYENLIEU] CHECK CONSTRAINT [FK_DONDATNGUYENLIEU_Managers]
GO
ALTER TABLE [dbo].[DONDATNGUYENLIEU]  WITH CHECK ADD  CONSTRAINT [FK_DONDATNGUYENLIEU_NHACUNGCAP] FOREIGN KEY([IdNhaCungCap], [IdNguyenLieu])
REFERENCES [dbo].[NHACUNGCAP] ([IdNhaCungCap], [IdNguyenLieu])
GO
ALTER TABLE [dbo].[DONDATNGUYENLIEU] CHECK CONSTRAINT [FK_DONDATNGUYENLIEU_NHACUNGCAP]
GO
ALTER TABLE [dbo].[Drink]  WITH CHECK ADD  CONSTRAINT [FK_Drink_Category] FOREIGN KEY([id_Category])
REFERENCES [dbo].[Category] ([id_Category])
GO
ALTER TABLE [dbo].[Drink] CHECK CONSTRAINT [FK_Drink_Category]
GO
ALTER TABLE [dbo].[Managers]  WITH CHECK ADD  CONSTRAINT [FK_Managers_TaiKhoan] FOREIGN KEY([idTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([idTaiKhoan])
GO
ALTER TABLE [dbo].[Managers] CHECK CONSTRAINT [FK_Managers_TaiKhoan]
GO
ALTER TABLE [dbo].[NHACUNGCAP]  WITH CHECK ADD  CONSTRAINT [FK_NHACUNGCAP_NGUYENLIEU] FOREIGN KEY([IdNguyenLieu])
REFERENCES [dbo].[NGUYENLIEU] ([IdNguyenLieu])
GO
ALTER TABLE [dbo].[NHACUNGCAP] CHECK CONSTRAINT [FK_NHACUNGCAP_NGUYENLIEU]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Local_Store] FOREIGN KEY([id_Local_Store])
REFERENCES [dbo].[Local_Store] ([id_Local_Store])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Local_Store]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([id_Name_User])
REFERENCES [dbo].[Users] ([id_Name_User])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User]
GO
ALTER TABLE [dbo].[Order_detail]  WITH CHECK ADD  CONSTRAINT [FK_Order_detail_Drink] FOREIGN KEY([id_Name_SP])
REFERENCES [dbo].[Drink] ([id_Drink])
GO
ALTER TABLE [dbo].[Order_detail] CHECK CONSTRAINT [FK_Order_detail_Drink]
GO
ALTER TABLE [dbo].[Order_detail]  WITH CHECK ADD  CONSTRAINT [FK_Order_detail_Order] FOREIGN KEY([id_Order])
REFERENCES [dbo].[Order] ([id_Order])
GO
ALTER TABLE [dbo].[Order_detail] CHECK CONSTRAINT [FK_Order_detail_Order]
GO
ALTER TABLE [dbo].[ThanhTien]  WITH CHECK ADD  CONSTRAINT [FK_ThanhTien_Order_detail] FOREIGN KEY([id_Order_Detail])
REFERENCES [dbo].[Order_detail] ([id])
GO
ALTER TABLE [dbo].[ThanhTien] CHECK CONSTRAINT [FK_ThanhTien_Order_detail]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_TaiKhoan] FOREIGN KEY([idTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([idTaiKhoan])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_TaiKhoan]
GO
