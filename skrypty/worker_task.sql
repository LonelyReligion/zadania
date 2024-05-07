USE [TAB]
GO

/****** Object:  Table [dbo].[worker_task]    Script Date: 07/05/2024 21:10:24 ******/
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

