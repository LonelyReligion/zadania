USE [TAB]
GO

/****** Object:  Table [dbo].[request]    Script Date: 07/05/2024 21:09:52 ******/
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

