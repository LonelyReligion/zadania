USE [TAB]
GO

/****** Object:  Table [dbo].[issue]    Script Date: 07/05/2024 21:09:39 ******/
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

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'issue', @level2type=N'CONSTRAINT',@level2name=N'FK_Issue_ProductManager'
GO

