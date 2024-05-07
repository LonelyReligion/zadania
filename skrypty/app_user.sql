USE [TAB]
GO

/****** Object:  Table [dbo].[app_user]    Script Date: 07/05/2024 21:09:12 ******/
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

