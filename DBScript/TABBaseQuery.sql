USE [TAB]
GO
/****** Object:  Table [dbo].[app_user]    Script Date: 11.06.2024 16:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[app_user](
	[id_app_user] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[type] [nchar](10) NOT NULL,
	[password] [nchar](10) NOT NULL,
	[login] [nchar](10) NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_AppUser] PRIMARY KEY CLUSTERED 
(
	[id_app_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 11.06.2024 16:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id_client] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[issue]    Script Date: 11.06.2024 16:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[issue](
	[id_issue] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[id_product_manager] [decimal](18, 0) NULL,
	[type] [nchar](10) NOT NULL,
	[status] [nchar](10) NOT NULL,
	[description] [varchar](max) NOT NULL,
	[result] [varchar](max) NULL,
	[dt_open] [datetime] NOT NULL,
	[id_request] [decimal](18, 0) NOT NULL,
	[dt_final_cancel] [datetime] NULL,
 CONSTRAINT [PK_Issue] PRIMARY KEY CLUSTERED 
(
	[id_issue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[request]    Script Date: 11.06.2024 16:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[request](
	[id_request] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[id_account_manager] [decimal](18, 0) NOT NULL,
	[id_version] [decimal](18, 0) NOT NULL,
	[dt_open] [datetime] NOT NULL,
	[status] [nchar](10) NOT NULL,
	[description] [varchar](max) NOT NULL,
	[result] [varchar](max) NULL,
	[dt_final_cancel] [datetime] NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[id_request] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[system]    Script Date: 11.06.2024 16:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[system](
	[id_system] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[id_related_system] [decimal](18, 0) NULL,
	[id_client] [decimal](18, 0) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_System] PRIMARY KEY CLUSTERED 
(
	[id_system] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[version]    Script Date: 11.06.2024 16:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[version](
	[number] [varchar](50) NOT NULL,
	[id_version] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[id_system] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Version] PRIMARY KEY CLUSTERED 
(
	[id_version] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[worker_task]    Script Date: 11.06.2024 16:26:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[worker_task](
	[id_worker_task] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[status] [nchar](10) NOT NULL,
	[id_worker] [decimal](18, 0) NULL,
	[result] [varchar](max) NOT NULL,
	[description] [varchar](max) NOT NULL,
	[dt_open] [datetime] NOT NULL,
	[id_issue] [decimal](18, 0) NOT NULL,
	[dt_final_cancel] [datetime] NULL,
 CONSTRAINT [PK_WorkerTask] PRIMARY KEY CLUSTERED 
(
	[id_worker_task] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[app_user] ON 
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(1 AS Decimal(18, 0)), N'ProductMan', N'ProductMan', N'ProductMan', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(2 AS Decimal(18, 0)), N'Worker    ', N'Worker    ', N'Worker    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(3 AS Decimal(18, 0)), N'Admin     ', N'Admin     ', N'Admin     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(4 AS Decimal(18, 0)), N'ACCManager', N'ACCManager', N'ACCManager', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(14 AS Decimal(18, 0)), N'ACCManager', N'password1 ', N'user1     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(15 AS Decimal(18, 0)), N'ACCManager', N'password2 ', N'user2     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(16 AS Decimal(18, 0)), N'ACCManager', N'password3 ', N'user3     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(17 AS Decimal(18, 0)), N'ACCManager', N'password4 ', N'user4     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(18 AS Decimal(18, 0)), N'ACCManager', N'password5 ', N'user5     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(19 AS Decimal(18, 0)), N'ACCManager', N'password6 ', N'user6     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(20 AS Decimal(18, 0)), N'ACCManager', N'password7 ', N'user7     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(21 AS Decimal(18, 0)), N'ACCManager', N'password8 ', N'user8     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(22 AS Decimal(18, 0)), N'ACCManager', N'password9 ', N'user9     ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(23 AS Decimal(18, 0)), N'ACCManager', N'password10', N'user10    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(24 AS Decimal(18, 0)), N'ACCManager', N'password11', N'user11    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(25 AS Decimal(18, 0)), N'ACCManager', N'password12', N'user12    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(26 AS Decimal(18, 0)), N'ACCManager', N'password13', N'user13    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(27 AS Decimal(18, 0)), N'ACCManager', N'password14', N'user14    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(28 AS Decimal(18, 0)), N'ACCManager', N'password15', N'user15    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(29 AS Decimal(18, 0)), N'ACCManager', N'password16', N'user16    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(30 AS Decimal(18, 0)), N'ACCManager', N'password17', N'user17    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(31 AS Decimal(18, 0)), N'ACCManager', N'password18', N'user18    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(32 AS Decimal(18, 0)), N'ACCManager', N'password19', N'user19    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(33 AS Decimal(18, 0)), N'ACCManager', N'password20', N'user20    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(34 AS Decimal(18, 0)), N'ProductMan', N'pass1234  ', N'ProdMan12 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(35 AS Decimal(18, 0)), N'ProductMan', N'pass2345  ', N'ProdMan7  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(36 AS Decimal(18, 0)), N'ProductMan', N'pass3456  ', N'ProdMan8  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(37 AS Decimal(18, 0)), N'ProductMan', N'pass4567  ', N'ProdMan9  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(38 AS Decimal(18, 0)), N'ProductMan', N'pass5678  ', N'ProdMan10 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(39 AS Decimal(18, 0)), N'ProductMan', N'pass6789  ', N'ProdMan11 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(40 AS Decimal(18, 0)), N'ProductMan', N'pass7890  ', N'ProdMan13 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(41 AS Decimal(18, 0)), N'ProductMan', N'pass8901  ', N'ProdMan14 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(42 AS Decimal(18, 0)), N'ProductMan', N'pass9012  ', N'ProdMan15 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(43 AS Decimal(18, 0)), N'ProductMan', N'pass0123  ', N'ProdMan16 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(44 AS Decimal(18, 0)), N'ProductMan', N'pass1234  ', N'ProdMan17 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(45 AS Decimal(18, 0)), N'ProductMan', N'pass2345  ', N'ProdMan18 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(46 AS Decimal(18, 0)), N'ProductMan', N'pass3456  ', N'ProdMan19 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(47 AS Decimal(18, 0)), N'ProductMan', N'pass4567  ', N'ProdMan20 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(48 AS Decimal(18, 0)), N'ProductMan', N'pass5678  ', N'ProdMan21 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(49 AS Decimal(18, 0)), N'ProductMan', N'pass6789  ', N'ProdMan22 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(50 AS Decimal(18, 0)), N'ProductMan', N'pass7890  ', N'ProdMan23 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(51 AS Decimal(18, 0)), N'ProductMan', N'pass8901  ', N'ProdMan24 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(52 AS Decimal(18, 0)), N'ProductMan', N'pass9012  ', N'ProdMan25 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(53 AS Decimal(18, 0)), N'ProductMan', N'pass0123  ', N'ProdMan26 ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(54 AS Decimal(18, 0)), N'Worker    ', N'pass1234  ', N'Worker1   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(55 AS Decimal(18, 0)), N'Worker    ', N'pass2345  ', N'Worker2   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(56 AS Decimal(18, 0)), N'Worker    ', N'pass3456  ', N'Worker3   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(57 AS Decimal(18, 0)), N'Worker    ', N'pass4567  ', N'Worker4   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(58 AS Decimal(18, 0)), N'Worker    ', N'pass5678  ', N'Worker5   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(59 AS Decimal(18, 0)), N'Worker    ', N'pass6789  ', N'Worker6   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(60 AS Decimal(18, 0)), N'Worker    ', N'pass7890  ', N'Worker7   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(61 AS Decimal(18, 0)), N'Worker    ', N'pass8901  ', N'Worker8   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(62 AS Decimal(18, 0)), N'Worker    ', N'pass9012  ', N'Worker9   ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(63 AS Decimal(18, 0)), N'Worker    ', N'pass0123  ', N'Worker10  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(64 AS Decimal(18, 0)), N'Worker    ', N'pass1234  ', N'Worker11  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(65 AS Decimal(18, 0)), N'Worker    ', N'pass2345  ', N'Worker12  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(66 AS Decimal(18, 0)), N'Worker    ', N'pass3456  ', N'Worker13  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(67 AS Decimal(18, 0)), N'Worker    ', N'pass4567  ', N'Worker14  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(68 AS Decimal(18, 0)), N'Worker    ', N'pass5678  ', N'Worker15  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(69 AS Decimal(18, 0)), N'Worker    ', N'pass6789  ', N'Worker16  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(70 AS Decimal(18, 0)), N'Worker    ', N'pass7890  ', N'Worker17  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(71 AS Decimal(18, 0)), N'Worker    ', N'pass8901  ', N'Worker18  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(72 AS Decimal(18, 0)), N'Worker    ', N'pass9012  ', N'Worker19  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(73 AS Decimal(18, 0)), N'Worker    ', N'pass0123  ', N'Worker20  ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(74 AS Decimal(18, 0)), N'Admin     ', N'pass1234  ', N'Admin1    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(75 AS Decimal(18, 0)), N'Admin     ', N'pass2345  ', N'Admin2    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(76 AS Decimal(18, 0)), N'Admin     ', N'pass3456  ', N'Admin3    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(77 AS Decimal(18, 0)), N'Admin     ', N'pass4567  ', N'Admin4    ', 1)
GO
INSERT [dbo].[app_user] ([id_app_user], [type], [password], [login], [active]) VALUES (CAST(78 AS Decimal(18, 0)), N'Admin     ', N'pass5678  ', N'Admin5    ', 1)
GO
SET IDENTITY_INSERT [dbo].[app_user] OFF
GO
SET IDENTITY_INSERT [dbo].[client] ON 
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(1 AS Decimal(18, 0)), N'Client A')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(2 AS Decimal(18, 0)), N'Client B')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(3 AS Decimal(18, 0)), N'Client C')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(4 AS Decimal(18, 0)), N'Client D')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(5 AS Decimal(18, 0)), N'Client E')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(6 AS Decimal(18, 0)), N'Client F')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(7 AS Decimal(18, 0)), N'Client G')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(8 AS Decimal(18, 0)), N'Client H')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(9 AS Decimal(18, 0)), N'Client I')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(10 AS Decimal(18, 0)), N'Client J')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(11 AS Decimal(18, 0)), N'Client K')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(12 AS Decimal(18, 0)), N'Client L')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(13 AS Decimal(18, 0)), N'Client M')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(14 AS Decimal(18, 0)), N'Client N')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(15 AS Decimal(18, 0)), N'Client O')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(16 AS Decimal(18, 0)), N'Client P')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(17 AS Decimal(18, 0)), N'Client Q')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(18 AS Decimal(18, 0)), N'Client R')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(19 AS Decimal(18, 0)), N'Client S')
GO
INSERT [dbo].[client] ([id_client], [name]) VALUES (CAST(20 AS Decimal(18, 0)), N'Client T')
GO
SET IDENTITY_INSERT [dbo].[client] OFF
GO
SET IDENTITY_INSERT [dbo].[issue] ON 
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(22 AS Decimal(18, 0)), CAST(34 AS Decimal(18, 0)), N'Feature   ', N'Cancelled ', N'Issue with login functionality', N'Result test', CAST(N'2024-05-20T08:30:00.000' AS DateTime), CAST(38 AS Decimal(18, 0)), CAST(N'2024-06-09T22:39:55.473' AS DateTime))
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(23 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)), N'Feature   ', N'Closed    ', N'Add new reporting feature', N'Feature implemented successfully', CAST(N'2024-05-21T09:00:00.000' AS DateTime), CAST(39 AS Decimal(18, 0)), CAST(N'2024-05-22T17:00:00.000' AS DateTime))
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(24 AS Decimal(18, 0)), CAST(34 AS Decimal(18, 0)), N'Feature   ', N'closed    ', N'Error', N'test', CAST(N'2024-05-22T10:15:00.000' AS DateTime), CAST(40 AS Decimal(18, 0)), CAST(N'2024-06-09T23:12:00.090' AS DateTime))
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(25 AS Decimal(18, 0)), CAST(37 AS Decimal(18, 0)), N'Improve   ', N'Open      ', N'Improve loading', NULL, CAST(N'2024-05-23T11:45:00.000' AS DateTime), CAST(41 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(26 AS Decimal(18, 0)), CAST(34 AS Decimal(18, 0)), N'Improve   ', N'In Progr  ', N'Test desc test', NULL, CAST(N'2024-05-24T12:30:00.000' AS DateTime), CAST(42 AS Decimal(18, 0)), CAST(N'2024-05-25T14:00:00.000' AS DateTime))
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(27 AS Decimal(18, 0)), CAST(34 AS Decimal(18, 0)), N'Bug       ', N'Closed    ', N'Fix crash on product page', N'Bug fixed in version 2.0.1', CAST(N'2024-05-25T08:30:00.000' AS DateTime), CAST(43 AS Decimal(18, 0)), CAST(N'2024-05-26T09:00:00.000' AS DateTime))
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(28 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)), N'Feature   ', N'In Progr  ', N'Add multi-language support', NULL, CAST(N'2024-05-26T09:45:00.000' AS DateTime), CAST(44 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(29 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Bug       ', N'Open      ', N'Memory leak ups', NULL, CAST(N'2024-05-27T10:00:00.000' AS DateTime), CAST(45 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(30 AS Decimal(18, 0)), CAST(37 AS Decimal(18, 0)), N'Improve   ', N'Closed    ', N'Optimize SQL queries for reports', N'Improvement deployed in version 2.1.0', CAST(N'2024-05-28T10:15:00.000' AS DateTime), CAST(53 AS Decimal(18, 0)), CAST(N'2024-05-29T16:00:00.000' AS DateTime))
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(31 AS Decimal(18, 0)), CAST(38 AS Decimal(18, 0)), N'Feature   ', N'Open      ', N'Implement dark mode', NULL, CAST(N'2024-05-29T11:00:00.000' AS DateTime), CAST(54 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(32 AS Decimal(18, 0)), CAST(34 AS Decimal(18, 0)), N'Bug       ', N'Cancelled ', N'Resolve issue with email notifications', N'Cancelled due to project scope change', CAST(N'2024-05-30T12:00:00.000' AS DateTime), CAST(55 AS Decimal(18, 0)), CAST(N'2024-05-31T13:00:00.000' AS DateTime))
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(33 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)), N'Feature   ', N'Closed    ', N'Add user activity tracking', N'Feature added in version 2.2.0', CAST(N'2024-06-01T14:00:00.000' AS DateTime), CAST(60 AS Decimal(18, 0)), CAST(N'2024-06-02T15:00:00.000' AS DateTime))
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(34 AS Decimal(18, 0)), CAST(36 AS Decimal(18, 0)), N'Improve   ', N'In Progr  ', N'Enhance security for login process', NULL, CAST(N'2024-06-03T15:30:00.000' AS DateTime), CAST(61 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(35 AS Decimal(18, 0)), CAST(37 AS Decimal(18, 0)), N'Bug       ', N'in progr  ', N'Fix alignment issues on mobile view', NULL, CAST(N'2024-06-04T16:00:00.000' AS DateTime), CAST(38 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(36 AS Decimal(18, 0)), CAST(38 AS Decimal(18, 0)), N'Feature   ', N'Open      ', N'Enable data export to CSV', NULL, CAST(N'2024-06-05T17:00:00.000' AS DateTime), CAST(45 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(38 AS Decimal(18, 0)), CAST(41 AS Decimal(18, 0)), N'Improve   ', N'Open      ', N'Nasz issue', NULL, CAST(N'2024-06-09T22:04:08.513' AS DateTime), CAST(41 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(43 AS Decimal(18, 0)), CAST(43 AS Decimal(18, 0)), N'Bug       ', N'Open      ', N'Descrpition test', NULL, CAST(N'2024-06-09T23:34:05.040' AS DateTime), CAST(73 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(44 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Bug       ', N'Open      ', N'Test', NULL, CAST(N'2024-06-09T23:34:51.737' AS DateTime), CAST(40 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(45 AS Decimal(18, 0)), CAST(50 AS Decimal(18, 0)), N'Feature   ', N'Open      ', N'Test', NULL, CAST(N'2024-06-09T23:37:51.540' AS DateTime), CAST(45 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(47 AS Decimal(18, 0)), CAST(37 AS Decimal(18, 0)), N'Feature   ', N'Open      ', N'New issue', NULL, CAST(N'2024-06-11T15:28:52.207' AS DateTime), CAST(39 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(48 AS Decimal(18, 0)), CAST(52 AS Decimal(18, 0)), N'Bug       ', N'Open      ', N'Problem', NULL, CAST(N'2024-06-11T15:29:21.017' AS DateTime), CAST(39 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(49 AS Decimal(18, 0)), CAST(43 AS Decimal(18, 0)), N'Improve   ', N'Open      ', N'Issue with sth', NULL, CAST(N'2024-06-11T15:29:36.853' AS DateTime), CAST(39 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(50 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Bug       ', N'Open      ', N'Description of the issue', NULL, CAST(N'2024-06-11T15:31:38.993' AS DateTime), CAST(41 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(51 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Feature   ', N'Open      ', N'Description of the issue 2', NULL, CAST(N'2024-06-11T15:32:00.100' AS DateTime), CAST(41 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(52 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Improve   ', N'Open      ', N'Improve issue', NULL, CAST(N'2024-06-11T15:32:09.410' AS DateTime), CAST(41 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(53 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Bug       ', N'Open      ', N'Issue', NULL, CAST(N'2024-06-11T16:12:49.207' AS DateTime), CAST(44 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[issue] ([id_issue], [id_product_manager], [type], [status], [description], [result], [dt_open], [id_request], [dt_final_cancel]) VALUES (CAST(54 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'Feature   ', N'Open      ', N'iss', NULL, CAST(N'2024-06-11T16:14:10.417' AS DateTime), CAST(44 AS Decimal(18, 0)), NULL)
GO
SET IDENTITY_INSERT [dbo].[issue] OFF
GO
SET IDENTITY_INSERT [dbo].[request] ON 
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(38 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(21 AS Decimal(18, 0)), CAST(N'2007-05-08T12:35:29.000' AS DateTime), N'in progr  ', N'Description 1', N'Final result', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(39 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(21 AS Decimal(18, 0)), CAST(N'2023-05-01T10:00:00.000' AS DateTime), N'cancelled ', N'Description 1', N'Result result', CAST(N'2024-06-09T20:06:41.247' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(40 AS Decimal(18, 0)), CAST(24 AS Decimal(18, 0)), CAST(11 AS Decimal(18, 0)), CAST(N'2007-05-08T12:35:29.000' AS DateTime), N'closed    ', N'Description 2', N'Result 2', CAST(N'2023-05-03T15:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(41 AS Decimal(18, 0)), CAST(31 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(N'2023-05-03T12:00:00.000' AS DateTime), N'open      ', N'Description 3', N'Result 3', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(42 AS Decimal(18, 0)), CAST(25 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), CAST(N'2023-05-04T13:00:00.000' AS DateTime), N'in progr  ', N'Description 4', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(43 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)), CAST(N'2023-05-05T14:00:00.000' AS DateTime), N'cancelled ', N'Description 5', N'Result 5', CAST(N'2023-05-06T16:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(44 AS Decimal(18, 0)), CAST(17 AS Decimal(18, 0)), CAST(13 AS Decimal(18, 0)), CAST(N'2023-05-06T15:00:00.000' AS DateTime), N'closed    ', N'Description 6', N'Result 6', CAST(N'2023-05-07T17:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(45 AS Decimal(18, 0)), CAST(28 AS Decimal(18, 0)), CAST(4 AS Decimal(18, 0)), CAST(N'2023-05-07T16:00:00.000' AS DateTime), N'open      ', N'Description 7', N'Result 7', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(53 AS Decimal(18, 0)), CAST(33 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(N'2023-05-08T17:00:00.000' AS DateTime), N'in progr  ', N'Description 8', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(54 AS Decimal(18, 0)), CAST(31 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), CAST(N'2023-05-09T18:00:00.000' AS DateTime), N'open      ', N'Description 9', N'Result 9', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(55 AS Decimal(18, 0)), CAST(32 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(N'2023-05-10T19:00:00.000' AS DateTime), N'closed    ', N'Description 10', N'Result 10', CAST(N'2023-05-11T20:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(60 AS Decimal(18, 0)), CAST(19 AS Decimal(18, 0)), CAST(16 AS Decimal(18, 0)), CAST(N'2023-05-11T20:00:00.000' AS DateTime), N'cancelled ', N'Description 11', N'Result 11', CAST(N'2023-05-12T21:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(61 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(6 AS Decimal(18, 0)), CAST(N'2023-05-12T21:00:00.000' AS DateTime), N'open      ', N'Description 12', N'Result 12', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(64 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(7 AS Decimal(18, 0)), CAST(N'2023-05-13T22:00:00.000' AS DateTime), N'in progr  ', N'Description 13', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(66 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(17 AS Decimal(18, 0)), CAST(N'2023-05-14T23:00:00.000' AS DateTime), N'closed    ', N'Description 14', N'Result 14', CAST(N'2023-05-15T23:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(67 AS Decimal(18, 0)), CAST(19 AS Decimal(18, 0)), CAST(16 AS Decimal(18, 0)), CAST(N'2023-05-11T00:00:00.000' AS DateTime), N'cancelled ', N'Description 11', N'Result 11', CAST(N'2023-05-12T21:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(68 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(6 AS Decimal(18, 0)), CAST(N'2023-05-12T00:00:00.000' AS DateTime), N'open      ', N'Description 12', N'Result 12', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(69 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(7 AS Decimal(18, 0)), CAST(N'2023-05-13T00:00:00.000' AS DateTime), N'in progr  ', N'Description 13', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(70 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(17 AS Decimal(18, 0)), CAST(N'2023-05-14T00:00:00.000' AS DateTime), N'closed    ', N'Description 14', N'Result 14', CAST(N'2023-05-15T23:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(71 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(8 AS Decimal(18, 0)), CAST(N'2023-05-15T00:00:00.000' AS DateTime), N'cancelled ', N'Description 15', N'Result 15', CAST(N'2023-05-16T01:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(72 AS Decimal(18, 0)), CAST(18 AS Decimal(18, 0)), CAST(19 AS Decimal(18, 0)), CAST(N'2023-05-16T00:00:00.000' AS DateTime), N'open      ', N'Description 16', N'Result 16', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(73 AS Decimal(18, 0)), CAST(26 AS Decimal(18, 0)), CAST(9 AS Decimal(18, 0)), CAST(N'2023-05-17T00:00:00.000' AS DateTime), N'in progr  ', N'Description 17', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(74 AS Decimal(18, 0)), CAST(32 AS Decimal(18, 0)), CAST(18 AS Decimal(18, 0)), CAST(N'2023-05-18T00:00:00.000' AS DateTime), N'closed    ', N'Description 18', N'Result 18', CAST(N'2023-05-19T04:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(75 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(N'2023-05-19T00:00:00.000' AS DateTime), N'cancelled ', N'Description 19', N'Result 19', CAST(N'2023-05-20T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(76 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(13 AS Decimal(18, 0)), CAST(N'2023-05-20T00:00:00.000' AS DateTime), N'open      ', N'Description 20', N'Result 20', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(81 AS Decimal(18, 0)), CAST(4 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'open      ', N'Description for version 2', N'Result for version 2', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(82 AS Decimal(18, 0)), CAST(4 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'closed    ', N'Description for version 3', N'Result for version 3', CAST(N'2024-06-12T15:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(83 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(4 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'open      ', N'Description for version 4', N'Result for version 4', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(84 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'in progr  ', N'Description for version 5', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(85 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(6 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'cancelled ', N'Description for version 6', N'Result for version 6', CAST(N'2024-06-13T16:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(86 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(7 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'closed    ', N'Description for version 7', N'Result for version 7', CAST(N'2024-06-14T17:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(87 AS Decimal(18, 0)), CAST(16 AS Decimal(18, 0)), CAST(8 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'open      ', N'Description for version 8', N'Result for version 8', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(88 AS Decimal(18, 0)), CAST(16 AS Decimal(18, 0)), CAST(9 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'in progr  ', N'Description for version 9', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(89 AS Decimal(18, 0)), CAST(17 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'open      ', N'Description for version 10', N'Result for version 10', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(90 AS Decimal(18, 0)), CAST(17 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'closed    ', N'Description for version 2', N'Result for version 2', CAST(N'2024-06-15T20:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(91 AS Decimal(18, 0)), CAST(18 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'cancelled ', N'Description for version 3', N'Result for version 3', CAST(N'2024-06-16T21:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(92 AS Decimal(18, 0)), CAST(18 AS Decimal(18, 0)), CAST(4 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'open      ', N'Description for version 4', N'Result for version 4', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(93 AS Decimal(18, 0)), CAST(19 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'in progr  ', N'Description for version 5', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(94 AS Decimal(18, 0)), CAST(19 AS Decimal(18, 0)), CAST(6 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'closed    ', N'Description for version 6', N'Result for version 6', CAST(N'2024-06-17T23:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(95 AS Decimal(18, 0)), CAST(20 AS Decimal(18, 0)), CAST(7 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'cancelled ', N'Description for version 7', N'Result for version 7', CAST(N'2024-06-18T01:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(96 AS Decimal(18, 0)), CAST(20 AS Decimal(18, 0)), CAST(8 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'open      ', N'Description for version 8', N'Result for version 8', NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(97 AS Decimal(18, 0)), CAST(4 AS Decimal(18, 0)), CAST(9 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'in progr  ', N'Description for version 9', NULL, NULL)
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(98 AS Decimal(18, 0)), CAST(4 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'closed    ', N'Description for version 10', N'Result for version 10', CAST(N'2024-06-19T04:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(99 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'cancelled ', N'Description for version 2', N'Result for version 2', CAST(N'2024-06-20T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[request] ([id_request], [id_account_manager], [id_version], [dt_open], [status], [description], [result], [dt_final_cancel]) VALUES (CAST(100 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)), CAST(N'2024-06-11T00:00:00.000' AS DateTime), N'open      ', N'Description for version 3', N'Result for version 3', NULL)
GO
SET IDENTITY_INSERT [dbo].[request] OFF
GO
SET IDENTITY_INSERT [dbo].[system] ON 
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(28 AS Decimal(18, 0)), NULL, CAST(1 AS Decimal(18, 0)), N'Type A', N'System A')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(29 AS Decimal(18, 0)), NULL, CAST(12 AS Decimal(18, 0)), N'Type B', N'System B')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(30 AS Decimal(18, 0)), NULL, CAST(13 AS Decimal(18, 0)), N'Type C', N'System C')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(31 AS Decimal(18, 0)), NULL, CAST(4 AS Decimal(18, 0)), N'Type D', N'System D')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(32 AS Decimal(18, 0)), NULL, CAST(7 AS Decimal(18, 0)), N'Type E', N'System E')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(33 AS Decimal(18, 0)), NULL, CAST(1 AS Decimal(18, 0)), N'Type F', N'System F')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(34 AS Decimal(18, 0)), NULL, CAST(12 AS Decimal(18, 0)), N'Type G', N'System G')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(35 AS Decimal(18, 0)), NULL, CAST(3 AS Decimal(18, 0)), N'Type H', N'System H')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(36 AS Decimal(18, 0)), NULL, CAST(17 AS Decimal(18, 0)), N'Type I', N'System I')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(37 AS Decimal(18, 0)), NULL, CAST(5 AS Decimal(18, 0)), N'Type J', N'System J')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(38 AS Decimal(18, 0)), NULL, CAST(1 AS Decimal(18, 0)), N'Type K', N'System K')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(39 AS Decimal(18, 0)), NULL, CAST(20 AS Decimal(18, 0)), N'Type L', N'System L')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(40 AS Decimal(18, 0)), NULL, CAST(3 AS Decimal(18, 0)), N'Type M', N'System M')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(41 AS Decimal(18, 0)), NULL, CAST(4 AS Decimal(18, 0)), N'Type N', N'System N')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(42 AS Decimal(18, 0)), NULL, CAST(5 AS Decimal(18, 0)), N'Type O', N'System O')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(43 AS Decimal(18, 0)), NULL, CAST(16 AS Decimal(18, 0)), N'Type P', N'System P')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(44 AS Decimal(18, 0)), NULL, CAST(2 AS Decimal(18, 0)), N'Type Q', N'System Q')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(45 AS Decimal(18, 0)), NULL, CAST(13 AS Decimal(18, 0)), N'Type R', N'System R')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(46 AS Decimal(18, 0)), NULL, CAST(18 AS Decimal(18, 0)), N'Type S', N'System S')
GO
INSERT [dbo].[system] ([id_system], [id_related_system], [id_client], [type], [name]) VALUES (CAST(47 AS Decimal(18, 0)), NULL, CAST(5 AS Decimal(18, 0)), N'Type T', N'System T')
GO
SET IDENTITY_INSERT [dbo].[system] OFF
GO
SET IDENTITY_INSERT [dbo].[version] ON 
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 1.0', CAST(2 AS Decimal(18, 0)), CAST(28 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 1.1', CAST(3 AS Decimal(18, 0)), CAST(29 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 1.2', CAST(4 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 2.0', CAST(5 AS Decimal(18, 0)), CAST(31 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 2.1', CAST(6 AS Decimal(18, 0)), CAST(32 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 2.2', CAST(7 AS Decimal(18, 0)), CAST(33 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 3.0', CAST(8 AS Decimal(18, 0)), CAST(34 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 3.1', CAST(9 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 3.2', CAST(10 AS Decimal(18, 0)), CAST(36 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 4.0', CAST(11 AS Decimal(18, 0)), CAST(37 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 4.1', CAST(12 AS Decimal(18, 0)), CAST(38 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 4.2', CAST(13 AS Decimal(18, 0)), CAST(39 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 5.0', CAST(14 AS Decimal(18, 0)), CAST(40 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 5.1', CAST(15 AS Decimal(18, 0)), CAST(41 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 5.2', CAST(16 AS Decimal(18, 0)), CAST(42 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 6.0', CAST(17 AS Decimal(18, 0)), CAST(43 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 6.1', CAST(18 AS Decimal(18, 0)), CAST(44 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 6.2', CAST(19 AS Decimal(18, 0)), CAST(45 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 7.0', CAST(20 AS Decimal(18, 0)), CAST(46 AS Decimal(18, 0)))
GO
INSERT [dbo].[version] ([number], [id_version], [id_system]) VALUES (N'Version 7.1', CAST(21 AS Decimal(18, 0)), CAST(47 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[version] OFF
GO
SET IDENTITY_INSERT [dbo].[worker_task] ON 
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(1 AS Decimal(18, 0)), N'open      ', CAST(51 AS Decimal(18, 0)), N'Result 1', N'Description 1', CAST(N'2023-05-01T10:00:00.000' AS DateTime), CAST(23 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(3 AS Decimal(18, 0)), N'closed    ', CAST(53 AS Decimal(18, 0)), N'Ok', N'Description 3', CAST(N'2023-05-03T12:00:00.000' AS DateTime), CAST(23 AS Decimal(18, 0)), CAST(N'2024-06-09T21:14:58.333' AS DateTime))
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(4 AS Decimal(18, 0)), N'open      ', CAST(54 AS Decimal(18, 0)), N'Result 4', N'Description 4', CAST(N'2023-05-04T13:00:00.000' AS DateTime), CAST(24 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(5 AS Decimal(18, 0)), N'in progr  ', CAST(55 AS Decimal(18, 0)), N'Result 5', N'Description 5', CAST(N'2023-05-05T14:00:00.000' AS DateTime), CAST(25 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(6 AS Decimal(18, 0)), N'cancelled ', CAST(56 AS Decimal(18, 0)), N'Result 6', N'Description 6', CAST(N'2023-05-06T15:00:00.000' AS DateTime), CAST(26 AS Decimal(18, 0)), CAST(N'2023-05-07T17:00:00.000' AS DateTime))
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(7 AS Decimal(18, 0)), N'open      ', CAST(57 AS Decimal(18, 0)), N'Result 7', N'Description 7', CAST(N'2023-05-07T16:00:00.000' AS DateTime), CAST(27 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(8 AS Decimal(18, 0)), N'closed    ', CAST(58 AS Decimal(18, 0)), N'Test final', N'Description 8', CAST(N'2023-05-08T17:00:00.000' AS DateTime), CAST(28 AS Decimal(18, 0)), CAST(N'2024-06-10T12:55:44.137' AS DateTime))
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(9 AS Decimal(18, 0)), N'closed    ', CAST(59 AS Decimal(18, 0)), N'Result 9', N'Description 9', CAST(N'2023-05-09T18:00:00.000' AS DateTime), CAST(29 AS Decimal(18, 0)), CAST(N'2023-05-11T20:00:00.000' AS DateTime))
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(10 AS Decimal(18, 0)), N'open      ', CAST(60 AS Decimal(18, 0)), N'Result 10', N'Description 10', CAST(N'2023-05-10T19:00:00.000' AS DateTime), CAST(30 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(12 AS Decimal(18, 0)), N'in progr  ', CAST(56 AS Decimal(18, 0)), N' ', N'Task desc', CAST(N'2024-06-09T23:16:59.287' AS DateTime), CAST(24 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(13 AS Decimal(18, 0)), N'Open      ', CAST(63 AS Decimal(18, 0)), N' ', N'Test', CAST(N'2024-06-09T23:36:27.747' AS DateTime), CAST(24 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(14 AS Decimal(18, 0)), N'Open      ', CAST(58 AS Decimal(18, 0)), N' ', N'Do this and this', CAST(N'2024-06-10T14:20:28.623' AS DateTime), CAST(35 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(15 AS Decimal(18, 0)), N'closed    ', CAST(2 AS Decimal(18, 0)), N'Final test', N'Do sth', CAST(N'2024-06-11T15:37:04.707' AS DateTime), CAST(24 AS Decimal(18, 0)), CAST(N'2024-06-11T16:10:05.670' AS DateTime))
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(16 AS Decimal(18, 0)), N'Open      ', CAST(58 AS Decimal(18, 0)), N' ', N'Task nr 3', CAST(N'2024-06-11T15:37:12.347' AS DateTime), CAST(24 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(17 AS Decimal(18, 0)), N'Open      ', CAST(63 AS Decimal(18, 0)), N' ', N'Task with sth', CAST(N'2024-06-11T15:37:23.923' AS DateTime), CAST(24 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(18 AS Decimal(18, 0)), N'Open      ', CAST(2 AS Decimal(18, 0)), N' ', N'Task for you', CAST(N'2024-06-11T15:37:31.003' AS DateTime), CAST(24 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[worker_task] ([id_worker_task], [status], [id_worker], [result], [description], [dt_open], [id_issue], [dt_final_cancel]) VALUES (CAST(19 AS Decimal(18, 0)), N'Open      ', CAST(65 AS Decimal(18, 0)), N' ', N'Repair the sink', CAST(N'2024-06-11T15:37:50.100' AS DateTime), CAST(24 AS Decimal(18, 0)), NULL)
GO
SET IDENTITY_INSERT [dbo].[worker_task] OFF
GO
ALTER TABLE [dbo].[issue]  WITH CHECK ADD  CONSTRAINT [FK_Issue_ProductManager] FOREIGN KEY([id_product_manager])
REFERENCES [dbo].[app_user] ([id_app_user])
GO
ALTER TABLE [dbo].[issue] CHECK CONSTRAINT [FK_Issue_ProductManager]
GO
ALTER TABLE [dbo].[issue]  WITH CHECK ADD  CONSTRAINT [FK_Issue_Request] FOREIGN KEY([id_request])
REFERENCES [dbo].[request] ([id_request])
GO
ALTER TABLE [dbo].[issue] CHECK CONSTRAINT [FK_Issue_Request]
GO
ALTER TABLE [dbo].[request]  WITH CHECK ADD  CONSTRAINT [FK_Request_AccountManager] FOREIGN KEY([id_account_manager])
REFERENCES [dbo].[app_user] ([id_app_user])
GO
ALTER TABLE [dbo].[request] CHECK CONSTRAINT [FK_Request_AccountManager]
GO
ALTER TABLE [dbo].[request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Version] FOREIGN KEY([id_version])
REFERENCES [dbo].[version] ([id_version])
GO
ALTER TABLE [dbo].[request] CHECK CONSTRAINT [FK_Request_Version]
GO
ALTER TABLE [dbo].[system]  WITH CHECK ADD  CONSTRAINT [FK_System_Client] FOREIGN KEY([id_client])
REFERENCES [dbo].[client] ([id_client])
GO
ALTER TABLE [dbo].[system] CHECK CONSTRAINT [FK_System_Client]
GO
ALTER TABLE [dbo].[version]  WITH CHECK ADD  CONSTRAINT [FK_Version_System] FOREIGN KEY([id_system])
REFERENCES [dbo].[system] ([id_system])
GO
ALTER TABLE [dbo].[version] CHECK CONSTRAINT [FK_Version_System]
GO
ALTER TABLE [dbo].[worker_task]  WITH CHECK ADD  CONSTRAINT [FK_WorkerTask_Issue] FOREIGN KEY([id_issue])
REFERENCES [dbo].[issue] ([id_issue])
GO
ALTER TABLE [dbo].[worker_task] CHECK CONSTRAINT [FK_WorkerTask_Issue]
GO
ALTER TABLE [dbo].[worker_task]  WITH CHECK ADD  CONSTRAINT [FK_WorkerTask_Worker] FOREIGN KEY([id_worker])
REFERENCES [dbo].[app_user] ([id_app_user])
GO
ALTER TABLE [dbo].[worker_task] CHECK CONSTRAINT [FK_WorkerTask_Worker]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'issue', @level2type=N'CONSTRAINT',@level2name=N'FK_Issue_ProductManager'
GO
